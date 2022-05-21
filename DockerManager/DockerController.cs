using Docker.DotNet;
using Docker.DotNet.Models;
using DockerManager.Model;
using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DockerManager
{
    public class DockerController
    {
        private DockerClient DockerClient;
        public DockerController(bool IsLinux = false)
        {
            var EngineUrl = IsLinux ? "unix:///var/run/docker.sock" : "npipe://./pipe/docker_engine";
            DockerClient = new DockerClientConfiguration(new Uri(EngineUrl))
                .CreateClient();
        }

        public async Task<dynamic> GetImages(ImagesListParameters? FindParam = null)
        {
            FindParam ??= new ImagesListParameters()
            {
                All = true,
            };

            var ImageList = await DockerClient.Images.ListImagesAsync(FindParam);

            var Ret = ImageList
                .Select(Item =>
                {
                    var Tag = Item.RepoTags?.OrderBy(Val => Val.Length)?.FirstOrDefault();
                    var Dig = Item.RepoDigests?.FirstOrDefault()?.Split('@')[0];
                    var ImageName = Tag ?? Dig ?? "Not Found Name";
                    var GetData = new
                    {
                        ImageName,
                        CreateTime = Item.Created.AddHours(8),
                        ImageId = Item.ID.Split(":")[1],
                    };
                    return GetData;
                })
                .OrderByDescending(Item => Item.CreateTime)
                .ToList();

            return Ret;
        }
        public async Task<dynamic> GetImageDetail(string? TagImageId = null)
        {
            var FindParam = new ImagesListParameters()
            {
                All = true,
            };

            var ImageList = await DockerClient.Images.ListImagesAsync(FindParam);

            var WhereData = ImageList
                .Where(Item =>
                {
                    if (TagImageId == null)
                        return true;

                    if (Item.ID.Contains(TagImageId))
                        return true;

                    return false;
                });

            var Ret = new List<dynamic> { };
            foreach (var Item in WhereData)
            {
                if (Item.RepoTags != null)
                    Ret.AddRange(Item.RepoTags.Select(Val => new
                    {
                        ImageTag = Val.Split('@')[0],
                        TagImageId,
                    }));
                else
                    Ret.Add(new
                    {
                        ImageTag = "None",
                        TagImageId,
                    });
            }
            return Ret;
        }
        public async Task<bool> DeleteImage(string ImageId)
        {
            var Ret = await DockerClient.Images.DeleteImageAsync(ImageId, new ImageDeleteParameters()
            {
                Force = true,
                NoPrune = true,
            });

            return Ret.Count > 0;
        }
        public async void PushImage(string ImageName, SettingModel SettingModel, SshSettingModel SshSettingModel, Action<string> AlertAction, Action RefreshAction)
        {
            var GetOwner = string.IsNullOrWhiteSpace(SettingModel.Owner) ? SettingModel.UserName : SettingModel.Owner;

            var FullUrl = $"{SettingModel.Url}";
            if (GetOwner != null)
                FullUrl += $"/{GetOwner}";

            if (ImageName.Contains('/') && !ImageName.Contains(FullUrl))
            {
                AlertAction.Invoke($"發佈失敗，錯誤訊息：{ImageName} 已被標記至別的 Server，請使用原始 Image");
                return;
            }

            var FullImageName = ImageName;
            ImageName = ImageName.Split(':')[0].Split('/').Last();

            var MessageFm = new MsgFm();
            MessageFm.Show();

            var CmdProcess = new Process()
            {
                StartInfo = new ProcessStartInfo()
                {
                    FileName = "cmd.exe",
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                },
            };
            CmdProcess.Start();

            CmdProcess.BeginOutputReadLine();
            CmdProcess.BeginErrorReadLine();
            var Input = CmdProcess.StandardInput;
            var IsComplate = false;
            var IsDeployStart = false;
            CmdProcess.OutputDataReceived += async (sender, e) =>
            {
                var Message = e.Data;
                if (string.IsNullOrWhiteSpace(Message))
                    return;
                MessageFm.SendMessage($"Message : {Message}");
                if (Message != null && Message.Contains("latest: digest"))
                {
                    Input.WriteLine($"docker image rm {FullImageName}");
                    IsComplate = true;
                }
                if (IsComplate && !IsDeployStart)
                {
                    IsDeployStart = true;
                    MessageFm.SendMessage("推送成功");
                    await Task.Delay(1000);
                    CmdProcess.Close();
                    CmdProcess.Dispose();

                    if (SshSettingModel.IsDeploy)
                        PullAndDeploy(ImageName, FullImageName, SettingModel, SshSettingModel, AlertAction, MessageFm);
                    else
                        MessageFm.ExitFm();

                }
            };
            CmdProcess.ErrorDataReceived += (sender, e) =>
            {
                var Message = e.Data;
                if (string.IsNullOrWhiteSpace(Message))
                    return;
                MessageFm.SendMessage($"Error : {Message}");
            };

            Input.WriteLine(@"cd c:\");

            if (!FullImageName.Contains(FullUrl))
            {
                var TagImageName = $"{FullUrl}/{FullImageName}";
                Input.WriteLine($"docker image rm {TagImageName}");
                Input.WriteLine($"docker tag {ImageName} {TagImageName}");
                FullImageName = TagImageName;
            }

            if (SettingModel.UserName != null)
            {
                var LoginCmd = $"docker login {SettingModel.Url} -u {SettingModel.UserName}";

                if (SettingModel.UserToken != null)
                    LoginCmd = $"echo {SettingModel.UserToken} | {LoginCmd} --password-stdin";

                Input.WriteLine(LoginCmd);
            }
            Input.WriteLine($"docker push {FullImageName!}");
        }

        private async void PullAndDeploy(string ImageName, string FullImageName, SettingModel ServerSetting, SshSettingModel SshSetting, Action<string> AlertAction, MsgFm MessageFm)
        {
            MessageFm.SendMessage($"\n\n開始部署\n\n");

            var Auth = new PasswordAuthenticationMethod(SshSetting.UserName, SshSetting.Password);
            var SshInfo = new ConnectionInfo(SshSetting.Ip, int.Parse(SshSetting.Port), SshSetting.UserName, Auth);
            var SshClient = new SshClient(SshInfo);

            SshClient.Connect();

            if (!SshClient.IsConnected)
            {
                AlertAction.Invoke("SSH 連線錯誤");
                return;
            }

            var SudoCmd = $"echo {SshSetting.Password}";
            var LoginCmd = $"{SudoCmd} | sudo -S docker login {ServerSetting.Url}";
            if (ServerSetting.UserName != null)
            {
                LoginCmd += $" -u {ServerSetting.UserName}";
                if (ServerSetting.UserToken != null)
                    LoginCmd += $" -p {ServerSetting.UserToken}";
            }

            var SshCommandLines = new List<string>
            {
                $"{SudoCmd} | sudo -S docker kill {ImageName}",
                $"{SudoCmd} | sudo -S docker rm {ImageName}",
                $"{SudoCmd} | sudo -S docker image rm {FullImageName}",
                LoginCmd,
                $"{SudoCmd} | sudo -S docker pull {FullImageName}",
                $"{SudoCmd} | sudo -S docker run -d -p {SshSetting.DeployPort}:80 -p {SshSetting.DeploySslPort}:443 --name {ImageName} {FullImageName}",
                $"{SudoCmd} | sudo -S docker logout {ServerSetting.Url}",
            };

            var LastMessage = "";
            var LastError = "";
            foreach (var CmdLine in SshCommandLines)
            {
                var CmdRun = SshClient.RunCommand(CmdLine);

                LastMessage = CmdRun.Result;
                LastError = CmdRun.Error;

                if (!string.IsNullOrWhiteSpace(CmdRun.Result))
                    MessageFm.SendMessage($"Message : {LastMessage}");
                else if (!string.IsNullOrEmpty(CmdRun.Error))
                    MessageFm.SendMessage($"Error : {LastError}");
            }

            SshClient.Disconnect();
            SshClient.Dispose();

            var Sec = 5;
            while (Sec > 0)
            {
                Sec--;
                await Task.Delay(1000);
            }

            MessageFm?.ExitFm();
            if (!string.IsNullOrWhiteSpace(LastMessage))
                AlertAction("發佈成功");
            else
                AlertAction($"發佈錯誤，錯誤訊息：{LastError}");
        }
    }
}