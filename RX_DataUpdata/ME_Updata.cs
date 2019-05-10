﻿using System;
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
            DialogResult result = MessageBox.Show("是否确认更新数据！", "更新确认-安徽瑞祥工业！", MessageBoxButtons.YesNo);
            if (result== System.Windows.Forms.DialogResult.Yes)
            {
                MSEDataContext mSEData = new MSEDataContext();
                try
                {
                    //mSEData.SerchExp(Pid.Text, ref b1t, ref b2t, ref b3t, ref b3m, ref PoleDim, ref presstime, ref weldele, ref weldtime, ref keeptime, ref pressure, ref sportDim, ref rongheDim, ref remarks);
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

        }
    }
}