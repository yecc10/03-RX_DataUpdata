using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Web;
using Microsoft.AspNet.Identity;
using System.Runtime.InteropServices;
using System.Net;
using Microsoft.Win32;

namespace RX_DataUpdata
{
    public partial class ULogin : Form
    {
        public ULogin()
        {
            InitializeComponent();
            UserName.Height = 50;
            Password.Height = 50;
            this.SavaPassword.Checked = true;
            try
            {
                if (RegOprate.IsRegeditExit("User") || RegOprate.IsRegeditExit("Password"))
                {
                    this.UserName.Text =RegOprate.GetRegValue("User");
                    this.Password.Text = RegOprate.GetRegValue("Password");
                }
            }
            catch (Exception)
            {

                //throw;
            }
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if(Password.Enabled==true)
            {
                MSDDataContext Cname = new MSDDataContext();
               
                try
                {
                    MSDDataContext SP = new MSDDataContext();
                    string RValue=null;
                    SP.CheckPassword(UserName.Text,ref RValue);  //通过存储过程读取其中指定参数
                    var Psh = new PasswordHasher();
                    var Str=Psh.VerifyHashedPassword(RValue, Password.Text);  // 使用PASSWORDHASH 数值进行对比
                    if (Convert.ToBoolean(Str))
                    {
                        label3.Text = "密码正确";
                        this.Close();
                        this.DialogResult=DialogResult.Yes;  //将窗体返回值返回调用程序
                        SysVar.UserName = UserName.Text;
                        SysVar.Pswd = Password.Text;
                        try //将当前用户名和密码写入注册表
                        {
                            if (RegOprate.IsRegeditExit("User") == false && RegOprate.IsRegeditExit("Password") == false)
                            {
                                RegOprate.WriteRegdit("User", UserName.Text);
                                bool SavePassword = this.SavaPassword.Checked;
                                string SaveData = string.Empty;
                                if (SavePassword)
                                {
                                    SaveData = Password.Text;
                                }
                                else
                                {
                                    SaveData = "";
                                }

                                RegOprate.WriteRegdit("Password",SaveData);
                            }
                            else
                            {
                                bool SavePassword = this.SavaPassword.Checked;
                                string SaveData = string.Empty;
                                if (SavePassword )
                                {
                                    SaveData = Password.Text;
                                }
                                else
                                {
                                    SaveData = "";
                                }

                                RegOprate.WriteRegdit("Password", SaveData);
                            }
                        }
                        catch (Exception)
                        {
                            label3.Text = "如果非首次登陆则说明数据写入错误！软件未得到权限进行保存用户名和密码操作";
                            throw;
                        }
                    }
                    else
                    {
                        label3.Text = "密码错误";
                        //this.DialogResult = DialogResult.No;  //将窗体返回值返回调用程序
                        Password.Text = "";
                    }
                }
                catch (Exception)
                {

                   throw;
                }
            }
            else
            {
                label3.Text = "密码长度小于6位，无法登录！！！";
                label3.BackColor =Color.Red;
            }
        }

        private void UserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void UserName_KeyPress(object sender, KeyEventArgs e)
        {
            MSDDataContext Cname = new MSDDataContext();
            if (UserName.Text != null && Password.Text != null)
            {
                int rvalue;
                try
                {
                    rvalue = Cname.CheckUserName(UserName.Text);
                    if (rvalue == 1)
                    {
                        Password.Enabled = true;
                        Login.Enabled = true;
                        label3.Text = "用户名正确，请继续输入密码！";
                        Password.BackColor = Color.White;
                        label3.BackColor = Color.Green;
                    }
                    else
                    {
                        Password.Enabled = false;
                        Login.Enabled = false;
                        label3.Text = "用户名错误，密码输入及登录已被禁用！";
                        label3.BackColor = Color.CadetBlue;
                        Password.BackColor = Color.BlanchedAlmond;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("数据库连接失败！请联系管理员打开数据库电脑！" + e);
                }

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegUser RS = new RegUser();
            RS.Show();
        }
    }
}
