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
            this.ShowBwPicture = new System.Windows.Forms.PictureBox();
            this.ShowFwPicture = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Introduction = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdataContent = new System.Windows.Forms.Button();
            this.CreatData = new System.Windows.Forms.Button();
            this.DELETEUpdataBwPicture = new System.Windows.Forms.Button();
            this.DELETEUpdataFwPicture = new System.Windows.Forms.Button();
            this.UBWprogressBar = new System.Windows.Forms.ProgressBar();
            this.UFWprogressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.ShowBwPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowFwPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdataBwPicture
            // 
            this.UpdataBwPicture.Location = new System.Drawing.Point(635, 17);
            this.UpdataBwPicture.Name = "UpdataBwPicture";
            this.UpdataBwPicture.Size = new System.Drawing.Size(75, 23);
            this.UpdataBwPicture.TabIndex = 24;
            this.UpdataBwPicture.Text = "上传反面照";
            this.UpdataBwPicture.UseVisualStyleBackColor = true;
            this.UpdataBwPicture.Click += new System.EventHandler(this.UpdataBwPicture_Click);
            // 
            // UpdataFwPicture
            // 
            this.UpdataFwPicture.Location = new System.Drawing.Point(91, 17);
            this.UpdataFwPicture.Name = "UpdataFwPicture";
            this.UpdataFwPicture.Size = new System.Drawing.Size(75, 23);
            this.UpdataFwPicture.TabIndex = 25;
            this.UpdataFwPicture.Text = "上传正面照";
            this.UpdataFwPicture.UseVisualStyleBackColor = true;
            this.UpdataFwPicture.Click += new System.EventHandler(this.UpdataFwPicture_Click);
            // 
            // ShowBwPicture
            // 
            this.ShowBwPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ShowBwPicture.Location = new System.Drawing.Point(542, 46);
            this.ShowBwPicture.Name = "ShowBwPicture";
            this.ShowBwPicture.Size = new System.Drawing.Size(500, 450);
            this.ShowBwPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShowBwPicture.TabIndex = 22;
            this.ShowBwPicture.TabStop = false;
            // 
            // ShowFwPicture
            // 
            this.ShowFwPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ShowFwPicture.Location = new System.Drawing.Point(14, 46);
            this.ShowFwPicture.Name = "ShowFwPicture";
            this.ShowFwPicture.Size = new System.Drawing.Size(500, 450);
            this.ShowFwPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShowFwPicture.TabIndex = 23;
            this.ShowFwPicture.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(558, 22);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 12);
            this.label17.TabIndex = 20;
            this.label17.Text = "焊点反面照:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(14, 22);
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
            // UpdataContent
            // 
            this.UpdataContent.Location = new System.Drawing.Point(920, 762);
            this.UpdataContent.Name = "UpdataContent";
            this.UpdataContent.Size = new System.Drawing.Size(122, 48);
            this.UpdataContent.TabIndex = 27;
            this.UpdataContent.Text = "更新";
            this.UpdataContent.UseVisualStyleBackColor = true;
            this.UpdataContent.Click += new System.EventHandler(this.Upload_Click);
            // 
            // CreatData
            // 
            this.CreatData.Location = new System.Drawing.Point(792, 762);
            this.CreatData.Name = "CreatData";
            this.CreatData.Size = new System.Drawing.Size(122, 48);
            this.CreatData.TabIndex = 27;
            this.CreatData.Text = "上传";
            this.CreatData.UseVisualStyleBackColor = true;
            this.CreatData.Click += new System.EventHandler(this.CreatData_Click);
            // 
            // DELETEUpdataBwPicture
            // 
            this.DELETEUpdataBwPicture.Location = new System.Drawing.Point(716, 17);
            this.DELETEUpdataBwPicture.Name = "DELETEUpdataBwPicture";
            this.DELETEUpdataBwPicture.Size = new System.Drawing.Size(75, 23);
            this.DELETEUpdataBwPicture.TabIndex = 34;
            this.DELETEUpdataBwPicture.Text = "删除";
            this.DELETEUpdataBwPicture.UseVisualStyleBackColor = true;
            this.DELETEUpdataBwPicture.Click += new System.EventHandler(this.DELETEUpdataBwPicture_Click);
            // 
            // DELETEUpdataFwPicture
            // 
            this.DELETEUpdataFwPicture.Location = new System.Drawing.Point(172, 17);
            this.DELETEUpdataFwPicture.Name = "DELETEUpdataFwPicture";
            this.DELETEUpdataFwPicture.Size = new System.Drawing.Size(75, 23);
            this.DELETEUpdataFwPicture.TabIndex = 35;
            this.DELETEUpdataFwPicture.Text = "删除";
            this.DELETEUpdataFwPicture.UseVisualStyleBackColor = true;
            this.DELETEUpdataFwPicture.Click += new System.EventHandler(this.DELETEUpdataFwPicture_Click);
            // 
            // UBWprogressBar
            // 
            this.UBWprogressBar.Location = new System.Drawing.Point(797, 17);
            this.UBWprogressBar.Name = "UBWprogressBar";
            this.UBWprogressBar.Size = new System.Drawing.Size(245, 23);
            this.UBWprogressBar.TabIndex = 33;
            // 
            // UFWprogressBar
            // 
            this.UFWprogressBar.Location = new System.Drawing.Point(253, 17);
            this.UFWprogressBar.Name = "UFWprogressBar";
            this.UFWprogressBar.Size = new System.Drawing.Size(261, 23);
            this.UFWprogressBar.TabIndex = 32;
            // 
            // BoardPictureUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 814);
            this.Controls.Add(this.DELETEUpdataBwPicture);
            this.Controls.Add(this.DELETEUpdataFwPicture);
            this.Controls.Add(this.UBWprogressBar);
            this.Controls.Add(this.UFWprogressBar);
            this.Controls.Add(this.CreatData);
            this.Controls.Add(this.UpdataContent);
            this.Controls.Add(this.Introduction);
            this.Controls.Add(this.UpdataBwPicture);
            this.Controls.Add(this.UpdataFwPicture);
            this.Controls.Add(this.ShowBwPicture);
            this.Controls.Add(this.ShowFwPicture);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label16);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BoardPictureUpload";
            this.Text = "照片上传";
            ((System.ComponentModel.ISupportInitialize)(this.ShowBwPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowFwPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpdataBwPicture;
        private System.Windows.Forms.Button UpdataFwPicture;
        private System.Windows.Forms.PictureBox ShowBwPicture;
        private System.Windows.Forms.PictureBox ShowFwPicture;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox Introduction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UpdataContent;
        private System.Windows.Forms.Button CreatData;
        private System.Windows.Forms.Button DELETEUpdataBwPicture;
        private System.Windows.Forms.Button DELETEUpdataFwPicture;
        private System.Windows.Forms.ProgressBar UBWprogressBar;
        private System.Windows.Forms.ProgressBar UFWprogressBar;
    }
}