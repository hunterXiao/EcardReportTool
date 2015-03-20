using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace EcardReportTool
{
    public partial class LoginForm : Form
    {
        private WebControl wc;

        public LoginForm()
        {
            InitializeComponent();
            wc = WebControl.Instance();
        }

        private void quit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_Button_Click(object sender, EventArgs e)
        {
            string userName = this.textBoxUserName.Text;
            string passWord = this.textBoxPassWord.Text;
            string verifyCode = this.textBoxCaptcha.Text;

            if (wc.Login(userName,passWord,wc.VIEWSTATE,verifyCode))
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("用户名/密码或验证码错误，登陆失败！", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBoxUserName.Clear();
                this.textBoxPassWord.Clear();
                this.textBoxUserName.Focus();
            }

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            ReturnValue rv = wc.Get(@"http://ecard.efoxconn.com", "/");
            wc.GetViewState(rv);
            ReturnValue rv2 = wc.Get(@"http://ecard.efoxconn.com/verify.aspx", @"http://ecard.efoxconn.com");
            this.labelCaptchaImage.Image = Image.FromStream(rv2.RetStream);
            this.textBoxCaptcha.Text = WebControl.GetVerifyCode(rv2.RetStream);
            rv.RetStream.Dispose();
        }


        private void labelCaptchaImage_Click(object sender, EventArgs e)
        {
            ReturnValue rv = wc.Get(@"http://ecard.efoxconn.com/verify.aspx", "http://ecard.efoxconn.com");
            try
            {
                this.labelCaptchaImage.Image = Image.FromStream(rv.RetStream);
                this.textBoxCaptcha.Text = WebControl.GetVerifyCode(rv.RetStream);
                //rv.RetStream.Dispose();
            }
            catch (ArgumentException ex)
            {
                this.labelCaptchaImage.Image = Properties.Resources.redCross;
            }
        }

    }
}
