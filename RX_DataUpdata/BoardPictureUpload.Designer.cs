namespace RX_DataUpdata
{
    partial class BoardPictureUpload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoardPictureUpload));
            this.UpdataBwPicture = new System.Windows.Forms.Button();
            this.UpdataFwPicture = new System.Windows.Forms.Button();
            this.BwPicture = new System.Windows.Forms.PictureBox();
            this.FwPicture = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Introduction = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Upload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BwPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FwPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdataBwPicture
            // 
            this.UpdataBwPicture.Location = new System.Drawing.Point(635, 23);
            this.UpdataBwPicture.Name = "UpdataBwPicture";
            this.UpdataBwPicture.Size = new System.Drawing.Size(75, 23);
            this.UpdataBwPicture.TabIndex = 24;
            this.UpdataBwPicture.Text = "上传反面照";
            this.UpdataBwPicture.UseVisualStyleBackColor = true;
            this.UpdataBwPicture.Click += new System.EventHandler(this.UpdataBwPicture_Click);
            // 
            // UpdataFwPicture
            // 
            this.UpdataFwPicture.Location = new System.Drawing.Point(89, 21);
            this.UpdataFwPicture.Name = "UpdataFwPicture";
            this.UpdataFwPicture.Size = new System.Drawing.Size(75, 23);
            this.UpdataFwPicture.TabIndex = 25;
            this.UpdataFwPicture.Text = "上传正面照";
            this.UpdataFwPicture.UseVisualStyleBackColor = true;
            this.UpdataFwPicture.Click += new System.EventHandler(this.UpdataFwPicture_Click);
            // 
            // BwPicture
            // 
            this.BwPicture.Location = new System.Drawing.Point(542, 46);
            this.BwPicture.Name = "BwPicture";
            this.BwPicture.Size = new System.Drawing.Size(500, 450);
            this.BwPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BwPicture.TabIndex = 22;
            this.BwPicture.TabStop = false;
            // 
            // FwPicture
            // 
            this.FwPicture.Location = new System.Drawing.Point(14, 46);
            this.FwPicture.Name = "FwPicture";
            this.FwPicture.Size = new System.Drawing.Size(500, 450);
            this.FwPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FwPicture.TabIndex = 23;
            this.FwPicture.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(558, 28);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 12);
            this.label17.TabIndex = 20;
            this.label17.Text = "焊点反面照:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 12);
            this.label16.TabIndex = 21;
            this.label16.Text = "焊点正面照:";
            // 
            // Introduction
            // 
            this.Introduction.Location = new System.Drawing.Point(14, 526);
            this.Introduction.Multiline = true;
            this.Introduction.Name = "Introduction";
            this.Introduction.Size = new System.Drawing.Size(1028, 230);
            this.Introduction.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 504);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 21;
            this.label1.Text = "实验说明:";
            // 
            // Upload
            // 
            this.Upload.Location = new System.Drawing.Point(920, 762);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(122, 48);
            this.Upload.TabIndex = 27;
            this.Upload.Text = "上传";
            this.Upload.UseVisualStyleBackColor = true;
            this.Upload.Click += new System.EventHandler(this.Upload_Click);
            // 
            // BoardPictureUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 814);
            this.Controls.Add(this.Upload);
            this.Controls.Add(this.Introduction);
            this.Controls.Add(this.UpdataBwPicture);
            this.Controls.Add(this.UpdataFwPicture);
            this.Controls.Add(this.BwPicture);
            this.Controls.Add(this.FwPicture);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label16);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BoardPictureUpload";
            this.Text = "照片上传";
            ((System.ComponentModel.ISupportInitialize)(this.BwPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FwPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpdataBwPicture;
        private System.Windows.Forms.Button UpdataFwPicture;
        private System.Windows.Forms.PictureBox BwPicture;
        private System.Windows.Forms.PictureBox FwPicture;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox Introduction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Upload;
    }
}