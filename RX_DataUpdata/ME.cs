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
using System.IO;

namespace RX_DataUpdata
{
    public partial class ME : Form
    {
        public ME()
        {
            InitializeComponent();
            CTime.Text = DateTime.Now.ToString();
            timer.Enabled = true;
            UploadBoard.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("你已选定该焊点包含图片，请确认是否已上传试板数据！！！", "更新确认-安徽瑞祥工业！", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
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
                                Remark.Text.ToString(), ZaoJian.Checked, FirstPoint.Checked, EndPoint.Checked, Zhanfu.Checked, lieWen.Checked, FeiJian.Checked, Yaheng.Checked, Waiguan.Checked, AlongPonit.Checked, Jianxi.Checked, ShowFwPicture.ImageLocation, ShowBwPicture.ImageLocation, Ret);

                            if (Ret == 11)
                            {
                                Ustatus.Text = SysPid.Bid + Pid.Text + "上传成功！";
                                UpdataFwPicture.Enabled = true;
                                UpdataBwPicture.Enabled = true;
                                ShowFwPicture.ImageLocation = null;
                                ShowBwPicture.ImageLocation = null;
                                ShowFwPicture.Update();
                                ShowBwPicture.Update();
                                UFWprogressBar.Value = 0;
                                UBWprogressBar.Value = 0;
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
            else
            {
                MessageBox.Show("您已取消上传！请先上传试板数据！");
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
            if (EndPoint.Checked)
            {
                UploadBoard.Enabled = true;
                UploadBoard.BackColor = System.Drawing.Color.Green;
                MessageBox.Show("你已选定该焊点为该组实验最终焊接参数！");
            }
            else
            {
                UploadBoard.Enabled = false;
                UploadBoard.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("你已取消该焊点为最终焊接参数！");
            }
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

        private void UpdataFwPicture_Click(object sender, EventArgs e)
        {
            UpdataFwPicture.Enabled = false;
            OpenFileDialog OFile = new OpenFileDialog();
            OFile.Filter = "焊点图片 | *.PNG;*.jpg";
            OFile.Title = "选择准备上传的焊点！";
            OFile.Multiselect = false;
            if (Directory.Exists("F:\\01 Person Lib\\05 瑞祥实验及演示项目\\01 铝焊点\\01 铝点焊实验资料"))
            {
                OFile.InitialDirectory = "F:\\01 Person Lib\\05 瑞祥实验及演示项目\\01 铝焊点\\01 铝点焊实验资料";
            }
            else
            {
                OFile.InitialDirectory = "C:\\Users\\Administrator\\Desktop";
            }
            OFile.ShowDialog();
            FileUploadAndDownLoad FOD = new FileUploadAndDownLoad();
            string REloadRoute = string.Empty;
            var SysPid = NewExp.GetPid(SportBordID.Text, Pid.Text);
            int Return = FOD.UpLoad(SysVar.DeUrl, OFile.FileName.ToString(), SysPid.Pid + "_Fw_Picture", out REloadRoute, null, UFWprogressBar);
            if (REloadRoute != string.Empty)
            {
                ShowFwPicture.ImageLocation = "http://rx_yfb_yf079:8080" + REloadRoute;
                ShowFwPicture.Update();
            }
            if (REloadRoute != string.Empty)
            {

            }
            if (Return == 1)
            {
            }
            else
            {
                MessageBox.Show("上传失败！");
            }

        }

        private void UpdataBwPicture_Click(object sender, EventArgs e)
        {
            UpdataBwPicture.Enabled = false;
            OpenFileDialog OFile = new OpenFileDialog();
            OFile.Filter = "焊点图片 | *.PNG;*.jpg";
            OFile.Title = "选择准备上传的焊点！";
            OFile.Multiselect = false;
            if (Directory.Exists("F:\\01 Person Lib\\05 瑞祥实验及演示项目\\01 铝焊点\\01 铝点焊实验资料"))
            {
                OFile.InitialDirectory = "F:\\01 Person Lib\\05 瑞祥实验及演示项目\\01 铝焊点\\01 铝点焊实验资料";
            }
            else
            {
                OFile.InitialDirectory = "C:\\Users\\Administrator\\Desktop";
            }
            OFile.ShowDialog();
            FileUploadAndDownLoad FOD = new FileUploadAndDownLoad();
            string REloadRoute = string.Empty;
            var SysPid = NewExp.GetPid(SportBordID.Text, Pid.Text);
            int Return = FOD.UpLoad(SysVar.DeUrl, OFile.FileName.ToString(), SysPid.Pid + "_Bw_Picture", out REloadRoute, null, UBWprogressBar);
            if (REloadRoute != string.Empty)
            {
                ShowBwPicture.ImageLocation = "http://rx_yfb_yf079:8080" + REloadRoute;
                ShowBwPicture.Update();
            }
            if (REloadRoute != string.Empty)
            {

            }
            if (Return == 1)
            {

            }
            else
            {
                MessageBox.Show("图片上传失败！");
            }

        }

        private void UploadBoard_Click(object sender, EventArgs e)
        {
            var SysPid = NewExp.GetPid(SportBordID.Text, Pid.Text);
            BoardPictureUpload BPU = new BoardPictureUpload(SysPid.Bid);
            BPU.Text = SysPid.Bid+"_最终照片上传";
            BPU.Show();
        }

        private void DELETEUpdataFwPicture_Click(object sender, EventArgs e)
        {
            var SysPid = NewExp.GetPid(SportBordID.Text, Pid.Text);
            FileUploadAndDownLoad FOD = new FileUploadAndDownLoad();
            FOD.FileDelet(SysVar.DeUrl, SysPid.Pid, 0);
            ShowFwPicture.ImageLocation = null;
            ShowFwPicture.Update();
            UpdataFwPicture.Enabled = true;
        }

        private void DELETEUpdataBwPicture_Click(object sender, EventArgs e)
        {
            FileUploadAndDownLoad FOD = new FileUploadAndDownLoad();
            var SysPid = NewExp.GetPid(SportBordID.Text, Pid.Text);
            FOD.FileDelet(SysVar.DeUrl, SysPid.Pid, 1);
            ShowBwPicture.ImageLocation = null;
            ShowBwPicture.Update();
            UpdataBwPicture.Enabled = true;
        }

        private void ME_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ShowFwPicture.ImageLocation != null || ShowBwPicture.ImageLocation != null)
            {
                DialogResult DR = MessageBox.Show("当前正在关闭图片已上传到服务器，但未上传到数据库的情况，点“Y”,取消关闭返回当前页面上传，点“N”删除该页面在服务器中已上传的文件", "关闭警告-瑞祥工业研发部", MessageBoxButtons.YesNo);
                if (DR == DialogResult.Yes)
                {
                    e.Cancel = true;
                }
                else
                {
                    DELETEUpdataFwPicture_Click(this, new EventArgs());
                    DELETEUpdataBwPicture_Click(this, new EventArgs());
                }
            }
        }
    }
}