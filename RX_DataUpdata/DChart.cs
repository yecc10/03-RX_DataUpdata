﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RX_DataUpdata
{
    public partial class DChart : Form
    {
        string Bid = string.Empty, Pid = string.Empty;
        DataTable DT=null;
        public DChart()
        {
            InitializeComponent();
            Bam.Text = Bam.Items[0].ToString();
            //Bam.Enabled = false;
            //Bbm.Enabled = false;
            Bbm.Text = Bbm.Items[1].ToString();
            //Bcm.Text = Bcm.Items[0].ToString();
            Bat.Text = Bat.Items[3].ToString();
            Bbt.Text = Bbt.Items[3].ToString();
            //Bct.Text = Bct.Items[0].ToString();
        }

        private void DChart_Load(object sender, EventArgs e)
        {  
            // TODO: 这行代码将数据加载到表“rXYF_YECCDataSet.ExperienceView”中。您可以根据需要移动或删除它。
            this.experienceViewTableAdapter.Fill(this.rXYF_YECCDataSet.ExperienceView);
            this.BoardDataTableAdapter.Fill(this.rXYF_YECCDataSet.BoardData);
        }

        private void SerchData_Click(object sender, EventArgs e)
        {
            #region 数据操作
            string SN = "B2S11";
            string[] str;
            float[] str1, str2, str3, str4, str5, str6, str7;
            //SN = SportNum.Text.Substring(0, 4);
            if (SeachTabControl.SelectedTab.Name == "SeachTypeB")
            {
                SN = SportNum.Text;
                this.experienceViewTableAdapter.FillBy(this.rXYF_YECCDataSet.ExperienceView, SN);
            }
            else if (SeachTabControl.SelectedTab.Name == "SeachTypeA")
            {
                if (Bcm.Text != string.Empty && Bct.Text != string.Empty)
                {
                    this.experienceViewTableAdapter.FillByType(this.rXYF_YECCDataSet.ExperienceView, Convert.ToDouble(Bat.Text), Convert.ToDouble(Bbt.Text), Bcm.Text, Convert.ToDouble(Bct.Text));
                }
                else
                {
                    this.experienceViewTableAdapter.FillByTwoType(this.rXYF_YECCDataSet.ExperienceView, Convert.ToDouble(Bat.Text), Convert.ToDouble(Bbt.Text));
                }

            }
            rXYF_YECCDataSet.Tables["experienceView"].DefaultView.Sort = "PID";
            dataGridView1.DataSource = rXYF_YECCDataSet.Tables["experienceView"].DefaultView;
            DT=rXYF_YECCDataSet.Tables["experienceView"].DefaultView.ToTable();
            str = new string[dataGridView1.Rows.Count];
            str1 = new float[dataGridView1.Rows.Count];
            str2 = new float[dataGridView1.Rows.Count];
            str3 = new float[dataGridView1.Rows.Count];
            str4 = new float[dataGridView1.Rows.Count];
            str5 = new float[dataGridView1.Rows.Count];
            str6 = new float[dataGridView1.Rows.Count];
            str7 = new float[dataGridView1.Rows.Count];
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                str[i] = dataGridView1.Rows[i].Cells[2].Value.ToString();
                str1[i] = Convert.ToSingle(dataGridView1.Rows[i].Cells[14].Value.ToString());
                str2[i] = Convert.ToSingle(dataGridView1.Rows[i].Cells[15].Value.ToString());
                str3[i] = Convert.ToSingle(dataGridView1.Rows[i].Cells[9].Value.ToString());
                str4[i] = Convert.ToSingle(dataGridView1.Rows[i].Cells[10].Value.ToString());
                str5[i] = Convert.ToSingle(dataGridView1.Rows[i].Cells[11].Value.ToString());
                str6[i] = Convert.ToSingle(dataGridView1.Rows[i].Cells[12].Value.ToString());
                str7[i] = Convert.ToSingle(dataGridView1.Rows[i].Cells[13].Value.ToString());
            }
            chart1.Series[0].Points.DataBindXY(str, str2);
            chart1.Series[1].Points.DataBindXY(str, str1);
            chart1.Series[2].Points.DataBindXY(str, str3);
            chart1.Series[3].Points.DataBindXY(str, str4);
            chart1.Series[4].Points.DataBindXY(str, str5);
            chart1.Series[5].Points.DataBindXY(str, str6);
            chart1.Series[6].Points.DataBindXY(str, str7);

            if (dataGridView1.Rows.Count == 0)
            {
                SimRport.Text = "您查询的实验数据不存在！请等待或联系管理员上传！";
                OutExcel.Enabled = false;
            }
            else
            {
                SimRport.Text = "数据已为您显示完成！";
                OutExcel.Enabled = true;
            }
            #endregion
            #region 图片读取
            try
            {
                BoardPictureAndRemark BPAR = new BoardPictureAndRemark();
                BPAR = ReadBoardPicture(DT.Rows[DT.Rows.Count - 1][1].ToString());
                if (BPAR!=null)
                {
                    RpText.Text = BPAR.ReMark;
                }
                else
                {
                    RpText.Text = "未读取到该试板任何总结性报告！";
                }
            }
            catch (Exception)
            {

                RpText.Text = "未读取到该试板任何总结性报告！";
            }


            #endregion

        }

        private void DChart_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void TSerch_Click(object sender, EventArgs e)
        {

        }

        private void OutExcel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("当前输入无任何数据，无需导出XLS");
                return;
            }
            if (SeachTabControl.SelectedTab.Name == "SeachTypeA")
            {
                if (Bcm.Text != string.Empty && Bct.Text != string.Empty)
                {
                    var RE = RxDataOprator.ExcelOprator.SaveExcelForLvSport(dataGridView1, "板件6061厚_" + Bat.Text + "_板件5052厚_" + Bbt.Text + "_板件_" + Bcm.Text + "_厚_" + Bct.Text + "_组合参数");
                }
                else
                {
                    var RE = RxDataOprator.ExcelOprator.SaveExcelForLvSport(dataGridView1, "板件6061厚_" + Bat.Text + "_板件5052厚_" + Bbt.Text + "_组合参数");
                }

            }
            else if (SeachTabControl.SelectedTab.Name == "SeachTypeB")
            {
                var RE = RxDataOprator.ExcelOprator.SaveExcelForLvSport(dataGridView1, SportNum.Text);
            }


        }

        private void ShowDialogForImage_Click(object sender, EventArgs e)
        {
            DChartShowPointImage DC = new DChartShowPointImage(Bat.Text, Bbt.Text, Bct.Text, Bcm.Text, SeachTabControl.SelectedTab.Name);
            DC.Show();

        }
        #region 读取试板图片，每次仅返回一个试板正反照
        /// <summary>
        /// 读取试板图片，每次仅返回一个试板正反照
        /// </summary>
        /// <param name="BID">需要读取试板的BID</param>
        /// <returns>NULL为读取失败</returns>
        public BoardPictureAndRemark ReadBoardPicture(string BID)
        {
            try
            {
                this.BoardDataTableAdapter.FillBy(this.rXYF_YECCDataSet.BoardData, BID);
                DataRow DR;
                DR =rXYF_YECCDataSet.Tables["BoardData"].Rows[0];
                if (DR.Table.Rows.Count == 1)
                {
                    BoardPictureAndRemark BPAR = new BoardPictureAndRemark();
                    BPAR.FwPictured = Convert.ToString(DR["FwPicture"]);
                    BPAR.BwPicture = Convert.ToString(DR["BwPicture"]);
                    BPAR.ReMark = Convert.ToString(DR["ReMark"]);
                    return BPAR;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {

                return null;
            }
        }
        #endregion
    }
}
