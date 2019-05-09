namespace RX_DataUpdata
{
    partial class ULogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ULogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SavaPassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 29);
            this.label1.MaximumSize = new System.Drawing.Size(50, 50);
            this.label1.MinimumSize = new System.Drawing.Size(50, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 97);
            this.label2.MinimumSize = new System.Drawing.Size(50, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码： ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserName
            // 
            this.UserName.Font = new System.Drawing.Font("新宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UserName.Location = new System.Drawing.Point(85, 29);
            this.UserName.MinimumSize = new System.Drawing.Size(400, 50);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(400, 47);
            this.UserName.TabIndex = 1;
            this.UserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserName_KeyPress);
            this.UserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserName_KeyPress);
            this.UserName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.UserName_KeyPress);
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Password.Font = new System.Drawing.Font("新宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Password.Location = new System.Drawing.Point(85, 97);
            this.Password.MinimumSize = new System.Drawing.Size(400, 50);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(400, 47);
            this.Password.TabIndex = 2;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(285, 174);
            this.Login.MinimumSize = new System.Drawing.Size(200, 50);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(200, 50);
            this.Login.TabIndex = 3;
            this.Login.Text = "登录";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 174);
            this.label3.MinimumSize = new System.Drawing.Size(250, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 50);
            this.label3.TabIndex = 4;
            this.label3.Text = "注:仅在用户名正确条件下才可输入密码。";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(12, 250);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(53, 12);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Tag = "";
            this.linkLabel1.Text = "点此注册";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // SavaPassword
            // 
            this.SavaPassword.AutoSize = true;
            this.SavaPassword.Location = new System.Drawing.Point(411, 245);
            this.SavaPassword.Name = "SavaPassword";
            this.SavaPassword.Size = new System.Drawing.Size(72, 16);
            this.SavaPassword.TabIndex = 6;
            this.SavaPassword.Text = "记住密码";
            this.SavaPassword.UseVisualStyleBackColor = true;
            // 
            // ULogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(511, 277);
            this.Controls.Add(this.SavaPassword);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ULogin";
            this.Text = "ULogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox SavaPassword;
    }
}