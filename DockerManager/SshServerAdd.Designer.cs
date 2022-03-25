namespace DockerManager
{
    partial class SshServerAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtSshServerName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnSshAdd = new System.Windows.Forms.Button();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtIp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDeployPort = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CbIsDeploy = new System.Windows.Forms.CheckBox();
            this.TxtDeploySslPort = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtSshServerName
            // 
            this.TxtSshServerName.Location = new System.Drawing.Point(43, 39);
            this.TxtSshServerName.Name = "TxtSshServerName";
            this.TxtSshServerName.Size = new System.Drawing.Size(170, 23);
            this.TxtSshServerName.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 15);
            this.label5.TabIndex = 33;
            this.label5.Text = "Ssh Server Name";
            // 
            // BtnSshAdd
            // 
            this.BtnSshAdd.Location = new System.Drawing.Point(85, 384);
            this.BtnSshAdd.Name = "BtnSshAdd";
            this.BtnSshAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnSshAdd.TabIndex = 29;
            this.BtnSshAdd.Text = "Add";
            this.BtnSshAdd.UseVisualStyleBackColor = true;
            this.BtnSshAdd.Click += new System.EventHandler(this.BtnSshAdd_Click);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(43, 319);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(170, 23);
            this.TxtPassword.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 32;
            this.label4.Text = "Password";
            // 
            // TxtUserName
            // 
            this.TxtUserName.Location = new System.Drawing.Point(43, 263);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(170, 23);
            this.TxtUserName.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 31;
            this.label3.Text = "UserName";
            // 
            // TxtIp
            // 
            this.TxtIp.Location = new System.Drawing.Point(43, 95);
            this.TxtIp.Name = "TxtIp";
            this.TxtIp.Size = new System.Drawing.Size(170, 23);
            this.TxtIp.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 15);
            this.label2.TabIndex = 30;
            this.label2.Text = "Ip";
            // 
            // TxtPort
            // 
            this.TxtPort.Location = new System.Drawing.Point(43, 151);
            this.TxtPort.Name = "TxtPort";
            this.TxtPort.Size = new System.Drawing.Size(170, 23);
            this.TxtPort.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 35;
            this.label1.Text = "Port";
            // 
            // TxtDeployPort
            // 
            this.TxtDeployPort.Location = new System.Drawing.Point(43, 207);
            this.TxtDeployPort.Name = "TxtDeployPort";
            this.TxtDeployPort.Size = new System.Drawing.Size(74, 23);
            this.TxtDeployPort.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 15);
            this.label6.TabIndex = 37;
            this.label6.Text = "Deploy Port / SSL Port";
            // 
            // CbIsDeploy
            // 
            this.CbIsDeploy.AutoSize = true;
            this.CbIsDeploy.Location = new System.Drawing.Point(43, 353);
            this.CbIsDeploy.Name = "CbIsDeploy";
            this.CbIsDeploy.Size = new System.Drawing.Size(67, 19);
            this.CbIsDeploy.TabIndex = 38;
            this.CbIsDeploy.Text = "Deploy";
            this.CbIsDeploy.UseVisualStyleBackColor = true;
            // 
            // TxtDeploySslPort
            // 
            this.TxtDeploySslPort.Location = new System.Drawing.Point(137, 207);
            this.TxtDeploySslPort.Name = "TxtDeploySslPort";
            this.TxtDeploySslPort.Size = new System.Drawing.Size(76, 23);
            this.TxtDeploySslPort.TabIndex = 39;
            // 
            // SshServerAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 419);
            this.Controls.Add(this.TxtDeploySslPort);
            this.Controls.Add(this.CbIsDeploy);
            this.Controls.Add(this.TxtDeployPort);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtSshServerName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnSshAdd);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtIp);
            this.Controls.Add(this.label2);
            this.Name = "SshServerAdd";
            this.Text = "SshServerAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TxtSshServerName;
        private Label label5;
        private Button BtnSshAdd;
        private TextBox TxtPassword;
        private Label label4;
        private TextBox TxtUserName;
        private Label label3;
        private TextBox TxtIp;
        private Label label2;
        private TextBox TxtPort;
        private Label label1;
        private TextBox TxtDeployPort;
        private Label label6;
        private CheckBox CbIsDeploy;
        private TextBox TxtDeploySslPort;
    }
}