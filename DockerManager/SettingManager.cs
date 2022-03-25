using DockerManager.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DockerManager
{
    public class SettingManager
    {
        private string SettingFileName { get; set; }
        public List<SettingModel> CurrentSetting { get; set; }
        public SettingManager()
        {
            SettingFileName = "ServerSetting";
            GetSetting();
        }
        public void GetSetting()
        {
            if (!File.Exists(SettingFileName))
                File.Create(SettingFileName).Close();

            var ReadTxt = File.ReadAllText(SettingFileName);
            CurrentSetting = JsonConvert.DeserializeObject<List<SettingModel>>(ReadTxt);
            if (CurrentSetting == null)
                CurrentSetting = new List<SettingModel> { };
        }
        public bool AddSetting(SettingModel Model)
        {
            Model.SettingId = Guid.NewGuid();
            GetSetting();
            CurrentSetting.Add(Model);

            var WriteTxt = JsonConvert.SerializeObject(CurrentSetting);
            File.WriteAllText(SettingFileName, WriteTxt);

            return true;
        }
        public void UpdateSetting(SettingModel Model)
        {
            var GetModel = CurrentSetting.FirstOrDefault(Item => Item.SettingId == Model.SettingId);

            GetModel.ServerName = Model.ServerName;
            GetModel.Url = Model.Url;
            GetModel.UserName = Model.UserName;
            GetModel.UserToken = Model.UserToken;

            var WriteTxt = JsonConvert.SerializeObject(CurrentSetting);
            File.WriteAllText(SettingFileName, WriteTxt);
            GetSetting();
        }
        public void DeleteSetting(SettingModel Model)
        {
            var GetModel = CurrentSetting.First(Item => Item.SettingId == Model.SettingId);
            CurrentSetting.Remove(GetModel);
            var WriteTxt = JsonConvert.SerializeObject(CurrentSetting);
            File.WriteAllText(SettingFileName, WriteTxt);

            GetSetting();
        }
    }

    public class SshSettingManager
    {
        private string SshSettingFileName { get; set; }
        public List<SshSettingModel> CurrentSetting { get; set; }

        public SshSettingManager()
        {
            SshSettingFileName = "SshServerSetting";
            GetSetting();
        }
        public void GetSetting()
        {
            if (!File.Exists(SshSettingFileName))
                File.Create(SshSettingFileName).Close();

            var ReadTxt = File.ReadAllText(SshSettingFileName);
            CurrentSetting = JsonConvert.DeserializeObject<List<SshSettingModel>>(ReadTxt);
            if (CurrentSetting == null)
                CurrentSetting = new List<SshSettingModel> { };
        }
        public bool AddSetting(SshSettingModel Model)
        {
            Model.SshSettingId = Guid.NewGuid();
            GetSetting();
            CurrentSetting.Add(Model);

            var WriteTxt = JsonConvert.SerializeObject(CurrentSetting);
            File.WriteAllText(SshSettingFileName, WriteTxt);

            return true;
        }
        public void UpdateSetting(SshSettingModel Model)
        {
            var GetModel = CurrentSetting.FirstOrDefault(Item => Item.SshSettingId == Model.SshSettingId);

            GetModel.ServerName = Model.ServerName;
            GetModel.Ip = Model.Ip;
            GetModel.Port = Model.Port;
            GetModel.DeployPort = Model.DeployPort;
            GetModel.DeploySslPort = Model.DeploySslPort;
            GetModel.UserName = Model.UserName;
            GetModel.Password = Model.Password;
            GetModel.IsDeploy = Model.IsDeploy;

            var WriteTxt = JsonConvert.SerializeObject(CurrentSetting);
            File.WriteAllText(SshSettingFileName, WriteTxt);
            GetSetting();
        }
        public void DeleteSetting(SshSettingModel Model)
        {
            var GetModel = CurrentSetting.First(Item => Item.SshSettingId == Model.SshSettingId);
            CurrentSetting.Remove(GetModel);
            var WriteTxt = JsonConvert.SerializeObject(CurrentSetting);
            File.WriteAllText(SshSettingFileName, WriteTxt);

            GetSetting();
        }
    }
}