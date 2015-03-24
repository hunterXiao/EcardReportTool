using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace EcardReportTool
{
    public partial class MainForm : Form
    {
        private static WebControl wc;

        public MainForm()
        {
            InitializeComponent();
            wc = WebControl.Instance();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_GHCheck_SavePath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBox_GH_Check.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void button_ZWCheck_SavePath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBox_ZW_Check.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void button_GHSignature_SavePath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBox_GH_Signature.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void button_ZWSignature_SavePath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBox_ZW_Signature.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void button_GHSignature_Download_Click(object sender, EventArgs e)
        {
            string accountCode = this.textBoxPeriod.Text;
            string savePath = this.textBox_GH_Signature.Text;
            string vendorListPath = @"vendor_gh.txt";
            if (accountCode != null && savePath != null && File.Exists(vendorListPath))
            {
                wc.ExportExcel(accountCode, savePath, vendorListPath);
            }
            else
            {
                MessageBox.Show("期別，保存路徑不能爲空或工會包商列表vendor_gh.txt不存在！");
            }
        }

        private void button5_ZWSignatue_Download_Click(object sender, EventArgs e)
        {
            string accountCode = this.textBoxPeriod.Text;
            string savePath = this.textBox_ZW_Signature.Text;
            string vendorListPath = @"vendor_zw.txt";
            if (accountCode != null && savePath != null && File.Exists(vendorListPath))
            {
                wc.ExportExcel(accountCode, savePath, vendorListPath);
            }
            else
            {
                MessageBox.Show("期別，保存路徑不能爲空或總務會包商列表vendor_zw.txt不存在！");
            }
        }

        private void buttonChoosePrintPath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                this.textBoxPrintPath.Text = folderBrowserDialog.SelectedPath;
            }
        }


    }
}
