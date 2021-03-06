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
using System.Net;


namespace RX_DataUpdata
{
    public partial class ME_Updata : Form
    {
        /// <summary>
        /// 文件上传、更新、下载处理地址
        /// </summary>
        public ME_Updata()
        {
            InitializeComponent();
            CTime.Text = DateTime.Now.ToString();
            timer.Enabled = true;
            UpdataData.Enabled = false; //默认更新按钮不可点击
            UpdataFwPicture.Enabled = false;
            UpdataBwPicture.Enabled = false;
            UploadBoard.Enabled = false;
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
            if (QueXian.Checked && Remark.Text != string.Empty)
            {
                Remark.Text = Remark.Text + "、无其他明显缺陷。";
            }
            else if (QueXian.Checked && Remark.Text == string.Empty)
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
                MessageBox.Show("该焊点为该组实验最终焊接参数！");
                UploadBoard.Enabled = true;
            }
            else
            {
                UploadBoard.Enabled = false;
            }

        }

        private void ZaoJian_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("该焊点为造检点！");
        }

        /// <summary>
        /// 更新焊点参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdataData_Click(object sender, EventArgs e)
        {
            if (SysVar.Acc > 16 || SysVar.UserName == "yechaocheng")
            {
                UpdataData.Enabled = false; //关闭上传点击功能
                AutoClearData.Enabled = true; //打开计时器
                var SysPid = NewExp.GetPid(SportBordID.Text, Pid.Text);
                DialogResult result = MessageBox.Show("是否确认更新" + SysPid.Pid + "焊点！", "更新确认-安徽瑞祥工业！", MessageBoxButtons.YesNo);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        var Res = NewExp.UpdataExp(SysPid.Bid, SysPid.Pid, Convert.ToDouble(B1t.Text), Convert.ToDouble(b2t.Text), Convert.ToDouble(B3t.Text), B3m.Text.ToString(), Convert.ToDouble(PoleDim.Text), Convert.ToDouble(PressTime.Text), Convert.ToDouble(Weldele.Text), Convert.ToDouble(WeldTime.Text), Convert.ToDouble(KeepTime.Text), Convert.ToDouble(Pressure.Text), Convert.ToDouble(SportDim.Text), Convert.ToDouble(RongheDim.Text), Remark.Text.ToString(), ZaoJian.Checked, FirstPoint.Checked, EndPoint.Checked, Zhanfu.Checked, lieWen.Checked, FeiJian.Checked, Yaheng.Checked, Waiguan.Checked, AlongPonit.Checked, Jianxi.Checked, ShowFwPicture.ImageLocation, ShowBwPicture.ImageLocation);
                        if (Res == 11)
                        {
                            Ustatus.Text = SysPid.Pid + "更新成功！";
                            UpdataFwPicture.Enabled = true;
                            UpdataBwPicture.Enabled = true;
                            ShowFwPicture.ImageLocation = null;
                            ShowBwPicture.ImageLocation = null;
                            ShowFwPicture.Update();
                            ShowBwPicture.Update();
                            UFWprogressBar.Value = 0;
                            UBWprogressBar.Value = 0;
                        }
                        else if (Res == -99)
                        {
                            Ustatus.Text = SysPid.Pid + "该焊点已存在未成功更新！";
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
            else
            {
                MessageBox.Show("您无权打开该页面！该页面仅供铝电焊实验人员使用！");
                //this.Close();
                return;
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
                UpdataFwPicture.Enabled = true;
                UpdataBwPicture.Enabled = true;
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
                    Zhanfu.Checked = SP.Zhanfu;
                    lieWen.Checked = SP.lieWen;
                    FeiJian.Checked = SP.FeiJian;
                    Yaheng.Checked = SP.Yaheng;
                    Waiguan.Checked = SP.Waiguan;
                    AlongPonit.Checked = SP.AlongPonit;
                    Jianxi.Checked = SP.Jianxi;
                    ShowFwPicture.ImageLocation = SP.FwPicture;
                    ShowBwPicture.ImageLocation = SP.BwPicture;
                    ShowFwPicture.Update();
                    ShowBwPicture.Update();
                }
                else
                {
                    Ustatus.Text = "服务器未检索到"+SP.pid + "焊点！";
                    UpdataData.Enabled = false;
                    B1t.Text = string.Empty;
                    b2t.Text = string.Empty;
                    B3t.Text = string.Empty;
                    B3m.Text = string.Empty;
                    PoleDim.Text = string.Empty;
                    PressTime.Text = string.Empty;
                    Weldele.Text = string.Empty;
                    WeldTime.Text = string.Empty;
                    KeepTime.Text = string.Empty;
                    Pressure.Text = string.Empty;
                    SportDim.Text = string.Empty;
                    RongheDim.Text = string.Empty;
                    Remark.Text = string.Empty;
                    ZaoJian.Checked = false;
                    FirstPoint.Checked = false;
                    EndPoint.Checked = false;
                    Zhanfu.Checked = false;
                    lieWen.Checked = false;
                    FeiJian.Checked = false;
                    Yaheng.Checked = false;
                    Waiguan.Checked = false;
                    AlongPonit.Checked = false;
                    Jianxi.Checked = false;
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
            int Return=FOD.UpLoad(SysVar.DeUrl, OFile.FileName.ToString(), SysPid.Pid+"_Fw_Picture", out REloadRoute, null,UFWprogressBar);
            if (REloadRoute!=string.Empty)
            {
                ShowFwPicture.ImageLocation = "http://rx_yfb_yf079:8080" + REloadRoute;
                ShowFwPicture.Update();
            }
            if (REloadRoute != string.Empty)
            {

            }
            if (Return==1)
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

        private void DELETEUpdataFwPicture_Click(object sender, EventArgs e)
        {
            FileUploadAndDownLoad FOD = new FileUploadAndDownLoad();
            var SysPid = NewExp.GetPid(SportBordID.Text, Pid.Text);
            FOD.FileDelet(SysVar.DeUrl, SysPid.Pid,0);
            ShowFwPicture.ImageLocation = null;
            ShowFwPicture.Update();
            UpdataFwPicture.Enabled = true;
        }
        //删除完成事件处理程序
        private static void _webClient_UploadDataCompleted(object sender, UploadDataCompletedEventArgs e)
        {
            Console.WriteLine("Deleted...");
        }

        private void DELETEUpdataBwPicture_Click(object sender, EventArgs e)
        {
            FileUploadAndDownLoad FOD = new FileUploadAndDownLoad();
            var SysPid = NewExp.GetPid(SportBordID.Text, Pid.Text);
            FOD.FileDelet(SysVar.DeUrl, SysPid.Pid,1);
            ShowBwPicture.ImageLocation = null;
            ShowBwPicture.Update();
            UpdataBwPicture.Enabled = true;
        }

        private void UploadBoard_Click(object sender, EventArgs e)
        {
            var SysPid = NewExp.GetPid(SportBordID.Text, Pid.Text);
            BoardPictureUpload BPU = new BoardPictureUpload(SysPid.Bid);
            BPU.Text = SysPid.Bid + "_最终照片上传";
            BPU.Show();
        }

        private void ME_Updata_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ShowFwPicture.ImageLocation != null || ShowBwPicture.ImageLocation != null)
            {
                DialogResult DR = MessageBox.Show("当前正在关闭图片已上传到服务器，但未上传到数据库的情况，点“Y”,取消关闭返回当前页面上传，点“N”删除该页面在服务器中已上传的文件", "关闭警告-瑞祥工业研发部", MessageBoxButtons.YesNo);
                if (DR==DialogResult.Yes)
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