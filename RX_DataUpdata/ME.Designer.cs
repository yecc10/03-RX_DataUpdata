namespace RX_DataUpdata
{
    partial class ME
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ME));
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.InsertData = new System.Windows.Forms.Button();
            this.DA = new System.Windows.Forms.GroupBox();
            this.Remark = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Pressure = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.WeldTime = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.PressTime = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.B3m = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.b2t = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.RongheDim = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.SportDim = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.KeepTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Weldele = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PoleDim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.B3t = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.B1t = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SportBordID = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Pid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rxyF_YECCDataSet1 = new RX_DataUpdata.RXYF_YECCDataSet();
            this.Zhanfu = new System.Windows.Forms.CheckBox();
            this.lieWen = new System.Windows.Forms.CheckBox();
            this.FeiJian = new System.Windows.Forms.CheckBox();
            this.Yaheng = new System.Windows.Forms.CheckBox();
            this.Waiguan = new System.Windows.Forms.CheckBox();
            this.FirstPoint = new System.Windows.Forms.CheckBox();
            this.AlongPonit = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Ustatus = new System.Windows.Forms.Label();
            this.QueXian = new System.Windows.Forms.CheckBox();
            this.EndPoint = new System.Windows.Forms.CheckBox();
            this.ZaoJian = new System.Windows.Forms.CheckBox();
            this.Jianxi = new System.Windows.Forms.CheckBox();
            this.CTime = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.DA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rxyF_YECCDataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InsertData
            // 
            this.InsertData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InsertData.Location = new System.Drawing.Point(403, 583);
            this.InsertData.Name = "InsertData";
            this.InsertData.Size = new System.Drawing.Size(75, 30);
            this.InsertData.TabIndex = 0;
            this.InsertData.Text = "上传数据";
            this.InsertData.UseVisualStyleBackColor = false;
            this.InsertData.Click += new System.EventHandler(this.button1_Click);
            // 
            // DA
            // 
            this.DA.Controls.Add(this.Remark);
            this.DA.Controls.Add(this.label8);
            this.DA.Controls.Add(this.Pressure);
            this.DA.Controls.Add(this.label9);
            this.DA.Controls.Add(this.WeldTime);
            this.DA.Controls.Add(this.label10);
            this.DA.Controls.Add(this.PressTime);
            this.DA.Controls.Add(this.label11);
            this.DA.Controls.Add(this.B3m);
            this.DA.Controls.Add(this.label12);
            this.DA.Controls.Add(this.b2t);
            this.DA.Controls.Add(this.label13);
            this.DA.Controls.Add(this.RongheDim);
            this.DA.Controls.Add(this.label14);
            this.DA.Controls.Add(this.SportDim);
            this.DA.Controls.Add(this.label7);
            this.DA.Controls.Add(this.KeepTime);
            this.DA.Controls.Add(this.label6);
            this.DA.Controls.Add(this.Weldele);
            this.DA.Controls.Add(this.label5);
            this.DA.Controls.Add(this.PoleDim);
            this.DA.Controls.Add(this.label4);
            this.DA.Controls.Add(this.B3t);
            this.DA.Controls.Add(this.label3);
            this.DA.Controls.Add(this.B1t);
            this.DA.Controls.Add(this.label2);
            this.DA.Controls.Add(this.SportBordID);
            this.DA.Controls.Add(this.label15);
            this.DA.Controls.Add(this.Pid);
            this.DA.Controls.Add(this.label1);
            this.DA.Location = new System.Drawing.Point(12, 12);
            this.DA.Name = "DA";
            this.DA.Size = new System.Drawing.Size(466, 435);
            this.DA.TabIndex = 1;
            this.DA.TabStop = false;
            this.DA.Text = "数据登记";
            // 
            // Remark
            // 
            this.Remark.Location = new System.Drawing.Point(79, 302);
            this.Remark.Multiline = true;
            this.Remark.Name = "Remark";
            this.Remark.Size = new System.Drawing.Size(356, 119);
            this.Remark.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "备注";
            // 
            // Pressure
            // 
            this.Pressure.Location = new System.Drawing.Point(314, 216);
            this.Pressure.Name = "Pressure";
            this.Pressure.Size = new System.Drawing.Size(121, 21);
            this.Pressure.TabIndex = 10;
            this.Pressure.Text = "3.6";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(250, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 3;
            this.label9.Text = "电极压力";
            // 
            // WeldTime
            // 
            this.WeldTime.Location = new System.Drawing.Point(314, 175);
            this.WeldTime.Name = "WeldTime";
            this.WeldTime.Size = new System.Drawing.Size(121, 21);
            this.WeldTime.TabIndex = 11;
            this.WeldTime.Text = "60";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(250, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 4;
            this.label10.Text = "焊接时间";
            // 
            // PressTime
            // 
            this.PressTime.Location = new System.Drawing.Point(314, 136);
            this.PressTime.Name = "PressTime";
            this.PressTime.Size = new System.Drawing.Size(121, 21);
            this.PressTime.TabIndex = 12;
            this.PressTime.Text = "20";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(250, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 5;
            this.label11.Text = "加压时间";
            // 
            // B3m
            // 
            this.B3m.Location = new System.Drawing.Point(314, 97);
            this.B3m.Name = "B3m";
            this.B3m.Size = new System.Drawing.Size(121, 21);
            this.B3m.TabIndex = 13;
            this.B3m.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(250, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 6;
            this.label12.Text = "板三材料：";
            // 
            // b2t
            // 
            this.b2t.Location = new System.Drawing.Point(314, 61);
            this.b2t.Name = "b2t";
            this.b2t.Size = new System.Drawing.Size(121, 21);
            this.b2t.TabIndex = 14;
            this.b2t.Text = "0.8";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(232, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 12);
            this.label13.TabIndex = 7;
            this.label13.Text = "板二厚度[5]：";
            // 
            // RongheDim
            // 
            this.RongheDim.Location = new System.Drawing.Point(314, 258);
            this.RongheDim.Name = "RongheDim";
            this.RongheDim.Size = new System.Drawing.Size(121, 21);
            this.RongheDim.TabIndex = 15;
            this.RongheDim.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label14.Location = new System.Drawing.Point(250, 262);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 12);
            this.label14.TabIndex = 8;
            this.label14.Text = "熔核直径:";
            // 
            // SportDim
            // 
            this.SportDim.Location = new System.Drawing.Point(104, 258);
            this.SportDim.Name = "SportDim";
            this.SportDim.Size = new System.Drawing.Size(121, 21);
            this.SportDim.TabIndex = 1;
            this.SportDim.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(15, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "焊点直径";
            // 
            // KeepTime
            // 
            this.KeepTime.Location = new System.Drawing.Point(104, 216);
            this.KeepTime.Name = "KeepTime";
            this.KeepTime.Size = new System.Drawing.Size(121, 21);
            this.KeepTime.TabIndex = 1;
            this.KeepTime.Text = "20";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "维持时间";
            // 
            // Weldele
            // 
            this.Weldele.Location = new System.Drawing.Point(104, 175);
            this.Weldele.Name = "Weldele";
            this.Weldele.Size = new System.Drawing.Size(121, 21);
            this.Weldele.TabIndex = 1;
            this.Weldele.Text = "33";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "焊接电流";
            // 
            // PoleDim
            // 
            this.PoleDim.Location = new System.Drawing.Point(104, 136);
            this.PoleDim.Name = "PoleDim";
            this.PoleDim.Size = new System.Drawing.Size(121, 21);
            this.PoleDim.TabIndex = 1;
            this.PoleDim.Text = "25";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "电极端面直径：";
            // 
            // B3t
            // 
            this.B3t.Location = new System.Drawing.Point(104, 97);
            this.B3t.Name = "B3t";
            this.B3t.Size = new System.Drawing.Size(121, 21);
            this.B3t.TabIndex = 1;
            this.B3t.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "板三厚度：";
            // 
            // B1t
            // 
            this.B1t.Location = new System.Drawing.Point(104, 61);
            this.B1t.Name = "B1t";
            this.B1t.Size = new System.Drawing.Size(121, 21);
            this.B1t.TabIndex = 1;
            this.B1t.Text = "0.8";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "板一厚度[6]:";
            // 
            // SportBordID
            // 
            this.SportBordID.Location = new System.Drawing.Point(104, 26);
            this.SportBordID.Name = "SportBordID";
            this.SportBordID.Size = new System.Drawing.Size(121, 21);
            this.SportBordID.TabIndex = 1;
            this.SportBordID.Text = "B2S1";
            this.SportBordID.TextChanged += new System.EventHandler(this.SportBordID_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(250, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 12);
            this.label15.TabIndex = 0;
            this.label15.Text = "焊点序号:";
            // 
            // Pid
            // 
            this.Pid.Location = new System.Drawing.Point(314, 26);
            this.Pid.Name = "Pid";
            this.Pid.Size = new System.Drawing.Size(121, 21);
            this.Pid.TabIndex = 1;
            this.Pid.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "焊点板号:";
            // 
            // rxyF_YECCDataSet1
            // 
            this.rxyF_YECCDataSet1.DataSetName = "RXYF_YECCDataSet";
            this.rxyF_YECCDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Zhanfu
            // 
            this.Zhanfu.AutoSize = true;
            this.Zhanfu.Location = new System.Drawing.Point(17, 20);
            this.Zhanfu.Name = "Zhanfu";
            this.Zhanfu.Size = new System.Drawing.Size(60, 16);
            this.Zhanfu.TabIndex = 3;
            this.Zhanfu.Text = "有粘附";
            this.Zhanfu.UseVisualStyleBackColor = true;
            this.Zhanfu.CheckedChanged += new System.EventHandler(this.Zhanfu_CheckedChanged);
            // 
            // lieWen
            // 
            this.lieWen.AutoSize = true;
            this.lieWen.Location = new System.Drawing.Point(119, 20);
            this.lieWen.Name = "lieWen";
            this.lieWen.Size = new System.Drawing.Size(60, 16);
            this.lieWen.TabIndex = 3;
            this.lieWen.Text = "有裂纹";
            this.lieWen.UseVisualStyleBackColor = true;
            this.lieWen.CheckedChanged += new System.EventHandler(this.lieWen_CheckedChanged);
            // 
            // FeiJian
            // 
            this.FeiJian.AutoSize = true;
            this.FeiJian.Location = new System.Drawing.Point(201, 20);
            this.FeiJian.Name = "FeiJian";
            this.FeiJian.Size = new System.Drawing.Size(60, 16);
            this.FeiJian.TabIndex = 3;
            this.FeiJian.Text = "有飞溅";
            this.FeiJian.UseVisualStyleBackColor = true;
            this.FeiJian.CheckedChanged += new System.EventHandler(this.FeiJian_CheckedChanged);
            // 
            // Yaheng
            // 
            this.Yaheng.AutoSize = true;
            this.Yaheng.Location = new System.Drawing.Point(293, 20);
            this.Yaheng.Name = "Yaheng";
            this.Yaheng.Size = new System.Drawing.Size(60, 16);
            this.Yaheng.TabIndex = 3;
            this.Yaheng.Text = "有压痕";
            this.Yaheng.UseVisualStyleBackColor = true;
            this.Yaheng.CheckedChanged += new System.EventHandler(this.Yaheng_CheckedChanged);
            // 
            // Waiguan
            // 
            this.Waiguan.AutoSize = true;
            this.Waiguan.Location = new System.Drawing.Point(376, 20);
            this.Waiguan.Name = "Waiguan";
            this.Waiguan.Size = new System.Drawing.Size(84, 16);
            this.Waiguan.TabIndex = 3;
            this.Waiguan.Text = "外观有瑕疵";
            this.Waiguan.UseVisualStyleBackColor = true;
            this.Waiguan.CheckedChanged += new System.EventHandler(this.Waiguan_CheckedChanged);
            // 
            // FirstPoint
            // 
            this.FirstPoint.AutoSize = true;
            this.FirstPoint.Location = new System.Drawing.Point(17, 62);
            this.FirstPoint.Name = "FirstPoint";
            this.FirstPoint.Size = new System.Drawing.Size(96, 16);
            this.FirstPoint.TabIndex = 3;
            this.FirstPoint.Text = "修磨后第一点";
            this.FirstPoint.UseVisualStyleBackColor = true;
            this.FirstPoint.CheckedChanged += new System.EventHandler(this.FirstPoint_CheckedChanged);
            // 
            // AlongPonit
            // 
            this.AlongPonit.AutoSize = true;
            this.AlongPonit.Location = new System.Drawing.Point(119, 62);
            this.AlongPonit.Name = "AlongPonit";
            this.AlongPonit.Size = new System.Drawing.Size(72, 16);
            this.AlongPonit.TabIndex = 3;
            this.AlongPonit.Text = "连续焊点";
            this.AlongPonit.UseVisualStyleBackColor = true;
            this.AlongPonit.CheckedChanged += new System.EventHandler(this.AlongPonit_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Waiguan);
            this.groupBox1.Controls.Add(this.QueXian);
            this.groupBox1.Controls.Add(this.EndPoint);
            this.groupBox1.Controls.Add(this.ZaoJian);
            this.groupBox1.Controls.Add(this.Jianxi);
            this.groupBox1.Controls.Add(this.AlongPonit);
            this.groupBox1.Controls.Add(this.FirstPoint);
            this.groupBox1.Controls.Add(this.Zhanfu);
            this.groupBox1.Controls.Add(this.Yaheng);
            this.groupBox1.Controls.Add(this.lieWen);
            this.groupBox1.Controls.Add(this.FeiJian);
            this.groupBox1.Location = new System.Drawing.Point(12, 453);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 124);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "质量说明";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(334, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "清空备注";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Ustatus
            // 
            this.Ustatus.AutoSize = true;
            this.Ustatus.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Ustatus.Location = new System.Drawing.Point(209, 593);
            this.Ustatus.Name = "Ustatus";
            this.Ustatus.Size = new System.Drawing.Size(99, 20);
            this.Ustatus.TabIndex = 17;
            this.Ustatus.Text = "xxxxxxxxx";
            // 
            // QueXian
            // 
            this.QueXian.AutoSize = true;
            this.QueXian.Location = new System.Drawing.Point(201, 97);
            this.QueXian.Name = "QueXian";
            this.QueXian.Size = new System.Drawing.Size(108, 16);
            this.QueXian.TabIndex = 3;
            this.QueXian.Text = "无其他明显缺陷";
            this.QueXian.UseVisualStyleBackColor = true;
            this.QueXian.CheckedChanged += new System.EventHandler(this.QueXian_CheckedChanged);
            // 
            // EndPoint
            // 
            this.EndPoint.AutoSize = true;
            this.EndPoint.Location = new System.Drawing.Point(119, 97);
            this.EndPoint.Name = "EndPoint";
            this.EndPoint.Size = new System.Drawing.Size(72, 16);
            this.EndPoint.TabIndex = 3;
            this.EndPoint.Text = "最终认可";
            this.EndPoint.UseVisualStyleBackColor = true;
            this.EndPoint.CheckedChanged += new System.EventHandler(this.EndPoint_CheckedChanged);
            // 
            // ZaoJian
            // 
            this.ZaoJian.AutoSize = true;
            this.ZaoJian.Location = new System.Drawing.Point(17, 97);
            this.ZaoJian.Name = "ZaoJian";
            this.ZaoJian.Size = new System.Drawing.Size(60, 16);
            this.ZaoJian.TabIndex = 3;
            this.ZaoJian.Text = "凿检点";
            this.ZaoJian.UseVisualStyleBackColor = true;
            this.ZaoJian.CheckedChanged += new System.EventHandler(this.ZaoJian_CheckedChanged);
            // 
            // Jianxi
            // 
            this.Jianxi.AutoSize = true;
            this.Jianxi.Location = new System.Drawing.Point(201, 62);
            this.Jianxi.Name = "Jianxi";
            this.Jianxi.Size = new System.Drawing.Size(108, 16);
            this.Jianxi.TabIndex = 3;
            this.Jianxi.Text = "焊接完成有间隙";
            this.Jianxi.UseVisualStyleBackColor = true;
            this.Jianxi.CheckedChanged += new System.EventHandler(this.Jianxi_CheckedChanged);
            // 
            // CTime
            // 
            this.CTime.AutoSize = true;
            this.CTime.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CTime.Location = new System.Drawing.Point(26, 593);
            this.CTime.Name = "CTime";
            this.CTime.Size = new System.Drawing.Size(99, 20);
            this.CTime.TabIndex = 17;
            this.CTime.Text = "xxxxxxxxx";
            // 
            // timer
            // 
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(498, 625);
            this.Controls.Add(this.CTime);
            this.Controls.Add(this.Ustatus);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DA);
            this.Controls.Add(this.InsertData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(514, 664);
            this.MinimumSize = new System.Drawing.Size(514, 664);
            this.Name = "ME";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据登记";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.DA.ResumeLayout(false);
            this.DA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rxyF_YECCDataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button InsertData;
        private System.Windows.Forms.GroupBox DA;
        private System.Windows.Forms.TextBox Remark;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Pressure;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox WeldTime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox PressTime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox B3m;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox b2t;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox RongheDim;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox SportDim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox KeepTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Weldele;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PoleDim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox B3t;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox B1t;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Pid;
        private System.Windows.Forms.Label label1;
        private RXYF_YECCDataSet rxyF_YECCDataSet1;
        private System.Windows.Forms.TextBox SportBordID;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox Zhanfu;
        private System.Windows.Forms.CheckBox lieWen;
        private System.Windows.Forms.CheckBox FeiJian;
        private System.Windows.Forms.CheckBox Yaheng;
        private System.Windows.Forms.CheckBox Waiguan;
        private System.Windows.Forms.CheckBox FirstPoint;
        private System.Windows.Forms.CheckBox AlongPonit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox Jianxi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox QueXian;
        private System.Windows.Forms.Label Ustatus;
        private System.Windows.Forms.Label CTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.CheckBox EndPoint;
        private System.Windows.Forms.CheckBox ZaoJian;
    }
}

