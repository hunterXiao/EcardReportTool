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
            if (this.textBoxUserName.Text == "1")
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Error", "ErrorTitle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBoxUserName.Clear();
                this.textBoxPassWord.Clear();
                this.textBoxUserName.Focus();
            }

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            ReturnValue rv2 = wc.Get(@"http://www.zhihu.com", "");
            //ReturnValue rv2 = wc.Get(@"http://img2.xgo-img.com.cn/product/33_800x600/851/ceFyLbhB6R1aQ.jpg", "");
            WebControl.Retrieve(rv2.RetStream, "text.txt");
            //this.labelCaptchaImage.Image = Image.FromStream(rv2.RetStream);
            //this.labelCaptchaImage.Image.Save(@"verify.jpg");
        }


        private void labelCaptchaImage_Click(object sender, EventArgs e)
        {
            ReturnValue rv = wc.Get(@"http://ecard.efoxconn.com/verify.aspx", "http://ecard.efoxconn.com");
            try
            {
                this.labelCaptchaImage.Image = Image.FromStream(rv.RetStream);
            }
            catch (ArgumentException exception)
            {
                this.labelCaptchaImage.Image = Properties.Resources.redCross;
            }
        }

    }
}
