namespace RX_DataUpdata
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.LoginTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.瑞祥实验数据中心 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.UpdataALdata = new System.Windows.Forms.Button();
            this.DataSerch = new System.Windows.Forms.Button();
            this.NewLvSport = new System.Windows.Forms.Button();
            this.经验库查询 = new System.Windows.Forms.TabPage();
            this.WBEXP = new System.Windows.Forms.WebBrowser();
            this.MainTabContent = new System.Windows.Forms.TabControl();
            this.CatiaHelp = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.DelmiaHelp = new System.Windows.Forms.TabPage();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.工具集 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PlantValue = new System.Windows.Forms.TextBox();
            this.CadValue = new System.Windows.Forms.TextBox();
            this.Oprate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sportDataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aLTDataBaseDataSet = new RX_DataUpdata.ALTDataBaseDataSet();
            this.UserName = new System.Windows.Forms.LinkLabel();
            this.CCCIP = new System.Windows.Forms.Label();
            this.CIP = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.SIP = new System.Windows.Forms.LinkLabel();
            this.rXYF_YECCDataSet = new RX_DataUpdata.RXYF_YECCDataSet();
            this.sportDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sportDataTableAdapter = new RX_DataUpdata.RXYF_YECCDataSetTableAdapters.SportDataTableAdapter();
            this.Utime = new System.Windows.Forms.Timer(this.components);
            this.sportDataTableAdapter1 = new RX_DataUpdata.ALTDataBaseDataSetTableAdapters.SportDataTableAdapter();
            this.瑞祥实验数据中心.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.经验库查询.SuspendLayout();
            this.MainTabContent.SuspendLayout();
            this.CatiaHelp.SuspendLayout();
            this.DelmiaHelp.SuspendLayout();
            this.工具集.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sportDataBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLTDataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rXYF_YECCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1215, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "用户名：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LoginTime
            // 
            this.LoginTime.AutoSize = true;
            this.LoginTime.Location = new System.Drawing.Point(1456, 12);
            this.LoginTime.Name = "LoginTime";
            this.LoginTime.Size = new System.Drawing.Size(65, 12);
            this.LoginTime.TabIndex = 5;
            this.LoginTime.Text = "XXXX-XX-XX";
            this.LoginTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1384, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "登录时间：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // 瑞祥实验数据中心
            // 
            this.瑞祥实验数据中心.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.瑞祥实验数据中心.Controls.Add(this.groupBox2);
            this.瑞祥实验数据中心.Location = new System.Drawing.Point(4, 22);
            this.瑞祥实验数据中心.Name = "瑞祥实验数据中心";
            this.瑞祥实验数据中心.Padding = new System.Windows.Forms.Padding(3);
            this.瑞祥实验数据中心.Size = new System.Drawing.Size(1552, 737);
            this.瑞祥实验数据中心.TabIndex = 2;
            this.瑞祥实验数据中心.Text = "瑞祥实验数据中心";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.UpdataALdata);
            this.groupBox2.Controls.Add(this.DataSerch);
            this.groupBox2.Controls.Add(this.NewLvSport);
            this.groupBox2.Location = new System.Drawing.Point(6, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 105);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "铝点焊分组";
            // 
            // UpdataALdata
            // 
            this.UpdataALdata.Location = new System.Drawing.Point(164, 29);
            this.UpdataALdata.Name = "UpdataALdata";
            this.UpdataALdata.Size = new System.Drawing.Size(142, 51);
            this.UpdataALdata.TabIndex = 2;
            this.UpdataALdata.Text = "铝点焊数据更新";
            this.UpdataALdata.UseVisualStyleBackColor = true;
            this.UpdataALdata.Click += new System.EventHandler(this.UpdataALdata_Click);
            // 
            // DataSerch
            // 
            this.DataSerch.Location = new System.Drawing.Point(322, 29);
            this.DataSerch.Name = "DataSerch";
            this.DataSerch.Size = new System.Drawing.Size(142, 51);
            this.DataSerch.TabIndex = 2;
            this.DataSerch.Text = "数据查询";
            this.DataSerch.UseVisualStyleBackColor = true;
            this.DataSerch.Click += new System.EventHandler(this.DataSerch_Click);
            // 
            // NewLvSport
            // 
            this.NewLvSport.Location = new System.Drawing.Point(6, 29);
            this.NewLvSport.Name = "NewLvSport";
            this.NewLvSport.Size = new System.Drawing.Size(142, 51);
            this.NewLvSport.TabIndex = 2;
            this.NewLvSport.Text = "铝点焊数据新增";
            this.NewLvSport.UseVisualStyleBackColor = true;
            this.NewLvSport.Click += new System.EventHandler(this.NewLvSport_Click);
            // 
            // 经验库查询
            // 
            this.经验库查询.Controls.Add(this.WBEXP);
            this.经验库查询.Location = new System.Drawing.Point(4, 22);
            this.经验库查询.Name = "经验库查询";
            this.经验库查询.Padding = new System.Windows.Forms.Padding(3);
            this.经验库查询.Size = new System.Drawing.Size(1552, 737);
            this.经验库查询.TabIndex = 0;
            this.经验库查询.Text = "经验库查询";
            this.经验库查询.UseVisualStyleBackColor = true;
            // 
            // WBEXP
            // 
            this.WBEXP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WBEXP.Location = new System.Drawing.Point(3, 3);
            this.WBEXP.MinimumSize = new System.Drawing.Size(20, 20);
            this.WBEXP.Name = "WBEXP";
            this.WBEXP.Size = new System.Drawing.Size(1546, 731);
            this.WBEXP.TabIndex = 0;
            this.WBEXP.Url = new System.Uri("http://10.147.203.251:8090/", System.UriKind.Absolute);
            // 
            // MainTabContent
            // 
            this.MainTabContent.Controls.Add(this.经验库查询);
            this.MainTabContent.Controls.Add(this.CatiaHelp);
            this.MainTabContent.Controls.Add(this.DelmiaHelp);
            this.MainTabContent.Controls.Add(this.瑞祥实验数据中心);
            this.MainTabContent.Controls.Add(this.工具集);
            this.MainTabContent.Location = new System.Drawing.Point(12, 12);
            this.MainTabContent.Name = "MainTabContent";
            this.MainTabContent.SelectedIndex = 0;
            this.MainTabContent.Size = new System.Drawing.Size(1560, 763);
            this.MainTabContent.TabIndex = 1;
            this.MainTabContent.Click += new System.EventHandler(this.MainTabContent_Click);
            // 
            // CatiaHelp
            // 
            this.CatiaHelp.Controls.Add(this.webBrowser1);
            this.CatiaHelp.Location = new System.Drawing.Point(4, 22);
            this.CatiaHelp.Name = "CatiaHelp";
            this.CatiaHelp.Size = new System.Drawing.Size(1552, 737);
            this.CatiaHelp.TabIndex = 4;
            this.CatiaHelp.Text = "CatiaHelp";
            this.CatiaHelp.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1552, 737);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // DelmiaHelp
            // 
            this.DelmiaHelp.Controls.Add(this.webBrowser2);
            this.DelmiaHelp.Location = new System.Drawing.Point(4, 22);
            this.DelmiaHelp.Name = "DelmiaHelp";
            this.DelmiaHelp.Size = new System.Drawing.Size(1552, 737);
            this.DelmiaHelp.TabIndex = 5;
            this.DelmiaHelp.Text = "DelmiaHelp";
            this.DelmiaHelp.UseVisualStyleBackColor = true;
            // 
            // webBrowser2
            // 
            this.webBrowser2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser2.Location = new System.Drawing.Point(0, 0);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(1552, 737);
            this.webBrowser2.TabIndex = 0;
            this.webBrowser2.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // 工具集
            // 
            this.工具集.Controls.Add(this.groupBox1);
            this.工具集.Location = new System.Drawing.Point(4, 22);
            this.工具集.Name = "工具集";
            this.工具集.Size = new System.Drawing.Size(1552, 737);
            this.工具集.TabIndex = 3;
            this.工具集.Text = "工具集";
            this.工具集.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PlantValue);
            this.groupBox1.Controls.Add(this.CadValue);
            this.groupBox1.Controls.Add(this.Oprate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 223);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "物流仿真坐标计算器";
            // 
            // PlantValue
            // 
            this.PlantValue.Location = new System.Drawing.Point(108, 125);
            this.PlantValue.Name = "PlantValue";
            this.PlantValue.ReadOnly = true;
            this.PlantValue.Size = new System.Drawing.Size(110, 21);
            this.PlantValue.TabIndex = 2;
            // 
            // CadValue
            // 
            this.CadValue.Location = new System.Drawing.Point(108, 83);
            this.CadValue.Name = "CadValue";
            this.CadValue.Size = new System.Drawing.Size(110, 21);
            this.CadValue.TabIndex = 2;
            // 
            // Oprate
            // 
            this.Oprate.Location = new System.Drawing.Point(118, 179);
            this.Oprate.Name = "Oprate";
            this.Oprate.Size = new System.Drawing.Size(75, 23);
            this.Oprate.TabIndex = 1;
            this.Oprate.Text = "计算";
            this.Oprate.UseVisualStyleBackColor = true;
            this.Oprate.Click += new System.EventHandler(this.Oprate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "Plant坐标值";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "CAD中距离值 mm";
            // 
            // sportDataBindingSource1
            // 
            this.sportDataBindingSource1.DataMember = "SportData";
            this.sportDataBindingSource1.DataSource = this.aLTDataBaseDataSet;
            // 
            // aLTDataBaseDataSet
            // 
            this.aLTDataBaseDataSet.DataSetName = "ALTDataBaseDataSet";
            this.aLTDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(1275, 12);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(29, 12);
            this.UserName.TabIndex = 6;
            this.UserName.TabStop = true;
            this.UserName.Text = "登录";
            // 
            // CCCIP
            // 
            this.CCCIP.AutoSize = true;
            this.CCCIP.Location = new System.Drawing.Point(801, 12);
            this.CCCIP.Name = "CCCIP";
            this.CCCIP.Size = new System.Drawing.Size(71, 12);
            this.CCCIP.TabIndex = 7;
            this.CCCIP.Text = "本机IP地址:";
            // 
            // CIP
            // 
            this.CIP.AutoSize = true;
            this.CIP.Location = new System.Drawing.Point(878, 12);
            this.CIP.Name = "CIP";
            this.CIP.Size = new System.Drawing.Size(95, 12);
            this.CIP.TabIndex = 8;
            this.CIP.TabStop = true;
            this.CIP.Text = "192.168.000.000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(997, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "服务器IP地址:";
            // 
            // SIP
            // 
            this.SIP.AutoSize = true;
            this.SIP.Location = new System.Drawing.Point(1074, 12);
            this.SIP.Name = "SIP";
            this.SIP.Size = new System.Drawing.Size(95, 12);
            this.SIP.TabIndex = 8;
            this.SIP.TabStop = true;
            this.SIP.Text = "192.168.000.000";
            // 
            // rXYF_YECCDataSet
            // 
            this.rXYF_YECCDataSet.DataSetName = "RXYF_YECCDataSet";
            this.rXYF_YECCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sportDataBindingSource
            // 
            this.sportDataBindingSource.DataMember = "SportData";
            this.sportDataBindingSource.DataSource = this.rXYF_YECCDataSet;
            // 
            // sportDataTableAdapter
            // 
            this.sportDataTableAdapter.ClearBeforeFill = true;
            // 
            // Utime
            // 
            this.Utime.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // sportDataTableAdapter1
            // 
            this.sportDataTableAdapter1.ClearBeforeFill = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.SIP);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.LoginTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CIP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CCCIP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainTabContent);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1600, 900);
            this.Name = "Main";
            this.Text = "瑞祥数据库主页";
            this.Load += new System.EventHandler(this.Main_Load);
            this.瑞祥实验数据中心.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.经验库查询.ResumeLayout(false);
            this.MainTabContent.ResumeLayout(false);
            this.CatiaHelp.ResumeLayout(false);
            this.DelmiaHelp.ResumeLayout(false);
            this.工具集.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sportDataBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLTDataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rXYF_YECCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LoginTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage 瑞祥实验数据中心;
        private System.Windows.Forms.TabPage 经验库查询;
        private System.Windows.Forms.WebBrowser WBEXP;
        private System.Windows.Forms.TabControl MainTabContent;
        private System.Windows.Forms.LinkLabel UserName;
        private System.Windows.Forms.Button DataSerch;
        private System.Windows.Forms.Button NewLvSport;
        private System.Windows.Forms.Label CCCIP;
        private System.Windows.Forms.LinkLabel CIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel SIP;
        private RXYF_YECCDataSet rXYF_YECCDataSet;
        private System.Windows.Forms.BindingSource sportDataBindingSource;
        private RXYF_YECCDataSetTableAdapters.SportDataTableAdapter sportDataTableAdapter;
        private System.Windows.Forms.Timer Utime;
        private ALTDataBaseDataSet aLTDataBaseDataSet;
        private System.Windows.Forms.BindingSource sportDataBindingSource1;
        private ALTDataBaseDataSetTableAdapters.SportDataTableAdapter sportDataTableAdapter1;
        private System.Windows.Forms.TabPage 工具集;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox PlantValue;
        private System.Windows.Forms.TextBox CadValue;
        private System.Windows.Forms.Button Oprate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage CatiaHelp;
        private System.Windows.Forms.TabPage DelmiaHelp;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.WebBrowser webBrowser2;
        private System.Windows.Forms.Button UpdataALdata;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}