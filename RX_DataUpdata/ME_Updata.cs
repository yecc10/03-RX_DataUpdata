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
    public partial class ME_Updata : Form
    {
        public ME_Updata()
        {
            InitializeComponent();
            CTime.Text = DateTime.Now.ToString();
            timer.Enabled = true;
            UpdataData.Enabled = false; //默认更新按钮不可点击
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

        private void EndPoint_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("你已选定该焊点为该组实验最终焊接参数！");
        }

        private void ZaoJian_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("你已选定该焊点为造检点！");
        }

        /// <summary>
        /// 更新焊点参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdataData_Click(object sender, EventArgs e)
        {
            UpdataData.Enabled = false; //关闭上传点击功能
            AutoClearData.Enabled = true; //打开计时器
            var SysPid = NewExp.GetPid(SportBordID.Text, Pid.Text);
            DialogResult result = MessageBox.Show("是否确认更新" + SysPid.Pid + "焊点！", "更新确认-安徽瑞祥工业！", MessageBoxButtons.YesNo);
            if (result== System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    var Res = NewExp.UpdataExp(SysPid.Bid, SysPid.Pid, Convert.ToDouble(B1t.Text), Convert.ToDouble(b2t.Text), Convert.ToDouble(B3t.Text), B3m.Text.ToString(), Convert.ToDouble(PoleDim.Text), Convert.ToDouble(PressTime.Text), Convert.ToDouble(Weldele.Text), Convert.ToDouble(WeldTime.Text), Convert.ToDouble(KeepTime.Text), Convert.ToDouble(Pressure.Text), Convert.ToDouble(SportDim.Text), Convert.ToDouble(RongheDim.Text), Remark.Text.ToString(), ZaoJian.Checked, FirstPoint.Checked, EndPoint.Checked);
                    if (Res == 11)
                    {
                        Ustatus.Text = SysPid.Pid  + "更新成功！";
                    }
                    else if (Res == -99)
                    {
                        Ustatus.Text = SysPid.Pid  + "该焊点已存在未成功更新！";
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
            {
                MessageBox.Show("你已取消更新该焊点参数任务！");
            }
            
        }

        /// <summary>
        /// 读取焊点参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReadPointData_Click(object sender, EventArgs e)
        {
            if (SportBordID.Text.Length<4 ||Pid.Text.Length<1)
            {
                MessageBox.Show("焊点名称错误!请检查焊点名称！");
                return;
            }
            else
            {
               var SysPid= NewExp.GetPid(SportBordID.Text, Pid.Text);
                ReadPonit SP = new ReadPonit();
                SP=NewExp.ReadExp(SysPid.Pid);
                if (SP.Res==11)
                {
                    UpdataData.Enabled = true;
                    Ustatus.Text = SP.pid + "焊点已读取成功！";
                    B1t.Text =Convert.ToString(SP.b1t);
                    b2t.Text = Convert.ToString(SP.b2t);
                    B3t.Text = Convert.ToString(SP.b3t);
                    B3m.Text = Convert.ToString(SP.b3m);
                    PoleDim.Text = Convert.ToString(SP.poleDim);
                    PressTime.Text = Convert.ToString(SP.presstime);
                    Weldele.Text = Convert.ToString(SP.weldele);
                    WeldTime.Text = Convert.ToString(SP.weldtime);
                    KeepTime.Text = Convert.ToString(SP.keeptime);
                    Pressure.Text = Convert.ToString(SP.pressure);
                    SportDim.Text = Convert.ToString(SP.sportDim);
                    RongheDim.Text = Convert.ToString(SP.rongheDim);
                    Remark.Text = SP.remarks;
                    ZaoJian.Checked = SP.zaoJian;
                    FirstPoint.Checked = SP.fistPoint;
                    EndPoint.Checked = SP.endPoint;
                }
                else
                {
                    Ustatus.Text = "服务器未检索到"+SP.pid + "焊点！";
                }
            }
        }

        /// <summary>
        /// 每3S执行一次
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AutoClearData_Tick(object sender, EventArgs e)
        {
            //Ustatus.Text = "";
            AutoClearData.Enabled = false;
        }
    }
}