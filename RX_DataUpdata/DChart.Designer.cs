namespace RX_DataUpdata
{
    partial class DChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DChart));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据更新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WBS = new System.Windows.Forms.WebBrowser();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BS = new System.Windows.Forms.BindingSource(this.components);
            this.rXYF_YECCDataSet = new RX_DataUpdata.RXYF_YECCDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.experienceViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.experienceViewTableAdapter = new RX_DataUpdata.RXYF_YECCDataSetTableAdapters.ExperienceViewTableAdapter();
            this.SerchData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SportNum = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OutExcel = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Bct = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Bcm = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Bbt = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Bat = new System.Windows.Forms.ComboBox();
            this.labela = new System.Windows.Forms.Label();
            this.Bbm = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Bam = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.RportFrame = new System.Windows.Forms.GroupBox();
            this.ShowDialogForImage = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rXYF_YECCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.experienceViewBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查询ToolStripMenuItem,
            this.数据维护ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1415, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 查询ToolStripMenuItem
            // 
            this.查询ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.数据查询ToolStripMenuItem,
            this.数据更新ToolStripMenuItem});
            this.查询ToolStripMenuItem.Name = "查询ToolStripMenuItem";
            this.查询ToolStripMenuItem.Size = new System.Drawing.Size(73, 21);
            this.查询ToolStripMenuItem.Text = "查询/更新";
            // 
            // 数据查询ToolStripMenuItem
            // 
            this.数据查询ToolStripMenuItem.Name = "数据查询ToolStripMenuItem";
            this.数据查询ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.数据查询ToolStripMenuItem.Text = "数据查询";
            // 
            // 数据更新ToolStripMenuItem
            // 
            this.数据更新ToolStripMenuItem.Name = "数据更新ToolStripMenuItem";
            this.数据更新ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.数据更新ToolStripMenuItem.Text = "数据更新";
            // 
            // 数据维护ToolStripMenuItem
            // 
            this.数据维护ToolStripMenuItem.Name = "数据维护ToolStripMenuItem";
            this.数据维护ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.数据维护ToolStripMenuItem.Text = "数据维护";
            // 
            // WBS
            // 
            this.WBS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WBS.Location = new System.Drawing.Point(0, 25);
            this.WBS.MinimumSize = new System.Drawing.Size(20, 20);
            this.WBS.Name = "WBS";
            this.WBS.Size = new System.Drawing.Size(1415, 741);
            this.WBS.TabIndex = 1;
            this.WBS.Url = new System.Uri("http://MChart.html", System.UriKind.Absolute);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 25);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series1.Legend = "Legend1";
            series1.Name = "熔核直径(mm)";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Lime;
            series2.Legend = "Legend1";
            series2.Name = "焊点直径(mm)";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            series3.Legend = "Legend1";
            series3.Name = "加压时间(ms)";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.Teal;
            series4.Legend = "Legend1";
            series4.Name = "焊接电流(KA)";
            series5.BorderWidth = 2;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            series5.Legend = "Legend1";
            series5.Name = "焊接时间(ms)";
            series6.BorderWidth = 2;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Color = System.Drawing.Color.Yellow;
            series6.Legend = "Legend1";
            series6.Name = "维持时间(ms)";
            series7.BorderWidth = 2;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Color = System.Drawing.Color.Purple;
            series7.Legend = "Legend1";
            series7.Name = "电极压力(kgf)";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Series.Add(series7);
            this.chart1.Size = new System.Drawing.Size(1006, 445);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // BS
            // 
            this.BS.DataSource = this.rXYF_YECCDataSet;
            this.BS.Position = 0;
            // 
            // rXYF_YECCDataSet
            // 
            this.rXYF_YECCDataSet.DataSetName = "RXYF_YECCDataSet";
            this.rXYF_YECCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 474);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1381, 291);
            this.dataGridView1.TabIndex = 3;
            // 
            // experienceViewBindingSource
            // 
            this.experienceViewBindingSource.DataMember = "ExperienceView";
            this.experienceViewBindingSource.DataSource = this.BS;
            // 
            // experienceViewTableAdapter
            // 
            this.experienceViewTableAdapter.ClearBeforeFill = true;
            // 
            // SerchData
            // 
            this.SerchData.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SerchData.Location = new System.Drawing.Point(1118, 426);
            this.SerchData.Name = "SerchData";
            this.SerchData.Size = new System.Drawing.Size(164, 42);
            this.SerchData.TabIndex = 4;
            this.SerchData.Text = "点击查询";
            this.SerchData.UseVisualStyleBackColor = true;
            this.SerchData.Click += new System.EventHandler(this.SerchData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "焊点所在板编号:";
            // 
            // SportNum
            // 
            this.SportNum.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SportNum.Location = new System.Drawing.Point(6, 67);
            this.SportNum.Name = "SportNum";
            this.SportNum.Size = new System.Drawing.Size(337, 31);
            this.SportNum.TabIndex = 6;
            this.SportNum.Text = "B2S001";
            this.SportNum.WordWrap = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.SportNum);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 122);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询输入";
            // 
            // OutExcel
            // 
            this.OutExcel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OutExcel.Location = new System.Drawing.Point(1012, 426);
            this.OutExcel.Name = "OutExcel";
            this.OutExcel.Size = new System.Drawing.Size(100, 44);
            this.OutExcel.TabIndex = 4;
            this.OutExcel.Text = "导出Excel";
            this.OutExcel.UseVisualStyleBackColor = true;
            this.OutExcel.Click += new System.EventHandler(this.OutExcel_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1012, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(369, 154);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Bct);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.Bcm);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.Bbt);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.Bat);
            this.tabPage1.Controls.Add(this.labela);
            this.tabPage1.Controls.Add(this.Bbm);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.Bam);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(361, 128);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "特征查询";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Bct
            // 
            this.Bct.FormattingEnabled = true;
            this.Bct.Items.AddRange(new object[] {
            "0.8",
            "1",
            "1.2",
            "1.5",
            "2",
            "2.5",
            "3"});
            this.Bct.Location = new System.Drawing.Point(234, 98);
            this.Bct.Name = "Bct";
            this.Bct.Size = new System.Drawing.Size(121, 20);
            this.Bct.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(181, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "版C厚度";
            // 
            // Bcm
            // 
            this.Bcm.FormattingEnabled = true;
            this.Bcm.Items.AddRange(new object[] {
            "6061",
            "5052"});
            this.Bcm.Location = new System.Drawing.Point(53, 98);
            this.Bcm.Name = "Bcm";
            this.Bcm.Size = new System.Drawing.Size(121, 20);
            this.Bcm.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "版C材料";
            // 
            // Bbt
            // 
            this.Bbt.FormattingEnabled = true;
            this.Bbt.Items.AddRange(new object[] {
            "0.8",
            "1",
            "1.2",
            "1.5",
            "2",
            "2.5",
            "3"});
            this.Bbt.Location = new System.Drawing.Point(234, 52);
            this.Bbt.Name = "Bbt";
            this.Bbt.Size = new System.Drawing.Size(121, 20);
            this.Bbt.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "版B厚度";
            // 
            // Bat
            // 
            this.Bat.FormattingEnabled = true;
            this.Bat.Items.AddRange(new object[] {
            "0.8",
            "1",
            "1.2",
            "1.5",
            "2",
            "2.5",
            "3"});
            this.Bat.Location = new System.Drawing.Point(234, 6);
            this.Bat.Name = "Bat";
            this.Bat.Size = new System.Drawing.Size(121, 20);
            this.Bat.TabIndex = 1;
            // 
            // labela
            // 
            this.labela.AutoSize = true;
            this.labela.Location = new System.Drawing.Point(181, 10);
            this.labela.Name = "labela";
            this.labela.Size = new System.Drawing.Size(47, 12);
            this.labela.TabIndex = 0;
            this.labela.Text = "版A厚度";
            // 
            // Bbm
            // 
            this.Bbm.FormattingEnabled = true;
            this.Bbm.Items.AddRange(new object[] {
            "6061",
            "5052"});
            this.Bbm.Location = new System.Drawing.Point(53, 51);
            this.Bbm.Name = "Bbm";
            this.Bbm.Size = new System.Drawing.Size(121, 20);
            this.Bbm.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "版B材料";
            // 
            // Bam
            // 
            this.Bam.FormattingEnabled = true;
            this.Bam.Items.AddRange(new object[] {
            "6061",
            "5052"});
            this.Bam.Location = new System.Drawing.Point(53, 6);
            this.Bam.Name = "Bam";
            this.Bam.Size = new System.Drawing.Size(121, 20);
            this.Bam.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "版A材料";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(361, 128);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "焊点ID查询";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // RportFrame
            // 
            this.RportFrame.Location = new System.Drawing.Point(1012, 185);
            this.RportFrame.Name = "RportFrame";
            this.RportFrame.Size = new System.Drawing.Size(369, 233);
            this.RportFrame.TabIndex = 10;
            this.RportFrame.TabStop = false;
            this.RportFrame.Text = "简要报告";
            // 
            // ShowDialogForImage
            // 
            this.ShowDialogForImage.Location = new System.Drawing.Point(1288, 424);
            this.ShowDialogForImage.Name = "ShowDialogForImage";
            this.ShowDialogForImage.Size = new System.Drawing.Size(93, 44);
            this.ShowDialogForImage.TabIndex = 11;
            this.ShowDialogForImage.Text = "浏览照片";
            this.ShowDialogForImage.UseVisualStyleBackColor = true;
            this.ShowDialogForImage.Click += new System.EventHandler(this.ShowDialogForImage_Click);
            // 
            // DChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 766);
            this.Controls.Add(this.ShowDialogForImage);
            this.Controls.Add(this.SerchData);
            this.Controls.Add(this.OutExcel);
            this.Controls.Add(this.RportFrame);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.WBS);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1431, 805);
            this.MinimumSize = new System.Drawing.Size(1431, 805);
            this.Name = "DChart";
            this.Text = "DChart";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DChart_FormClosed);
            this.Load += new System.EventHandler(this.DChart_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rXYF_YECCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.experienceViewBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据更新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据维护ToolStripMenuItem;
        private System.Windows.Forms.WebBrowser WBS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.BindingSource BS;
        private RXYF_YECCDataSet rXYF_YECCDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource experienceViewBindingSource;
        private RXYF_YECCDataSetTableAdapters.ExperienceViewTableAdapter experienceViewTableAdapter;
        private System.Windows.Forms.Button SerchData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SportNum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox Bct;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Bcm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Bbt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Bat;
        private System.Windows.Forms.Label labela;
        private System.Windows.Forms.ComboBox Bbm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Bam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OutExcel;
        private System.Windows.Forms.GroupBox RportFrame;
        private System.Windows.Forms.Button ShowDialogForImage;
    }
}