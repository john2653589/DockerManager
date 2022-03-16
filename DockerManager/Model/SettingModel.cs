using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DockerManager.Model
{
    public class SettingModel
    {
        public Guid SettingId { get; set; }
        public string ServerName { get; set; }
        public string Url { get; set; }
        public string Owner { get; set; }
        public string UserName { get; set; }
        public string UserToken { get; set; }
    }

    public class SshSettingModel
    {
        public Guid SshSettingId { get; set; }
        public string ServerName { get; set; }
        public string Ip { get; set; }
        public string Port { get; set; }
        public string DeployPort { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsDeploy { get; set; }
    }

}
