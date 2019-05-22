using System;
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

        }

        private void CreatData_Click(object sender, EventArgs e)
        {

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
    }
}
