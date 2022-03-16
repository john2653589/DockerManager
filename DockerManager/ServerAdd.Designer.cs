namespace DockerManager
{
    partial class ServerAdd
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
            this.label5 = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.TxtUserToken = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtUrl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtServerName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "Server Name";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(91, 329);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 5;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // TxtUserToken
            // 
            this.TxtUserToken.Location = new System.Drawing.Point(43, 279);
            this.TxtUserToken.Name = "TxtUserToken";
            this.TxtUserToken.Size = new System.Drawing.Size(170, 23);
            this.TxtUserToken.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "UserToken";
            // 
            // TxtUserName
            // 
            this.TxtUserName.Location = new System.Drawing.Point(43, 209);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(170, 23);
            this.TxtUserName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "UserName";
            // 
            // TxtUrl
            // 
            this.TxtUrl.Location = new System.Drawing.Point(43, 139);
            this.TxtUrl.Name = "TxtUrl";
            this.TxtUrl.Size = new System.Drawing.Size(170, 23);
            this.TxtUrl.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Url";
            // 
            // TxtServerName
            // 
            this.TxtServerName.Location = new System.Drawing.Point(43, 69);
            this.TxtServerName.Name = "TxtServerName";
            this.TxtServerName.Size = new System.Drawing.Size(170, 23);
            this.TxtServerName.TabIndex = 1;
            // 
            // ServerAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 389);
            this.Controls.Add(this.TxtServerName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TxtUserToken);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtUrl);
            this.Controls.Add(this.label2);
            this.Name = "ServerAdd";
            this.Text = "ServerAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label5;
        private Button BtnAdd;
        private TextBox TxtUserToken;
        private Label label4;
        private TextBox TxtUserName;
        private Label label3;
        private TextBox TxtUrl;
        private Label label2;
        private TextBox TxtServerName;
    }
}