using System;
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
        public DChart()
        {
            InitializeComponent();
            Bam.Text = Bam.Items[0].ToString();
            Bbm.Text = Bbm.Items[1].ToString();
            //Bcm.Text = Bcm.Items[0].ToString();
            Bat.Text = Bat.Items[0].ToString();
            Bbt.Text = Bbt.Items[1].ToString();
            //Bct.Text = Bct.Items[0].ToString();
        }

        private void DChart_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“rXYF_YECCDataSet.ExperienceView”中。您可以根据需要移动或删除它。
            this.experienceViewTableAdapter.Fill(this.rXYF_YECCDataSet.ExperienceView);
        }

        private void SerchData_Click(object sender, EventArgs e)
        {
            string SN="B2S11";
            string[] str;
            float[] str1, str2, str3, str4, str5, str6, str7;
            //SN = SportNum.Text.Substring(0, 4);
            SN = SportNum.Text;
            this.experienceViewTableAdapter.FillByBID(this.rXYF_YECCDataSet.ExperienceView, SN);
            rXYF_YECCDataSet.Tables["experienceView"].DefaultView.Sort="PID";
            dataGridView1.DataSource= rXYF_YECCDataSet.Tables["experienceView"].DefaultView;
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
            chart1.Series[0].Points.DataBindXY(str,str2);
            chart1.Series[1].Points.DataBindXY(str, str1);
            chart1.Series[2].Points.DataBindXY(str, str3);
            chart1.Series[3].Points.DataBindXY(str, str4);
            chart1.Series[4].Points.DataBindXY(str, str5);
            chart1.Series[5].Points.DataBindXY(str, str6);
            chart1.Series[6].Points.DataBindXY(str, str7);
        }

        private void DChart_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void TSerch_Click(object sender, EventArgs e)
        {

        }
    }
}
