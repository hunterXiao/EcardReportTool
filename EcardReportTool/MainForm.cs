using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EcardReportTool
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
                InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_GHCheck_SavePath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK) {
                textBox_GH_Check.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void button_ZWCheck_SavePath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK) {
                textBox_ZW_Check.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void button_GHSignature_SavePath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK) {
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


    }
}
