namespace DockerManager
{
    partial class DockerManagerFm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgImageDetail = new System.Windows.Forms.DataGridView();
            this.ImageTag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TagImageId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnPush = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnRefesh = new System.Windows.Forms.Button();
            this.DgImage = new System.Windows.Forms.DataGridView();
            this.ImageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImageId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnSelectAll = new System.Windows.Forms.Button();
            this.CbServer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtUrl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtUserToken = new System.Windows.Forms.TextBox();
            this.BtnUpdateSetting = new System.Windows.Forms.Button();
            this.BtnServerAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnDeleteSetting = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtOwner = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtSshDeployPort = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtSshPort = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnDeleteSshSetting = new System.Windows.Forms.Button();
            this.CbSshServer = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnSshServerAdd = new System.Windows.Forms.Button();
            this.TxtSshIp = new System.Windows.Forms.TextBox();
            this.BtnUpdateSshSetting = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtSshPassword = new System.Windows.Forms.TextBox();
            this.TxtSshUserName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CbIsDeploy = new System.Windows.Forms.CheckBox();
            this.TxtSshDeploySslPort = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgImageDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgImageDetail
            // 
            this.DgImageDetail.AllowUserToAddRows = false;
            this.DgImageDetail.AllowUserToDeleteRows = false;
            this.DgImageDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgImageDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgImageDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImageTag,
            this.TagImageId,
            this.BtnPush,
            this.BtnDelete});
            this.DgImageDetail.Location = new System.Drawing.Point(12, 373);
            this.DgImageDetail.MultiSelect = false;
            this.DgImageDetail.Name = "DgImageDetail";
            this.DgImageDetail.ReadOnly = true;
            this.DgImageDetail.RowTemplate.Height = 25;
            this.DgImageDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DgImageDetail.Size = new System.Drawing.Size(494, 247);
            this.DgImageDetail.TabIndex = 0;
            // 
            // ImageTag
            // 
            this.ImageTag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ImageTag.DataPropertyName = "ImageTag";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ImageTag.DefaultCellStyle = dataGridViewCellStyle1;
            this.ImageTag.DividerWidth = 1;
            this.ImageTag.HeaderText = "ImageTag";
            this.ImageTag.Name = "ImageTag";
            this.ImageTag.ReadOnly = true;
            // 
            // TagImageId
            // 
            this.TagImageId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TagImageId.DataPropertyName = "TagImageId";
            this.TagImageId.HeaderText = "ImageId";
            this.TagImageId.Name = "TagImageId";
            this.TagImageId.ReadOnly = true;
            // 
            // BtnPush
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.NullValue = "Push";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.BtnPush.DefaultCellStyle = dataGridViewCellStyle2;
            this.BtnPush.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPush.HeaderText = "Push";
            this.BtnPush.Name = "BtnPush";
            this.BtnPush.ReadOnly = true;
            this.BtnPush.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BtnPush.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // BtnDelete
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.NullValue = "Delete";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.BtnDelete.DefaultCellStyle = dataGridViewCellStyle3;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.HeaderText = "Delete";
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.ReadOnly = true;
            this.BtnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BtnDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // BtnRefesh
            // 
            this.BtnRefesh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefesh.Location = new System.Drawing.Point(12, 21);
            this.BtnRefesh.Name = "BtnRefesh";
            this.BtnRefesh.Size = new System.Drawing.Size(75, 36);
            this.BtnRefesh.TabIndex = 2;
            this.BtnRefesh.Text = "Refresh";
            this.BtnRefesh.UseVisualStyleBackColor = true;
            this.BtnRefesh.Click += new System.EventHandler(this.BtnRefesh_Click);
            // 
            // DgImage
            // 
            this.DgImage.AllowUserToAddRows = false;
            this.DgImage.AllowUserToDeleteRows = false;
            this.DgImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgImage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgImage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImageName,
            this.CreateTime,
            this.ImageId});
            this.DgImage.Location = new System.Drawing.Point(12, 63);
            this.DgImage.MultiSelect = false;
            this.DgImage.Name = "DgImage";
            this.DgImage.ReadOnly = true;
            this.DgImage.RowTemplate.Height = 25;
            this.DgImage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DgImage.Size = new System.Drawing.Size(494, 247);
            this.DgImage.TabIndex = 3;
            // 
            // ImageName
            // 
            this.ImageName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ImageName.DataPropertyName = "ImageName";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ImageName.DefaultCellStyle = dataGridViewCellStyle4;
            this.ImageName.DividerWidth = 1;
            this.ImageName.HeaderText = "ImageName";
            this.ImageName.Name = "ImageName";
            this.ImageName.ReadOnly = true;
            // 
            // CreateTime
            // 
            this.CreateTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CreateTime.DataPropertyName = "CreateTime";
            this.CreateTime.DividerWidth = 1;
            this.CreateTime.FillWeight = 50F;
            this.CreateTime.HeaderText = "CreateTime";
            this.CreateTime.Name = "CreateTime";
            this.CreateTime.ReadOnly = true;
            // 
            // ImageId
            // 
            this.ImageId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ImageId.DataPropertyName = "ImageId";
            this.ImageId.FillWeight = 50F;
            this.ImageId.HeaderText = "ImageId";
            this.ImageId.Name = "ImageId";
            this.ImageId.ReadOnly = true;
            // 
            // BtnSelectAll
            // 
            this.BtnSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSelectAll.Location = new System.Drawing.Point(12, 331);
            this.BtnSelectAll.Name = "BtnSelectAll";
            this.BtnSelectAll.Size = new System.Drawing.Size(75, 36);
            this.BtnSelectAll.TabIndex = 4;
            this.BtnSelectAll.Text = "Select All";
            this.BtnSelectAll.UseVisualStyleBackColor = true;
            this.BtnSelectAll.Click += new System.EventHandler(this.BtnSelectAll_Click);
            // 
            // CbServer
            // 
            this.CbServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbServer.FormattingEnabled = true;
            this.CbServer.Location = new System.Drawing.Point(103, 9);
            this.CbServer.Name = "CbServer";
            this.CbServer.Size = new System.Drawing.Size(170, 23);
            this.CbServer.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Url";
            // 
            // TxtUrl
            // 
            this.TxtUrl.Location = new System.Drawing.Point(103, 46);
            this.TxtUrl.Name = "TxtUrl";
            this.TxtUrl.Size = new System.Drawing.Size(170, 23);
            this.TxtUrl.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "UserName";
            // 
            // TxtUserName
            // 
            this.TxtUserName.Location = new System.Drawing.Point(103, 120);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(170, 23);
            this.TxtUserName.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "UserToken";
            // 
            // TxtUserToken
            // 
            this.TxtUserToken.Location = new System.Drawing.Point(103, 157);
            this.TxtUserToken.Name = "TxtUserToken";
            this.TxtUserToken.Size = new System.Drawing.Size(170, 23);
            this.TxtUserToken.TabIndex = 11;
            // 
            // BtnUpdateSetting
            // 
            this.BtnUpdateSetting.Location = new System.Drawing.Point(107, 200);
            this.BtnUpdateSetting.Name = "BtnUpdateSetting";
            this.BtnUpdateSetting.Size = new System.Drawing.Size(75, 33);
            this.BtnUpdateSetting.TabIndex = 12;
            this.BtnUpdateSetting.Text = "Save";
            this.BtnUpdateSetting.UseVisualStyleBackColor = true;
            this.BtnUpdateSetting.Click += new System.EventHandler(this.BtnUpdateSetting_Click);
            // 
            // BtnServerAdd
            // 
            this.BtnServerAdd.Location = new System.Drawing.Point(16, 200);
            this.BtnServerAdd.Name = "BtnServerAdd";
            this.BtnServerAdd.Size = new System.Drawing.Size(75, 33);
            this.BtnServerAdd.TabIndex = 13;
            this.BtnServerAdd.Text = "Add";
            this.BtnServerAdd.UseVisualStyleBackColor = true;
            this.BtnServerAdd.Click += new System.EventHandler(this.BtnServerAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Server";
            // 
            // BtnDeleteSetting
            // 
            this.BtnDeleteSetting.Location = new System.Drawing.Point(198, 200);
            this.BtnDeleteSetting.Name = "BtnDeleteSetting";
            this.BtnDeleteSetting.Size = new System.Drawing.Size(75, 33);
            this.BtnDeleteSetting.TabIndex = 15;
            this.BtnDeleteSetting.Text = "Delete";
            this.BtnDeleteSetting.UseVisualStyleBackColor = true;
            this.BtnDeleteSetting.Click += new System.EventHandler(this.BtnDeleteSetting_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.TxtOwner);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.BtnDeleteSetting);
            this.panel1.Controls.Add(this.CbServer);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.BtnServerAdd);
            this.panel1.Controls.Add(this.TxtUrl);
            this.panel1.Controls.Add(this.BtnUpdateSetting);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TxtUserToken);
            this.panel1.Controls.Add(this.TxtUserName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(529, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 254);
            this.panel1.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 15);
            this.label11.TabIndex = 17;
            this.label11.Text = "Owner";
            // 
            // TxtOwner
            // 
            this.TxtOwner.Location = new System.Drawing.Point(103, 83);
            this.TxtOwner.Name = "TxtOwner";
            this.TxtOwner.Size = new System.Drawing.Size(170, 23);
            this.TxtOwner.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(711, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Register Server";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(734, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "SSH Server";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.TxtSshDeploySslPort);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.TxtSshDeployPort);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.TxtSshPort);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.BtnDeleteSshSetting);
            this.panel2.Controls.Add(this.CbSshServer);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.BtnSshServerAdd);
            this.panel2.Controls.Add(this.TxtSshIp);
            this.panel2.Controls.Add(this.BtnUpdateSshSetting);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.TxtSshPassword);
            this.panel2.Controls.Add(this.TxtSshUserName);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(529, 373);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(295, 254);
            this.panel2.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 117);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 15);
            this.label13.TabIndex = 18;
            this.label13.Text = "Deploy Port";
            // 
            // TxtSshDeployPort
            // 
            this.TxtSshDeployPort.Location = new System.Drawing.Point(103, 114);
            this.TxtSshDeployPort.Name = "TxtSshDeployPort";
            this.TxtSshDeployPort.Size = new System.Drawing.Size(79, 23);
            this.TxtSshDeployPort.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(53, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 15);
            this.label12.TabIndex = 16;
            this.label12.Text = "Port";
            // 
            // TxtSshPort
            // 
            this.TxtSshPort.Location = new System.Drawing.Point(103, 79);
            this.TxtSshPort.Name = "TxtSshPort";
            this.TxtSshPort.Size = new System.Drawing.Size(170, 23);
            this.TxtSshPort.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Server";
            // 
            // BtnDeleteSshSetting
            // 
            this.BtnDeleteSshSetting.Location = new System.Drawing.Point(198, 213);
            this.BtnDeleteSshSetting.Name = "BtnDeleteSshSetting";
            this.BtnDeleteSshSetting.Size = new System.Drawing.Size(75, 33);
            this.BtnDeleteSshSetting.TabIndex = 15;
            this.BtnDeleteSshSetting.Text = "Delete";
            this.BtnDeleteSshSetting.UseVisualStyleBackColor = true;
            this.BtnDeleteSshSetting.Click += new System.EventHandler(this.BtnDeleteSshSetting_Click);
            // 
            // CbSshServer
            // 
            this.CbSshServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbSshServer.FormattingEnabled = true;
            this.CbSshServer.Location = new System.Drawing.Point(103, 9);
            this.CbSshServer.Name = "CbSshServer";
            this.CbSshServer.Size = new System.Drawing.Size(170, 23);
            this.CbSshServer.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(65, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Ip";
            // 
            // BtnSshServerAdd
            // 
            this.BtnSshServerAdd.Location = new System.Drawing.Point(16, 213);
            this.BtnSshServerAdd.Name = "BtnSshServerAdd";
            this.BtnSshServerAdd.Size = new System.Drawing.Size(75, 33);
            this.BtnSshServerAdd.TabIndex = 13;
            this.BtnSshServerAdd.Text = "Add";
            this.BtnSshServerAdd.UseVisualStyleBackColor = true;
            this.BtnSshServerAdd.Click += new System.EventHandler(this.BtnSshServerAdd_Click);
            // 
            // TxtSshIp
            // 
            this.TxtSshIp.Location = new System.Drawing.Point(103, 44);
            this.TxtSshIp.Name = "TxtSshIp";
            this.TxtSshIp.Size = new System.Drawing.Size(170, 23);
            this.TxtSshIp.TabIndex = 7;
            // 
            // BtnUpdateSshSetting
            // 
            this.BtnUpdateSshSetting.Location = new System.Drawing.Point(107, 213);
            this.BtnUpdateSshSetting.Name = "BtnUpdateSshSetting";
            this.BtnUpdateSshSetting.Size = new System.Drawing.Size(75, 33);
            this.BtnUpdateSshSetting.TabIndex = 12;
            this.BtnUpdateSshSetting.Text = "Save";
            this.BtnUpdateSshSetting.UseVisualStyleBackColor = true;
            this.BtnUpdateSshSetting.Click += new System.EventHandler(this.BtnUpdateSshSetting_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "UserName";
            // 
            // TxtSshPassword
            // 
            this.TxtSshPassword.Location = new System.Drawing.Point(103, 184);
            this.TxtSshPassword.Name = "TxtSshPassword";
            this.TxtSshPassword.Size = new System.Drawing.Size(170, 23);
            this.TxtSshPassword.TabIndex = 11;
            // 
            // TxtSshUserName
            // 
            this.TxtSshUserName.Location = new System.Drawing.Point(103, 149);
            this.TxtSshUserName.Name = "TxtSshUserName";
            this.TxtSshUserName.Size = new System.Drawing.Size(170, 23);
            this.TxtSshUserName.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 187);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 15);
            this.label10.TabIndex = 10;
            this.label10.Text = "Password";
            // 
            // CbIsDeploy
            // 
            this.CbIsDeploy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CbIsDeploy.AutoSize = true;
            this.CbIsDeploy.Checked = true;
            this.CbIsDeploy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbIsDeploy.Location = new System.Drawing.Point(632, 348);
            this.CbIsDeploy.Name = "CbIsDeploy";
            this.CbIsDeploy.Size = new System.Drawing.Size(67, 19);
            this.CbIsDeploy.TabIndex = 19;
            this.CbIsDeploy.Text = "Deploy";
            this.CbIsDeploy.UseVisualStyleBackColor = true;
            // 
            // TxtSshDeploySslPort
            // 
            this.TxtSshDeploySslPort.Location = new System.Drawing.Point(194, 114);
            this.TxtSshDeploySslPort.Name = "TxtSshDeploySslPort";
            this.TxtSshDeploySslPort.Size = new System.Drawing.Size(79, 23);
            this.TxtSshDeploySslPort.TabIndex = 20;
            // 
            // DockerManagerFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 632);
            this.Controls.Add(this.CbIsDeploy);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnSelectAll);
            this.Controls.Add(this.DgImage);
            this.Controls.Add(this.BtnRefesh);
            this.Controls.Add(this.DgImageDetail);
            this.Name = "DockerManagerFm";
            this.Text = "DockerManager";
            this.Load += new System.EventHandler(this.DockerManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgImageDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView DgImageDetail;
        private Button BtnRefesh;
        private DataGridView DgImage;
        private Button BtnSelectAll;
        private ComboBox CbServer;
        private Label label2;
        private TextBox TxtUrl;
        private Label label3;
        private TextBox TxtUserName;
        private Label label4;
        private TextBox TxtUserToken;
        private Button BtnUpdateSetting;
        private Button BtnServerAdd;
        private Label label5;
        private Button BtnDeleteSetting;
        private Panel panel1;
        private Label label1;
        private Label label6;
        private Panel panel2;
        private Label label7;
        private Button BtnDeleteSshSetting;
        private ComboBox CbSshServer;
        private Label label8;
        private Button BtnSshServerAdd;
        private TextBox TxtSshIp;
        private Button BtnUpdateSshSetting;
        private Label label9;
        private TextBox TxtSshPassword;
        private TextBox TxtSshUserName;
        private Label label10;
        private Label label11;
        private TextBox TxtOwner;
        private Label label12;
        private TextBox TxtSshPort;
        private Label label13;
        private TextBox TxtSshDeployPort;
        private CheckBox CbIsDeploy;
        private DataGridViewTextBoxColumn ImageTag;
        private DataGridViewTextBoxColumn TagImageId;
        private DataGridViewButtonColumn BtnPush;
        private DataGridViewButtonColumn BtnDelete;
        private DataGridViewTextBoxColumn ImageName;
        private DataGridViewTextBoxColumn CreateTime;
        private DataGridViewTextBoxColumn ImageId;
        private TextBox TxtSshDeploySslPort;
    }
}