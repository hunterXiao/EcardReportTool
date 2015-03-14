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
        public LoginForm()
        {
            InitializeComponent();
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
            else {
                MessageBox.Show("Error", "ErrorTitle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBoxUserName.Clear();
                this.textBoxPassWord.Clear();
                this.textBoxUserName.Focus();
                }
            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            HttpWebRequest req = WebRequest.Create(@"http://ecard.efoxconn.com/verify.aspx") as HttpWebRequest;
            HttpWebResponse resp = req.GetResponse() as HttpWebResponse;
            if (resp != null)
            {
                using (Stream s = resp.GetResponseStream())
                {
                    this.labelCaptchaImage.Image = Image.FromStream(s);
                }
                //this.labelCaptchaImage.Image = Image.FromFile(@"C:\Users\Public\Pictures\Sample Pictures\Desert.jpg");
            }
            else
                MessageBox.Show("Error","error");
        }

        private void labelCaptchaImage_Click(object sender, EventArgs e)
        {

        }

    }
}
