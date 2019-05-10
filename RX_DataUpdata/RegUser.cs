using System;
using System.Windows.Forms;
using Microsoft.AspNet.Identity;

namespace RX_DataUpdata
{
    public partial class RegUser : Form
    {
        public RegUser()
        {
            InitializeComponent();
            //int Width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            //int heigh = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
            //this.webBrowser1.Size= new System.Drawing.Size(Width, heigh);
        }

        private void RegNewUser_Click(object sender, EventArgs e)
        {
            if (NUserPassword.Text != NUserPassword1.Text || NUserPassword.Text.Length<6)
            {
                MessageBox.Show("二次填写的密码不统一,或密码长度小于6位！");
                return;
            }
            if (NUserName.Text==string.Empty || Phone.Text == string.Empty || Email.Text == string.Empty||Keshi.Text == string.Empty || ACC.Text == string.Empty)
            {
                MessageBox.Show("当前信息未填写完成！");
                return;
            }
            var manager = new UserManager();
            var user = new ApplicationUser() { UserName = NUserName.Text, PhoneNumber = Phone.Text, Email = Email.Text, Keshi = Keshi.Text,QuanXian=ACC.Text };
            IdentityResult result = manager.Create(user, NUserPassword.Text);
            if (result.Succeeded)
            {
                MessageBox.Show("注册成功！用你最新的账户登录吧！");
                this.Close();
            }
            else
            {
                MessageBox.Show("注册失败！请联系管理员打开服务器电脑！");
                return;
            }

        }
    }
}