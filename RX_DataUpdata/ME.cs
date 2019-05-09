using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace RX_DataUpdata
{
    public partial class ME : Form
    {
        public ME()
        {
            InitializeComponent();
            CTime.Text = DateTime.Now.ToString();
            timer.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text=string.Empty;
            text = SportBordID.Text;
            if (text.Length<6)
            {
                int len = 6 - text.Length;
                switch (len)
                {
                    case 2:
                        {
                            string p = text.Substring(0, 3);
                            string p1 = text.Substring(3, 1);
                            string p2 = p + "00" + p1;
                            text = p2;
                            break;
                        }
                    case 1:
                        {
                            string p = text.Substring(0, 3);
                            string p1 = text.Substring(3, 2);
                            string p2 = p + "0" + p1;
                            text = p2;
                            break;
                        }
                }
            }
            string text2 = string.Empty;
            text2 = Pid.Text;
            if (text2.Length<2)
            {
                text2 = "0" + text2; //BID
                text2 = text + text2; //PID
            }
            else
            {
                text2 = text + text2;
            }
            if (text.Length>4)
            {
                try
                {
                    NewExp newData = new NewExp(text, text2, Convert.ToDouble(B1t.Text), Convert.ToDouble(b2t.Text), Convert.ToDouble(B3t.Text), B3m.Text.ToString(), Convert.ToDouble(PoleDim.Text), Convert.ToDouble(PressTime.Text), Convert.ToDouble(Weldele.Text), Convert.ToDouble(WeldTime.Text), Convert.ToDouble(KeepTime.Text), Convert.ToDouble(Pressure.Text), Convert.ToDouble(SportDim.Text), Convert.ToDouble(RongheDim.Text), Remark.Text.ToString());
                    Ustatus.Text = text+ Pid.Text + "上传成功！";
                }
                catch (Exception)
                {
                    Ustatus.Text = text+ Pid.Text + "上传失败！";
                    throw;
                }
                int NU=0;
                NU = Convert.ToUInt16(Pid.Text);
                NU += 1; 
                try
                {
                    Pid.Text = Convert.ToString(NU); 
                }
                catch (Exception)
                {

                    throw;
                }
            }
            
      }

        private void SerchData_Click(object sender, EventArgs e)
        {
            MSEDataContext mSEData = new MSEDataContext();
            string b3m, remarks;
            double b1t = 0, b2t = 0, b3t = 0, PoleDim = 0, presstime = 0, weldele = 0, weldtime = 0, keeptime = 0, pressure = 0, sportDim = 0, rongheDim = 0;
            try
            {
                //mSEData.SerchExp(Pid.Text, ref b1t, ref b2t, ref b3t, ref b3m, ref PoleDim, ref presstime, ref weldele, ref weldtime, ref keeptime, ref pressure, ref sportDim, ref rongheDim, ref remarks);
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// 修改板号时对应的焊点编号重置为1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SportBordID_TextChanged(object sender, EventArgs e)
        {
            this.Pid.Text ="1";
        }

        private void Zhanfu_CheckedChanged(object sender, EventArgs e)
        {
            SysVar.BackRemark = Remark.Text;
            if (Zhanfu.Checked)
            {
                Remark.Text = Remark.Text + "有粘附、";
            }
            else
            {
                Remark.Text = SysVar.BackRemark;
            }
        }

        private void lieWen_CheckedChanged(object sender, EventArgs e)
        {
            SysVar.BackRemark = Remark.Text;
            if (lieWen.Checked)
            {
                Remark.Text = Remark.Text + "有裂纹、";
            }
            else
            {
                Remark.Text = SysVar.BackRemark;
            }
        }

        private void FeiJian_CheckedChanged(object sender, EventArgs e)
        {
            SysVar.BackRemark = Remark.Text;
            if (FeiJian.Checked)
            {
                Remark.Text = Remark.Text + "有飞溅、";
            }
            else
            {
                Remark.Text = SysVar.BackRemark;
            }
        }

        private void Yaheng_CheckedChanged(object sender, EventArgs e)
        {
            SysVar.BackRemark = Remark.Text;
            if (Yaheng.Checked)
            {
                Remark.Text = Remark.Text + "有压痕、";
            }
            else
            {
                Remark.Text = SysVar.BackRemark;
            }
        }

        private void Waiguan_CheckedChanged(object sender, EventArgs e)
        {
            SysVar.BackRemark = Remark.Text;
            if (Waiguan.Checked)
            {
                Remark.Text = Remark.Text + "外观有瑕疵、";
            }
            else
            {
                Remark.Text = SysVar.BackRemark;
            }

        }

        private void FirstPoint_CheckedChanged(object sender, EventArgs e)
        {
            SysVar.BackRemark = Remark.Text;
            if (FirstPoint.Checked)
            {
                Remark.Text = "修磨后焊接第一点，" + Remark.Text;
            }
            else
            {
                Remark.Text = SysVar.BackRemark;
            }

        }

        private void AlongPonit_CheckedChanged(object sender, EventArgs e)
        {
            SysVar.BackRemark = Remark.Text;
            if (AlongPonit.Checked)
            {
                Remark.Text = "修磨后焊接点," + Remark.Text;
            }
            else
            {
                Remark.Text = SysVar.BackRemark;
            }

        }

        private void Jianxi_CheckedChanged(object sender, EventArgs e)
        {
            SysVar.BackRemark = Remark.Text;
            if (Jianxi.Checked)
            {
                Remark.Text = Remark.Text + "，焊接完成后，2层板存在0mm间隙。";
            }
            else
            {
                Remark.Text = SysVar.BackRemark;
            }
        }

        /// <summary>
        /// 清空备注
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            Remark.Text = string.Empty;
            Jianxi.Checked = false;
            AlongPonit.Checked = false;
            FirstPoint.Checked = false;
            Waiguan.Checked = false;
            Yaheng.Checked = false;
            FeiJian.Checked = false;
            lieWen.Checked = false;
            Zhanfu.Checked = false;
        }

        private void QueXian_CheckedChanged(object sender, EventArgs e)
        {
            SysVar.BackRemark = Remark.Text;
            if (Jianxi.Checked)
            {
                Remark.Text = Remark.Text + "无其他明显缺陷。";
            }
            else
            {
                Remark.Text = SysVar.BackRemark;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CTime.Text = DateTime.Now.ToString();
        }
    }
}