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
            var manager = new UserManager();
            var user = new ApplicationUser() { UserName = NUserName.Text, PhoneNumber = Phone.Text, Email = Email.Text, Keshi = Keshi.Text,QuanXian=ACC.Text };
            IdentityResult result = manager.Create(user, NUserPassword.Text);
            if (result.Succeeded)
            {
                MessageBox.Show("注册成功！用你最新的账户登录吧！");
                this.Close();
                //IdentityHelper.SignIn(manager, user, isPersistent: false);
                //IdentityHelper.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);

            }
            else
            {
                //ErrorMessage.Text = result.Errors.FirstOrDefault();
            }

        }
    }
}