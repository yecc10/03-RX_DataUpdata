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
            if (SysVar.Acc > 16 || SysVar.UserName == "yechaocheng")
            {
                var SysPid = NewExp.GetPid(SportBordID.Text, Pid.Text);
                if (SysPid.Bid.Length > 4)
                {
                    try
                    {
                        var Ret = -2;
                        Ret = NewExp.AddExp(SysPid.Bid, SysPid.Pid, Convert.ToDouble(B1t.Text), Convert.ToDouble(b2t.Text), Convert.ToDouble(B3t.Text), B3m.Text.ToString(),
                            Convert.ToDouble(PoleDim.Text), Convert.ToDouble(PressTime.Text), Convert.ToDouble(Weldele.Text), Convert.ToDouble(WeldTime.Text),
                            Convert.ToDouble(KeepTime.Text), Convert.ToDouble(Pressure.Text), Convert.ToDouble(SportDim.Text), Convert.ToDouble(RongheDim.Text),
                            Remark.Text.ToString(), ZaoJian.Checked, FirstPoint.Checked, EndPoint.Checked, Zhanfu.Checked, lieWen.Checked, FeiJian.Checked, Yaheng.Checked, Waiguan.Checked, AlongPonit.Checked, Jianxi.Checked, Ret);

                        if (Ret == 11)
                        {
                            Ustatus.Text = SysPid.Bid + Pid.Text + "上传成功！";
                        }
                        else if (Ret == -99)
                        {
                            Ustatus.Text = SysPid.Bid + Pid.Text + "该焊点已存在未进行上传！";
                        }
                    }
                    catch (Exception)
                    {
                        Ustatus.Text = SysPid.Bid + Pid.Text + "上传失败！";
                        throw;
                    }
                    int NU = 0;
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
            else
            {
                MessageBox.Show("您无权打开该页面！该页面仅供铝电焊实验人员使用！");
                //this.Close();
                return;
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

        }

        private void lieWen_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FeiJian_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Yaheng_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Waiguan_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void FirstPoint_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void AlongPonit_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void Jianxi_CheckedChanged(object sender, EventArgs e)
        {

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
            ZaoJian.Checked = false;
            EndPoint.Checked = false;
            QueXian.Checked = false;
        }

        private void QueXian_CheckedChanged(object sender, EventArgs e)
        {
            if (QueXian.Checked && Remark.Text!=string.Empty)
            {
                Remark.Text = Remark.Text+ "、无其他明显缺陷。";
            }
            else if(QueXian.Checked && Remark.Text == string.Empty)
            {
                Remark.Text = "无其他明显缺陷。";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CTime.Text = DateTime.Now.ToString();
        }

        private void EndPoint_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("你已选定该焊点为该组实验最终焊接参数！");
        }

        private void ZaoJian_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("你已选定该焊点为造检点！");
        }

        private void OpenDialogForPoint_Click(object sender, EventArgs e)
        {
            ME_Updata MEU = new ME_Updata();
            MEU.ShowDialog();
        }
    }
}