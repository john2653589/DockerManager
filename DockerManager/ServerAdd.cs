using DockerManager.Model;
using Newtonsoft.Json;
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
    public partial class ServerAdd : Form
    {
        private SettingModel Model;
        private BindingSource Source;
        private SettingManager Setting;
        public ServerAdd(SettingManager _Setting)
        {
            InitializeComponent();
            Setting = _Setting;
            Model = new SettingModel();
            Source = new BindingSource
            {
                DataSource = Model
            };
            TxtServerName.DataBindings.Add("Text", Source, "ServerName");
            TxtUrl.DataBindings.Add("Text", Source, "Url");
            TxtUserName.DataBindings.Add("Text", Source, "UserName");
            TxtUserToken.DataBindings.Add("Text", Source, "UserToken");
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            static bool ErrorAlert(string Column)
            {
                MessageBox.Show($"{Column} 未填寫");
                return true;
            }

            var IsError = false;
            if (string.IsNullOrWhiteSpace(Model.ServerName))
                IsError = IsError || ErrorAlert("Server Name");

            if (string.IsNullOrWhiteSpace(Model.Url))
                IsError = IsError || ErrorAlert("Url");

            if (IsError)
                return;

            var IsAdd = Setting.AddSetting(Model);
            DialogResult = IsAdd ? DialogResult.OK : DialogResult.No;
            Close();
        }
    }
}
