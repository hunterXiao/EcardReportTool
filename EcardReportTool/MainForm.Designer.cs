namespace EcardReportTool
{
    partial class MainForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_ZWCheck_Download = new System.Windows.Forms.Button();
            this.button_ZWCheck_SavePath = new System.Windows.Forms.Button();
            this.button_GHCheckDownload = new System.Windows.Forms.Button();
            this.button_GHCheck_SavePath = new System.Windows.Forms.Button();
            this.textBox_ZW_Check = new System.Windows.Forms.TextBox();
            this.textBox_GH_Check = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5_ZWSignatue_Download = new System.Windows.Forms.Button();
            this.button_ZWSignature_SavePath = new System.Windows.Forms.Button();
            this.button_GHSignature_Download = new System.Windows.Forms.Button();
            this.button_GHSignature_SavePath = new System.Windows.Forms.Button();
            this.textBox_ZW_Signature = new System.Windows.Forms.TextBox();
            this.textBox_GH_Signature = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPeriod = new System.Windows.Forms.TextBox();
            this.checkBoxTotalAccount = new System.Windows.Forms.CheckBox();
            this.checkBoxBlack = new System.Windows.Forms.CheckBox();
            this.checkBoxNormalAccount = new System.Windows.Forms.CheckBox();
            this.checkBoxDelayHours = new System.Windows.Forms.CheckBox();
            this.checkBoxOutOfTime = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBox3);
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(484, 362);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBoxOutOfTime);
            this.groupBox3.Controls.Add(this.checkBoxDelayHours);
            this.groupBox3.Controls.Add(this.checkBoxNormalAccount);
            this.groupBox3.Controls.Add(this.checkBoxBlack);
            this.groupBox3.Controls.Add(this.checkBoxTotalAccount);
            this.groupBox3.Controls.Add(this.textBoxPeriod);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(469, 65);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "选项";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_ZWCheck_Download);
            this.groupBox1.Controls.Add(this.button_ZWCheck_SavePath);
            this.groupBox1.Controls.Add(this.button_GHCheckDownload);
            this.groupBox1.Controls.Add(this.button_GHCheck_SavePath);
            this.groupBox1.Controls.Add(this.textBox_ZW_Check);
            this.groupBox1.Controls.Add(this.textBox_GH_Check);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "对账报表";
            // 
            // button_ZWCheck_Download
            // 
            this.button_ZWCheck_Download.Location = new System.Drawing.Point(388, 64);
            this.button_ZWCheck_Download.Name = "button_ZWCheck_Download";
            this.button_ZWCheck_Download.Size = new System.Drawing.Size(75, 23);
            this.button_ZWCheck_Download.TabIndex = 7;
            this.button_ZWCheck_Download.Text = "下载";
            this.button_ZWCheck_Download.UseVisualStyleBackColor = true;
            // 
            // button_ZWCheck_SavePath
            // 
            this.button_ZWCheck_SavePath.Location = new System.Drawing.Point(306, 63);
            this.button_ZWCheck_SavePath.Name = "button_ZWCheck_SavePath";
            this.button_ZWCheck_SavePath.Size = new System.Drawing.Size(75, 23);
            this.button_ZWCheck_SavePath.TabIndex = 6;
            this.button_ZWCheck_SavePath.Text = "保存路径";
            this.button_ZWCheck_SavePath.UseVisualStyleBackColor = true;
            this.button_ZWCheck_SavePath.Click += new System.EventHandler(this.button_ZWCheck_SavePath_Click);
            // 
            // button_GHCheckDownload
            // 
            this.button_GHCheckDownload.Location = new System.Drawing.Point(388, 35);
            this.button_GHCheckDownload.Name = "button_GHCheckDownload";
            this.button_GHCheckDownload.Size = new System.Drawing.Size(75, 23);
            this.button_GHCheckDownload.TabIndex = 5;
            this.button_GHCheckDownload.Text = "下载";
            this.button_GHCheckDownload.UseVisualStyleBackColor = true;
            // 
            // button_GHCheck_SavePath
            // 
            this.button_GHCheck_SavePath.Location = new System.Drawing.Point(306, 35);
            this.button_GHCheck_SavePath.Name = "button_GHCheck_SavePath";
            this.button_GHCheck_SavePath.Size = new System.Drawing.Size(75, 23);
            this.button_GHCheck_SavePath.TabIndex = 4;
            this.button_GHCheck_SavePath.Text = "保存路径";
            this.button_GHCheck_SavePath.UseVisualStyleBackColor = true;
            this.button_GHCheck_SavePath.Click += new System.EventHandler(this.button_GHCheck_SavePath_Click);
            // 
            // textBox_ZW_Check
            // 
            this.textBox_ZW_Check.Location = new System.Drawing.Point(53, 66);
            this.textBox_ZW_Check.Name = "textBox_ZW_Check";
            this.textBox_ZW_Check.Size = new System.Drawing.Size(234, 21);
            this.textBox_ZW_Check.TabIndex = 3;
            // 
            // textBox_GH_Check
            // 
            this.textBox_GH_Check.Location = new System.Drawing.Point(53, 35);
            this.textBox_GH_Check.Name = "textBox_GH_Check";
            this.textBox_GH_Check.Size = new System.Drawing.Size(234, 21);
            this.textBox_GH_Check.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "总务";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "工会";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5_ZWSignatue_Download);
            this.groupBox2.Controls.Add(this.button_ZWSignature_SavePath);
            this.groupBox2.Controls.Add(this.button_GHSignature_Download);
            this.groupBox2.Controls.Add(this.button_GHSignature_SavePath);
            this.groupBox2.Controls.Add(this.textBox_ZW_Signature);
            this.groupBox2.Controls.Add(this.textBox_GH_Signature);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(3, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(469, 120);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "签核报表";
            // 
            // button5_ZWSignatue_Download
            // 
            this.button5_ZWSignatue_Download.Location = new System.Drawing.Point(388, 70);
            this.button5_ZWSignatue_Download.Name = "button5_ZWSignatue_Download";
            this.button5_ZWSignatue_Download.Size = new System.Drawing.Size(75, 23);
            this.button5_ZWSignatue_Download.TabIndex = 15;
            this.button5_ZWSignatue_Download.Text = "下载";
            this.button5_ZWSignatue_Download.UseVisualStyleBackColor = true;
            // 
            // button_ZWSignature_SavePath
            // 
            this.button_ZWSignature_SavePath.Location = new System.Drawing.Point(306, 69);
            this.button_ZWSignature_SavePath.Name = "button_ZWSignature_SavePath";
            this.button_ZWSignature_SavePath.Size = new System.Drawing.Size(75, 23);
            this.button_ZWSignature_SavePath.TabIndex = 14;
            this.button_ZWSignature_SavePath.Text = "保存路径";
            this.button_ZWSignature_SavePath.UseVisualStyleBackColor = true;
            this.button_ZWSignature_SavePath.Click += new System.EventHandler(this.button_ZWSignature_SavePath_Click);
            // 
            // button_GHSignature_Download
            // 
            this.button_GHSignature_Download.Location = new System.Drawing.Point(388, 41);
            this.button_GHSignature_Download.Name = "button_GHSignature_Download";
            this.button_GHSignature_Download.Size = new System.Drawing.Size(75, 23);
            this.button_GHSignature_Download.TabIndex = 13;
            this.button_GHSignature_Download.Text = "下载";
            this.button_GHSignature_Download.UseVisualStyleBackColor = true;
            // 
            // button_GHSignature_SavePath
            // 
            this.button_GHSignature_SavePath.Location = new System.Drawing.Point(306, 41);
            this.button_GHSignature_SavePath.Name = "button_GHSignature_SavePath";
            this.button_GHSignature_SavePath.Size = new System.Drawing.Size(75, 23);
            this.button_GHSignature_SavePath.TabIndex = 12;
            this.button_GHSignature_SavePath.Text = "保存路径";
            this.button_GHSignature_SavePath.UseVisualStyleBackColor = true;
            this.button_GHSignature_SavePath.Click += new System.EventHandler(this.button_GHSignature_SavePath_Click);
            // 
            // textBox_ZW_Signature
            // 
            this.textBox_ZW_Signature.Location = new System.Drawing.Point(53, 72);
            this.textBox_ZW_Signature.Name = "textBox_ZW_Signature";
            this.textBox_ZW_Signature.Size = new System.Drawing.Size(234, 21);
            this.textBox_ZW_Signature.TabIndex = 11;
            // 
            // textBox_GH_Signature
            // 
            this.textBox_GH_Signature.Location = new System.Drawing.Point(53, 41);
            this.textBox_GH_Signature.Name = "textBox_GH_Signature";
            this.textBox_GH_Signature.Size = new System.Drawing.Size(234, 21);
            this.textBox_GH_Signature.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "总务";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "工会";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Location = new System.Drawing.Point(3, 326);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 33);
            this.panel1.TabIndex = 2;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 19);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(469, 14);
            this.progressBar1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "期别";
            // 
            // textBoxPeriod
            // 
            this.textBoxPeriod.Location = new System.Drawing.Point(53, 18);
            this.textBoxPeriod.Name = "textBoxPeriod";
            this.textBoxPeriod.Size = new System.Drawing.Size(100, 21);
            this.textBoxPeriod.TabIndex = 1;
            // 
            // checkBoxTotalAccount
            // 
            this.checkBoxTotalAccount.AutoSize = true;
            this.checkBoxTotalAccount.Location = new System.Drawing.Point(205, 12);
            this.checkBoxTotalAccount.Name = "checkBoxTotalAccount";
            this.checkBoxTotalAccount.Size = new System.Drawing.Size(84, 16);
            this.checkBoxTotalAccount.TabIndex = 2;
            this.checkBoxTotalAccount.Text = "结账总次数";
            this.checkBoxTotalAccount.UseVisualStyleBackColor = true;
            // 
            // checkBoxBlack
            // 
            this.checkBoxBlack.AutoSize = true;
            this.checkBoxBlack.Location = new System.Drawing.Point(205, 39);
            this.checkBoxBlack.Name = "checkBoxBlack";
            this.checkBoxBlack.Size = new System.Drawing.Size(60, 16);
            this.checkBoxBlack.TabIndex = 3;
            this.checkBoxBlack.Text = "黑名单";
            this.checkBoxBlack.UseVisualStyleBackColor = true;
            // 
            // checkBoxNormalAccount
            // 
            this.checkBoxNormalAccount.AutoSize = true;
            this.checkBoxNormalAccount.Location = new System.Drawing.Point(306, 12);
            this.checkBoxNormalAccount.Name = "checkBoxNormalAccount";
            this.checkBoxNormalAccount.Size = new System.Drawing.Size(72, 16);
            this.checkBoxNormalAccount.TabIndex = 4;
            this.checkBoxNormalAccount.Text = "正常结算";
            this.checkBoxNormalAccount.UseVisualStyleBackColor = true;
            // 
            // checkBoxDelayHours
            // 
            this.checkBoxDelayHours.AutoSize = true;
            this.checkBoxDelayHours.Location = new System.Drawing.Point(306, 38);
            this.checkBoxDelayHours.Name = "checkBoxDelayHours";
            this.checkBoxDelayHours.Size = new System.Drawing.Size(72, 16);
            this.checkBoxDelayHours.TabIndex = 5;
            this.checkBoxDelayHours.Text = "超24小时";
            this.checkBoxDelayHours.UseVisualStyleBackColor = true;
            // 
            // checkBoxOutOfTime
            // 
            this.checkBoxOutOfTime.AutoSize = true;
            this.checkBoxOutOfTime.Location = new System.Drawing.Point(385, 12);
            this.checkBoxOutOfTime.Name = "checkBoxOutOfTime";
            this.checkBoxOutOfTime.Size = new System.Drawing.Size(84, 16);
            this.checkBoxOutOfTime.TabIndex = 6;
            this.checkBoxOutOfTime.Text = "非消费时间";
            this.checkBoxOutOfTime.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 362);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EcardReportTool";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_ZWCheck_Download;
        private System.Windows.Forms.Button button_ZWCheck_SavePath;
        private System.Windows.Forms.Button button_GHCheckDownload;
        private System.Windows.Forms.Button button_GHCheck_SavePath;
        private System.Windows.Forms.TextBox textBox_ZW_Check;
        private System.Windows.Forms.TextBox textBox_GH_Check;
        private System.Windows.Forms.Button button5_ZWSignatue_Download;
        private System.Windows.Forms.Button button_ZWSignature_SavePath;
        private System.Windows.Forms.Button button_GHSignature_Download;
        private System.Windows.Forms.Button button_GHSignature_SavePath;
        private System.Windows.Forms.TextBox textBox_ZW_Signature;
        private System.Windows.Forms.TextBox textBox_GH_Signature;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBoxDelayHours;
        private System.Windows.Forms.CheckBox checkBoxNormalAccount;
        private System.Windows.Forms.CheckBox checkBoxBlack;
        private System.Windows.Forms.CheckBox checkBoxTotalAccount;
        private System.Windows.Forms.TextBox textBoxPeriod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxOutOfTime;



    }
}