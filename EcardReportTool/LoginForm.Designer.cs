namespace EcardReportTool
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.PassWordLabel = new System.Windows.Forms.Label();
            this.CaptchaLabel = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxPassWord = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.quit_Button = new System.Windows.Forms.Button();
            this.login_Button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelCaptchaImage = new System.Windows.Forms.Label();
            this.textBoxCaptcha = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.UserNameLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.PassWordLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.CaptchaLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxUserName, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPassWord, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 2, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(384, 262);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UserNameLabel.Location = new System.Drawing.Point(76, 51);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(74, 21);
            this.UserNameLabel.TabIndex = 0;
            this.UserNameLabel.Text = "用户名：";
            // 
            // PassWordLabel
            // 
            this.PassWordLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PassWordLabel.AutoSize = true;
            this.PassWordLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PassWordLabel.Location = new System.Drawing.Point(92, 92);
            this.PassWordLabel.Name = "PassWordLabel";
            this.PassWordLabel.Size = new System.Drawing.Size(58, 21);
            this.PassWordLabel.TabIndex = 1;
            this.PassWordLabel.Text = "密码：";
            // 
            // CaptchaLabel
            // 
            this.CaptchaLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CaptchaLabel.AutoSize = true;
            this.CaptchaLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CaptchaLabel.Location = new System.Drawing.Point(76, 133);
            this.CaptchaLabel.Name = "CaptchaLabel";
            this.CaptchaLabel.Size = new System.Drawing.Size(74, 21);
            this.CaptchaLabel.TabIndex = 2;
            this.CaptchaLabel.Text = "验证码：";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxUserName.Location = new System.Drawing.Point(156, 50);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(136, 22);
            this.textBoxUserName.TabIndex = 3;
            // 
            // textBoxPassWord
            // 
            this.textBoxPassWord.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxPassWord.Location = new System.Drawing.Point(156, 91);
            this.textBoxPassWord.Name = "textBoxPassWord";
            this.textBoxPassWord.PasswordChar = '*';
            this.textBoxPassWord.Size = new System.Drawing.Size(136, 22);
            this.textBoxPassWord.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.quit_Button);
            this.panel1.Controls.Add(this.login_Button);
            this.panel1.Location = new System.Drawing.Point(41, 167);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(301, 35);
            this.panel1.TabIndex = 6;
            // 
            // quit_Button
            // 
            this.quit_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.quit_Button.Location = new System.Drawing.Point(176, 9);
            this.quit_Button.Name = "quit_Button";
            this.quit_Button.Padding = new System.Windows.Forms.Padding(1);
            this.quit_Button.Size = new System.Drawing.Size(75, 23);
            this.quit_Button.TabIndex = 1;
            this.quit_Button.Text = "退出";
            this.quit_Button.UseVisualStyleBackColor = true;
            this.quit_Button.Click += new System.EventHandler(this.quit_Button_Click);
            // 
            // login_Button
            // 
            this.login_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.login_Button.Location = new System.Drawing.Point(65, 9);
            this.login_Button.Name = "login_Button";
            this.login_Button.Padding = new System.Windows.Forms.Padding(1);
            this.login_Button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.login_Button.Size = new System.Drawing.Size(75, 23);
            this.login_Button.TabIndex = 0;
            this.login_Button.Text = "登录";
            this.login_Button.UseVisualStyleBackColor = true;
            this.login_Button.Click += new System.EventHandler(this.login_Button_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel2.Controls.Add(this.labelCaptchaImage);
            this.panel2.Controls.Add(this.textBoxCaptcha);
            this.panel2.Location = new System.Drawing.Point(153, 123);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel2.Size = new System.Drawing.Size(192, 41);
            this.panel2.TabIndex = 5;
            // 
            // labelCaptchaImage
            // 
            this.labelCaptchaImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCaptchaImage.Location = new System.Drawing.Point(87, 10);
            this.labelCaptchaImage.Name = "labelCaptchaImage";
            this.labelCaptchaImage.Size = new System.Drawing.Size(64, 20);
            this.labelCaptchaImage.TabIndex = 1;
            this.labelCaptchaImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCaptchaImage.Click += new System.EventHandler(this.labelCaptchaImage_Click);
            // 
            // textBoxCaptcha
            // 
            this.textBoxCaptcha.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxCaptcha.Location = new System.Drawing.Point(3, 9);
            this.textBoxCaptcha.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxCaptcha.Name = "textBoxCaptcha";
            this.textBoxCaptcha.Size = new System.Drawing.Size(72, 22);
            this.textBoxCaptcha.TabIndex = 0;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.login_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 262);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "登录";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label PassWordLabel;
        private System.Windows.Forms.Label CaptchaLabel;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxPassWord;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button quit_Button;
        private System.Windows.Forms.Button login_Button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelCaptchaImage;
        private System.Windows.Forms.TextBox textBoxCaptcha;
    }
}

