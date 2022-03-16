namespace DockerManager
{
    partial class MsgFm
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
            this.MsgTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MsgTxt
            // 
            this.MsgTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MsgTxt.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MsgTxt.Location = new System.Drawing.Point(12, 12);
            this.MsgTxt.Multiline = true;
            this.MsgTxt.Name = "MsgTxt";
            this.MsgTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.MsgTxt.Size = new System.Drawing.Size(491, 313);
            this.MsgTxt.TabIndex = 0;
            // 
            // MsgFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 337);
            this.Controls.Add(this.MsgTxt);
            this.Name = "MsgFm";
            this.Text = "MsgFm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox MsgTxt;
    }
}