﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RX_DataUpdata
{
    public partial class BoardPictureUpload : Form
    {
        string BID = string.Empty;
        public BoardPictureUpload(string CBID)
        {
            InitializeComponent();
            if (CBID == string.Empty)
            {
                MessageBox.Show("无焊点BID传入,无权限上传照片及备注！-该页面已退出！");
                this.Close();
            }
            else
            {
                BID = CBID;
                BoardPictureAndRemark BPAR = new BoardPictureAndRemark();
                BPAR = ReadBoardPicture(BID);
                ShowFwPicture.ImageLocation = BPAR.FwPictured;
                ShowBwPicture.ImageLocation = BPAR.BwPicture;
                Introduction.Text = BPAR.ReMark;
                ShowFwPicture.Update();
                ShowBwPicture.Update();
            }
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
            int Return = FOD.UpLoad(SysVar.DeUrl , OFile.FileName.ToString(), BID + "_Fw_Picture", out REloadRoute, null, UFWprogressBar);
            if (REloadRoute != string.Empty)
            {
                ShowFwPicture.ImageLocation = SysVar.Server + REloadRoute;
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
            int Return = FOD.UpLoad(SysVar.DeUrl, OFile.FileName.ToString(), BID + "_Bw_Picture", out REloadRoute, null, UBWprogressBar);
            if (REloadRoute != string.Empty)
            {
                ShowBwPicture.ImageLocation = SysVar.Server + REloadRoute;
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

        private void Upload_Click(object sender, EventArgs e)
        {
            try
            {
              int RET=  NewExp.UpdataBoardPictureAndRemark(BID, ShowFwPicture.ImageLocation, ShowBwPicture.ImageLocation, Introduction.Text);
                if (RET==11)
                {
                    CreatData.Enabled = false;
                    MessageBox.Show("上传成功！");
                }
                else if (RET == -11)
                {
                    MessageBox.Show("数据不存在！，已停止上传");
                }
                else
                {
                    MessageBox.Show("更新发生错误！");
                }
            }

            catch (Exception)
            {

                MessageBox.Show("上传发生错误！未和数据库产生链接！");
            }


        }

        private void CreatData_Click(object sender, EventArgs e)
        {
            try
            {
                int RET = NewExp.CreatBoardPictureAndRemark(BID, ShowFwPicture.ImageLocation, ShowBwPicture.ImageLocation, Introduction.Text);
                if (RET == 11)
                {
                    CreatData.Enabled = false;
                    MessageBox.Show("上传成功！");
                }
                else if (RET == -11)
                {
                    MessageBox.Show("数据不存在！，已停止上传");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("上传发生错误！未和数据库产生链接！");
            }
        }

        private void DELETEUpdataFwPicture_Click(object sender, EventArgs e)
        {
            FileUploadAndDownLoad FOD = new FileUploadAndDownLoad();
            FOD.FileDelet(SysVar.DeUrl, BID, 0);
            ShowFwPicture.ImageLocation = null;
            ShowFwPicture.Update();
            UpdataFwPicture.Enabled = true;
            UFWprogressBar.Value = 0;
        }

        private void DELETEUpdataBwPicture_Click(object sender, EventArgs e)
        {
            FileUploadAndDownLoad FOD = new FileUploadAndDownLoad();
            FOD.FileDelet(SysVar.DeUrl, BID, 1);
            ShowBwPicture.ImageLocation = null;
            ShowBwPicture.Update();
            UpdataBwPicture.Enabled = true;
            UBWprogressBar.Value = 0;
        }

        private void ReadServerData_Click(object sender, EventArgs e)
        {
            BoardPictureAndRemark BPAR = new BoardPictureAndRemark();
            BPAR = ReadBoardPicture(BID);
            ShowFwPicture.ImageLocation= BPAR.FwPictured;
            ShowBwPicture.ImageLocation=BPAR.BwPicture;
            Introduction.Text= BPAR.ReMark;
            ShowFwPicture.Update();
            ShowBwPicture.Update();
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
                this.boardDataTableAdapter.FillBy(this.rxyF_YECCDataSet.BoardData, BID);
                DataRow DR;
                DR = rxyF_YECCDataSet.Tables["BoardData"].Rows[0];
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
