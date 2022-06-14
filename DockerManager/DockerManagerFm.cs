using DockerManager.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DockerManager
{
    public partial class DockerManagerFm : Form
    {
        private DockerController Docker;
        private SettingManager Setting;
        private SettingModel CurrentModel;

        private SshSettingManager SshSetting;
        private SshSettingModel CurrentSshModel;

        public DockerManagerFm()
        {
            InitializeComponent();
            Docker = new DockerController();
            Setting = new SettingManager();
            SshSetting = new SshSettingManager();
            DgImage.SelectionChanged += DgImage_SelectionChanged;

            DgImageDetail.CellContentClick += DgImageDetail_CellContentClick;

            CbServer.SelectedIndexChanged += CbServer_SelectedIndexChanged;
            CbServer.DataSource = Setting.CurrentSetting;
            CbServer.DisplayMember = "ServerName";

            CbSshServer.SelectedIndexChanged += CbSshServer_SelectedIndexChanged;
            CbSshServer.DataSource = SshSetting.CurrentSetting;
            CbSshServer.DisplayMember = "ServerName";
        }

        private void CbSshServer_SelectedIndexChanged(object? sender, EventArgs e)
        {
            var Model = (SshSettingModel)CbSshServer.SelectedItem;
            RefreshSshSetting(Model);
        }

        private void CbServer_SelectedIndexChanged(object? sender, EventArgs e)
        {
            var Model = (SettingModel)CbServer.SelectedItem;
            RefreshSetting(Model);
        }
        private void RefreshSetting(SettingModel Model)
        {
            CurrentModel = Model;

            TxtUrl.DataBindings.Clear();
            TxtTag.DataBindings.Clear();
            TxtOwner.DataBindings.Clear();
            TxtUserName.DataBindings.Clear();
            TxtUserToken.DataBindings.Clear();

            TxtUrl.DataBindings.Add("Text", CurrentModel, "Url");
            TxtTag.DataBindings.Add("Text", CurrentModel, "Tag");
            TxtOwner.DataBindings.Add("Text", CurrentModel, "Owner");
            TxtUserName.DataBindings.Add("Text", CurrentModel, "UserName");
            TxtUserToken.DataBindings.Add("Text", CurrentModel, "UserToken");
        }

        private void RefreshSshSetting(SshSettingModel Model)
        {
            CurrentSshModel = Model;
            TxtSshIp.DataBindings.Clear();
            TxtSshPort.DataBindings.Clear();
            TxtSshDeployPort.DataBindings.Clear();
            TxtSshDeploySslPort.DataBindings.Clear();
            TxtSshUserName.DataBindings.Clear();
            TxtSshPassword.DataBindings.Clear();
            CbIsDeploy.DataBindings.Clear();

            TxtSshIp.DataBindings.Add("Text", CurrentSshModel, "Ip");
            TxtSshPort.DataBindings.Add("Text", CurrentSshModel, "Port");
            TxtSshDeployPort.DataBindings.Add("Text", CurrentSshModel, "DeployPort");
            TxtSshDeploySslPort.DataBindings.Add("Text", CurrentSshModel, "DeploySslPort");
            TxtSshUserName.DataBindings.Add("Text", CurrentSshModel, "UserName");
            TxtSshPassword.DataBindings.Add("Text", CurrentSshModel, "Password");
            CbIsDeploy.DataBindings.Add("Checked", CurrentSshModel, "IsDeploy");
        }

        private async void DgImageDetail_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            var DgRow = DgImageDetail.Rows[e.RowIndex];
            var ImageTag = DgRow.Cells["ImageTag"].Value.ToString();
            var ImageId = DgRow.Cells["TagImageId"].Value.ToString();
            var BtnString = DgRow.Cells[e.ColumnIndex].FormattedValue.ToString();
            switch (BtnString)
            {
                case "Push":
                    PushImage(ImageTag!);
                    break;
                case "Delete":
                    //await DeleteImage(ImageTag!, ImageId!);
                    await DeleteTag(ImageTag, ImageId);
                    break;
            }
        }

        private async void DgImage_SelectionChanged(object? sender, EventArgs e)
        {
            var GetCells = DgImage.SelectedCells;

            if (GetCells.Count > 0)
            {
                var GetCell = GetCells[0];
                var ImageId = DgImage.Rows[GetCell.RowIndex].Cells["ImageId"].Value.ToString();
                await RefreshImageDetail(ImageId);
            }
        }

        private async void DockerManager_Load(object sender, EventArgs e)
        {
            await RefreshImage();
        }

        private async void BtnRefesh_Click(object sender, EventArgs e)
        {
            await RefreshImage();
        }

        private async Task RefreshImage()
        {
            DgImage.DataSource = await Docker.GetImages();
        }
        private async Task RefreshImageDetail(string ImageId = null)
        {
            DgImageDetail.DataSource = await Docker.GetImageDetail(ImageId);
            DgImageDetail.ClearSelection();
        }

        private async Task DeleteTag(string ImageNameTag, string ImageId)
        {
            var Msg = $"確定要刪除 {ImageNameTag} 嗎?";
            if (MessageBox.Show(Msg, "確認刪除", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (ImageNameTag.ToLower().Contains("none"))
                    ImageNameTag = ImageId;
                var IsDelete = await Docker.DeleteImage(ImageNameTag);
                if (IsDelete)
                    await RefreshImage();
            }
        }

        private async Task DeleteImage(string ImageNameTag, string ImageId)
        {
            var Msg = $"確定要刪除 {ImageNameTag} 嗎?";
            if (MessageBox.Show(Msg, "確認刪除", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var IsDelete = await Docker.DeleteImage(ImageId);
                if (IsDelete)
                    await RefreshImage();
            }
        }

        private void PushImage(string ImageNameTag)
        {
            var Msg = $"確定要推送 {ImageNameTag} 到 {CurrentModel.Url} 嗎?";

            var AlertAction = new Action<string>((ErrorMsg) =>
            {
                MessageBox.Show(ErrorMsg, "訊息");
            });

            var RefreshAction = new Action(() => Invoke(() => DgImage_SelectionChanged(null, EventArgs.Empty)));

            if (MessageBox.Show(Msg, "確認推送", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Invoke(() => Docker.PushImage(ImageNameTag!, CurrentModel, CurrentSshModel, AlertAction, RefreshAction));
            }
        }

        private void BtnServerAdd_Click(object sender, EventArgs e)
        {
            var ServerAddFm = new ServerAdd(Setting);
            var Ret = ServerAddFm.ShowDialog();
            if (Ret == DialogResult.OK)
                RefreshServerSetting();
        }

        private void BtnDeleteSetting_Click(object sender, EventArgs e)
        {
            var Model = (SettingModel)CbServer.SelectedItem;
            var MsgRet = MessageBox.Show($"是否要刪除 {Model.ServerName}", "確認刪除", MessageBoxButtons.YesNo);
            if (MsgRet == DialogResult.Yes)
                Setting.DeleteSetting(Model);

            RefreshServerSetting();
        }

        private void RefreshServerSetting()
        {
            CbServer.DataSource = Setting.CurrentSetting;
        }

        private void BtnUpdateSetting_Click(object sender, EventArgs e)
        {
            Setting.UpdateSetting(CurrentModel);
            MessageBox.Show("更新成功");
        }

        private void BtnSshServerAdd_Click(object sender, EventArgs e)
        {
            var SshServerAddFm = new SshServerAdd(SshSetting);
            var Ret = SshServerAddFm.ShowDialog();
            if (Ret == DialogResult.OK)
                RefreshSshServerSetting();
        }

        private void BtnUpdateSshSetting_Click(object sender, EventArgs e)
        {
            SshSetting.UpdateSetting(CurrentSshModel);
            MessageBox.Show("更新成功");
        }

        private void BtnDeleteSshSetting_Click(object sender, EventArgs e)
        {
            var Model = (SshSettingModel)CbSshServer.SelectedItem;
            var MsgRet = MessageBox.Show($"是否要刪除 {Model.ServerName}", "確認刪除", MessageBoxButtons.YesNo);
            if (MsgRet == DialogResult.Yes)
                SshSetting.DeleteSetting(Model);

            RefreshSshServerSetting();
        }
        private void RefreshSshServerSetting()
        {
            CbSshServer.DataSource = SshSetting.CurrentSetting;
        }
    }
}