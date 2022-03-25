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
    public partial class SshServerAdd : Form
    {
        private SshSettingModel Model;
        private BindingSource Source;
        private SshSettingManager Setting;
        public SshServerAdd(SshSettingManager _Setting)
        {
            InitializeComponent();
            Setting = _Setting;
            Model = new SshSettingModel();
            Source = new BindingSource
            {
                DataSource = Model
            };
            TxtSshServerName.DataBindings.Add("Text", Source, "ServerName");
            TxtIp.DataBindings.Add("Text", Source, "Ip");
            TxtPort.DataBindings.Add("Text", Source, "Port");
            TxtDeployPort.DataBindings.Add("Text", Source, "DeployPort");
            TxtDeploySslPort.DataBindings.Add("Text", Source, "DeploySslPort");
            TxtUserName.DataBindings.Add("Text", Source, "UserName");
            TxtPassword.DataBindings.Add("Text", Source, "Password");
            CbIsDeploy.DataBindings.Add("Checked", Source, "IsDeploy");

        }

        private void BtnSshAdd_Click(object sender, EventArgs e)
        {
            static bool ErrorAlert(string Column)
            {
                MessageBox.Show($"{Column} 未填寫");
                return true;
            }

            var IsError = false;
            if (string.IsNullOrWhiteSpace(Model.ServerName))
                IsError = IsError || ErrorAlert("Ssh Server Name");

            if (string.IsNullOrWhiteSpace(Model.Ip))
                IsError = IsError || ErrorAlert("Ip");
             
            if (IsError)
                return;

            var IsAdd = Setting.AddSetting(Model);
            DialogResult = IsAdd ? DialogResult.OK : DialogResult.No;
            Close();
        }
    }
}
