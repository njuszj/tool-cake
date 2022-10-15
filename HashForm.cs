using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Threading;

namespace MyToolBox
{
    public partial class HashForm : Form
    {
        public bool fileMode = false;
        public HashForm()
        {
            InitializeComponent();
            this.upperCase_Radio.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void correctResText()
        {
            if (this.lowerCase_Ratio.Checked)
            {
                this.resText.Text = this.resText.Text.ToLower();
            }

            else if (this.upperCase_Radio.Checked)
            {
                this.resText.Text = this.resText.Text.ToUpper();
            }

        }

        private void cal_hash_hex(Hashlib.HashAlgoType hashAlgo)
        {
            string res;
            if(this.fileMode == true)
            {
                res = Hashlib.GetStreamHexHash(this.input_TextBox.Text, hashAlgo);
            }
            else
            {
                res = Hashlib.GetTextHexHash(this.input_TextBox.Text, hashAlgo);
            }
            this.resText.Text = res;
            this.correctResText();
        }

        private void cal_md5_btn_Click(object sender, EventArgs e)
        {
            this.cal_hash_hex(Hashlib.HashAlgoType.MD5);
        }

        private void cal_sha1_btn_Click(object sender, EventArgs e)
        {
            this.cal_hash_hex(Hashlib.HashAlgoType.SHA1);
        }

        private void cal_sha256_btn_Click(object sender, EventArgs e)
        {
            this.cal_hash_hex(Hashlib.HashAlgoType.SHA256);
        }

        private void setCopiedInfoUnvisiable(object sender, EventArgs e)
        {
            DispatcherTimer timer = (DispatcherTimer) sender;
            timer.Stop();
            timer.Tick -= this.setCopiedInfoUnvisiable;
            this.copied_label.Visible = false;
        }

        private void copyToClipBoard_Btn_Click(object sender, EventArgs e)
        {
            if (this.resText.Text != null && this.resText.Text != "")
            {

                Clipboard.SetText(this.resText.Text);
                this.copied_label.Visible = true;
                // 使用DispatcherTimer添加一个延迟执行
                var timer = new System.Windows.Threading.DispatcherTimer();
                timer.Tick += this.setCopiedInfoUnvisiable;
                timer.Interval = new TimeSpan(0, 0, 1);
                timer.Start();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.correctResText();
        }

        private void upperCase_Radio_CheckedChanged(object sender, EventArgs e)
        {
            this.correctResText();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                RestoreDirectory = true
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.input_TextBox.Text = ofd.FileName;
                this.input_TextBox.Enabled = false;
                this.fileMode = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.input_TextBox.Text = "";
            this.fileMode = false;
            this.input_TextBox.Enabled = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
