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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.TxtSshDeploySslPort = new System.Windows.Forms.TextBox();
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
            this.label14 = new System.Windows.Forms.Label();
            this.TxtTag = new System.Windows.Forms.TextBox();
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
            this.DgImageDetail.Location = new System.Drawing.Point(19, 510);
            this.DgImageDetail.Margin = new System.Windows.Forms.Padding(5);
            this.DgImageDetail.MultiSelect = false;
            this.DgImageDetail.Name = "DgImageDetail";
            this.DgImageDetail.ReadOnly = true;
            this.DgImageDetail.RowHeadersWidth = 62;
            this.DgImageDetail.RowTemplate.Height = 25;
            this.DgImageDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DgImageDetail.Size = new System.Drawing.Size(776, 379);
            this.DgImageDetail.TabIndex = 0;
            // 
            // ImageTag
            // 
            this.ImageTag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ImageTag.DataPropertyName = "ImageTag";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ImageTag.DefaultCellStyle = dataGridViewCellStyle5;
            this.ImageTag.DividerWidth = 1;
            this.ImageTag.HeaderText = "ImageTag";
            this.ImageTag.MinimumWidth = 8;
            this.ImageTag.Name = "ImageTag";
            this.ImageTag.ReadOnly = true;
            // 
            // TagImageId
            // 
            this.TagImageId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TagImageId.DataPropertyName = "TagImageId";
            this.TagImageId.HeaderText = "ImageId";
            this.TagImageId.MinimumWidth = 8;
            this.TagImageId.Name = "TagImageId";
            this.TagImageId.ReadOnly = true;
            // 
            // BtnPush
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.NullValue = "Push";
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.BtnPush.DefaultCellStyle = dataGridViewCellStyle6;
            this.BtnPush.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPush.HeaderText = "Push";
            this.BtnPush.MinimumWidth = 8;
            this.BtnPush.Name = "BtnPush";
            this.BtnPush.ReadOnly = true;
            this.BtnPush.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BtnPush.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.BtnPush.Width = 150;
            // 
            // BtnDelete
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.NullValue = "Delete";
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.BtnDelete.DefaultCellStyle = dataGridViewCellStyle7;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.HeaderText = "Delete";
            this.BtnDelete.MinimumWidth = 8;
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.ReadOnly = true;
            this.BtnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BtnDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.BtnDelete.Width = 150;
            // 
            // BtnRefesh
            // 
            this.BtnRefesh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefesh.Location = new System.Drawing.Point(19, 14);
            this.BtnRefesh.Margin = new System.Windows.Forms.Padding(5);
            this.BtnRefesh.Name = "BtnRefesh";
            this.BtnRefesh.Size = new System.Drawing.Size(118, 39);
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
            this.DgImage.Location = new System.Drawing.Point(19, 67);
            this.DgImage.Margin = new System.Windows.Forms.Padding(5);
            this.DgImage.MultiSelect = false;
            this.DgImage.Name = "DgImage";
            this.DgImage.ReadOnly = true;
            this.DgImage.RowHeadersWidth = 62;
            this.DgImage.RowTemplate.Height = 25;
            this.DgImage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DgImage.Size = new System.Drawing.Size(776, 379);
            this.DgImage.TabIndex = 3;
            // 
            // ImageName
            // 
            this.ImageName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ImageName.DataPropertyName = "ImageName";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ImageName.DefaultCellStyle = dataGridViewCellStyle8;
            this.ImageName.DividerWidth = 1;
            this.ImageName.HeaderText = "ImageName";
            this.ImageName.MinimumWidth = 8;
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
            this.CreateTime.MinimumWidth = 8;
            this.CreateTime.Name = "CreateTime";
            this.CreateTime.ReadOnly = true;
            // 
            // ImageId
            // 
            this.ImageId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ImageId.DataPropertyName = "ImageId";
            this.ImageId.FillWeight = 50F;
            this.ImageId.HeaderText = "ImageId";
            this.ImageId.MinimumWidth = 8;
            this.ImageId.Name = "ImageId";
            this.ImageId.ReadOnly = true;
            // 
            // CbServer
            // 
            this.CbServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbServer.FormattingEnabled = true;
            this.CbServer.Location = new System.Drawing.Point(162, 14);
            this.CbServer.Margin = new System.Windows.Forms.Padding(5);
            this.CbServer.Name = "CbServer";
            this.CbServer.Size = new System.Drawing.Size(265, 31);
            this.CbServer.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Url";
            // 
            // TxtUrl
            // 
            this.TxtUrl.Location = new System.Drawing.Point(162, 68);
            this.TxtUrl.Margin = new System.Windows.Forms.Padding(5);
            this.TxtUrl.Name = "TxtUrl";
            this.TxtUrl.Size = new System.Drawing.Size(265, 30);
            this.TxtUrl.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 230);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "UserName";
            // 
            // TxtUserName
            // 
            this.TxtUserName.Location = new System.Drawing.Point(162, 227);
            this.TxtUserName.Margin = new System.Windows.Forms.Padding(5);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(265, 30);
            this.TxtUserName.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 283);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "UserToken";
            // 
            // TxtUserToken
            // 
            this.TxtUserToken.Location = new System.Drawing.Point(162, 280);
            this.TxtUserToken.Margin = new System.Windows.Forms.Padding(5);
            this.TxtUserToken.Name = "TxtUserToken";
            this.TxtUserToken.Size = new System.Drawing.Size(265, 30);
            this.TxtUserToken.TabIndex = 11;
            // 
            // BtnUpdateSetting
            // 
            this.BtnUpdateSetting.Location = new System.Drawing.Point(168, 324);
            this.BtnUpdateSetting.Margin = new System.Windows.Forms.Padding(5);
            this.BtnUpdateSetting.Name = "BtnUpdateSetting";
            this.BtnUpdateSetting.Size = new System.Drawing.Size(118, 51);
            this.BtnUpdateSetting.TabIndex = 12;
            this.BtnUpdateSetting.Text = "Save";
            this.BtnUpdateSetting.UseVisualStyleBackColor = true;
            this.BtnUpdateSetting.Click += new System.EventHandler(this.BtnUpdateSetting_Click);
            // 
            // BtnServerAdd
            // 
            this.BtnServerAdd.Location = new System.Drawing.Point(25, 324);
            this.BtnServerAdd.Margin = new System.Windows.Forms.Padding(5);
            this.BtnServerAdd.Name = "BtnServerAdd";
            this.BtnServerAdd.Size = new System.Drawing.Size(118, 51);
            this.BtnServerAdd.TabIndex = 13;
            this.BtnServerAdd.Text = "Add";
            this.BtnServerAdd.UseVisualStyleBackColor = true;
            this.BtnServerAdd.Click += new System.EventHandler(this.BtnServerAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Server";
            // 
            // BtnDeleteSetting
            // 
            this.BtnDeleteSetting.Location = new System.Drawing.Point(311, 324);
            this.BtnDeleteSetting.Margin = new System.Windows.Forms.Padding(5);
            this.BtnDeleteSetting.Name = "BtnDeleteSetting";
            this.BtnDeleteSetting.Size = new System.Drawing.Size(118, 51);
            this.BtnDeleteSetting.TabIndex = 15;
            this.BtnDeleteSetting.Text = "Delete";
            this.BtnDeleteSetting.UseVisualStyleBackColor = true;
            this.BtnDeleteSetting.Click += new System.EventHandler(this.BtnDeleteSetting_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.TxtTag);
            this.panel1.Controls.Add(this.label14);
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
            this.panel1.Location = new System.Drawing.Point(831, 67);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 383);
            this.panel1.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(61, 177);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 23);
            this.label11.TabIndex = 17;
            this.label11.Text = "Owner";
            // 
            // TxtOwner
            // 
            this.TxtOwner.Location = new System.Drawing.Point(162, 174);
            this.TxtOwner.Margin = new System.Windows.Forms.Padding(5);
            this.TxtOwner.Name = "TxtOwner";
            this.TxtOwner.Size = new System.Drawing.Size(265, 30);
            this.TxtOwner.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(831, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Register Server";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(854, 471);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 23);
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
            this.panel2.Location = new System.Drawing.Point(831, 510);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(464, 389);
            this.panel2.TabIndex = 18;
            // 
            // TxtSshDeploySslPort
            // 
            this.TxtSshDeploySslPort.Location = new System.Drawing.Point(305, 175);
            this.TxtSshDeploySslPort.Margin = new System.Windows.Forms.Padding(5);
            this.TxtSshDeploySslPort.Name = "TxtSshDeploySslPort";
            this.TxtSshDeploySslPort.Size = new System.Drawing.Size(122, 30);
            this.TxtSshDeploySslPort.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 179);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 23);
            this.label13.TabIndex = 18;
            this.label13.Text = "Deploy Port";
            // 
            // TxtSshDeployPort
            // 
            this.TxtSshDeployPort.Location = new System.Drawing.Point(162, 175);
            this.TxtSshDeployPort.Margin = new System.Windows.Forms.Padding(5);
            this.TxtSshDeployPort.Name = "TxtSshDeployPort";
            this.TxtSshDeployPort.Size = new System.Drawing.Size(122, 30);
            this.TxtSshDeployPort.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(83, 126);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 23);
            this.label12.TabIndex = 16;
            this.label12.Text = "Port";
            // 
            // TxtSshPort
            // 
            this.TxtSshPort.Location = new System.Drawing.Point(162, 121);
            this.TxtSshPort.Margin = new System.Windows.Forms.Padding(5);
            this.TxtSshPort.Name = "TxtSshPort";
            this.TxtSshPort.Size = new System.Drawing.Size(265, 30);
            this.TxtSshPort.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 18);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "Server";
            // 
            // BtnDeleteSshSetting
            // 
            this.BtnDeleteSshSetting.Location = new System.Drawing.Point(311, 327);
            this.BtnDeleteSshSetting.Margin = new System.Windows.Forms.Padding(5);
            this.BtnDeleteSshSetting.Name = "BtnDeleteSshSetting";
            this.BtnDeleteSshSetting.Size = new System.Drawing.Size(118, 51);
            this.BtnDeleteSshSetting.TabIndex = 15;
            this.BtnDeleteSshSetting.Text = "Delete";
            this.BtnDeleteSshSetting.UseVisualStyleBackColor = true;
            this.BtnDeleteSshSetting.Click += new System.EventHandler(this.BtnDeleteSshSetting_Click);
            // 
            // CbSshServer
            // 
            this.CbSshServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbSshServer.FormattingEnabled = true;
            this.CbSshServer.Location = new System.Drawing.Point(162, 14);
            this.CbSshServer.Margin = new System.Windows.Forms.Padding(5);
            this.CbSshServer.Name = "CbSshServer";
            this.CbSshServer.Size = new System.Drawing.Size(265, 31);
            this.CbSshServer.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(102, 72);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 23);
            this.label8.TabIndex = 6;
            this.label8.Text = "Ip";
            // 
            // BtnSshServerAdd
            // 
            this.BtnSshServerAdd.Location = new System.Drawing.Point(25, 327);
            this.BtnSshServerAdd.Margin = new System.Windows.Forms.Padding(5);
            this.BtnSshServerAdd.Name = "BtnSshServerAdd";
            this.BtnSshServerAdd.Size = new System.Drawing.Size(118, 51);
            this.BtnSshServerAdd.TabIndex = 13;
            this.BtnSshServerAdd.Text = "Add";
            this.BtnSshServerAdd.UseVisualStyleBackColor = true;
            this.BtnSshServerAdd.Click += new System.EventHandler(this.BtnSshServerAdd_Click);
            // 
            // TxtSshIp
            // 
            this.TxtSshIp.Location = new System.Drawing.Point(162, 67);
            this.TxtSshIp.Margin = new System.Windows.Forms.Padding(5);
            this.TxtSshIp.Name = "TxtSshIp";
            this.TxtSshIp.Size = new System.Drawing.Size(265, 30);
            this.TxtSshIp.TabIndex = 7;
            // 
            // BtnUpdateSshSetting
            // 
            this.BtnUpdateSshSetting.Location = new System.Drawing.Point(168, 327);
            this.BtnUpdateSshSetting.Margin = new System.Windows.Forms.Padding(5);
            this.BtnUpdateSshSetting.Name = "BtnUpdateSshSetting";
            this.BtnUpdateSshSetting.Size = new System.Drawing.Size(118, 51);
            this.BtnUpdateSshSetting.TabIndex = 12;
            this.BtnUpdateSshSetting.Text = "Save";
            this.BtnUpdateSshSetting.UseVisualStyleBackColor = true;
            this.BtnUpdateSshSetting.Click += new System.EventHandler(this.BtnUpdateSshSetting_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 233);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 8;
            this.label9.Text = "UserName";
            // 
            // TxtSshPassword
            // 
            this.TxtSshPassword.Location = new System.Drawing.Point(162, 282);
            this.TxtSshPassword.Margin = new System.Windows.Forms.Padding(5);
            this.TxtSshPassword.Name = "TxtSshPassword";
            this.TxtSshPassword.Size = new System.Drawing.Size(265, 30);
            this.TxtSshPassword.TabIndex = 11;
            // 
            // TxtSshUserName
            // 
            this.TxtSshUserName.Location = new System.Drawing.Point(162, 228);
            this.TxtSshUserName.Margin = new System.Windows.Forms.Padding(5);
            this.TxtSshUserName.Name = "TxtSshUserName";
            this.TxtSshUserName.Size = new System.Drawing.Size(265, 30);
            this.TxtSshUserName.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 287);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 23);
            this.label10.TabIndex = 10;
            this.label10.Text = "Password";
            // 
            // CbIsDeploy
            // 
            this.CbIsDeploy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CbIsDeploy.AutoSize = true;
            this.CbIsDeploy.Checked = true;
            this.CbIsDeploy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbIsDeploy.Location = new System.Drawing.Point(993, 465);
            this.CbIsDeploy.Margin = new System.Windows.Forms.Padding(5);
            this.CbIsDeploy.Name = "CbIsDeploy";
            this.CbIsDeploy.Size = new System.Drawing.Size(96, 27);
            this.CbIsDeploy.TabIndex = 19;
            this.CbIsDeploy.Text = "Deploy";
            this.CbIsDeploy.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(83, 124);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 23);
            this.label14.TabIndex = 18;
            this.label14.Text = "Tag";
            // 
            // TxtTag
            // 
            this.TxtTag.Location = new System.Drawing.Point(162, 121);
            this.TxtTag.Margin = new System.Windows.Forms.Padding(5);
            this.TxtTag.Name = "TxtTag";
            this.TxtTag.Size = new System.Drawing.Size(265, 30);
            this.TxtTag.TabIndex = 19;
            // 
            // DockerManagerFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1314, 911);
            this.Controls.Add(this.CbIsDeploy);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DgImage);
            this.Controls.Add(this.BtnRefesh);
            this.Controls.Add(this.DgImageDetail);
            this.Margin = new System.Windows.Forms.Padding(5);
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
        private Label label14;
        private TextBox TxtTag;
    }
}