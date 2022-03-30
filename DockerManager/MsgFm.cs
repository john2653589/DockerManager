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
    public partial class MsgFm : Form
    {
        public MsgFm()
        {
            InitializeComponent();
        }

        public void SendMessage(string Message)
        {
            Invoke(() =>
            {
                Message = Message.Trim();
                MsgTxt.Text += $"{Message}\r\n";
                MsgTxt.SelectionStart = MsgTxt.Text.Length;
                MsgTxt.ScrollToCaret();
            });
        }

        public void ExitFm()
        {
            if (InvokeRequired)
            {
                Invoke(() =>
                {
                    Close();
                    Dispose();
                });
            }
            else
            {
                Close();
                Dispose();
            }
        }
    }
}