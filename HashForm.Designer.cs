namespace MyToolBox
{
    partial class HashForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.hash_Label = new System.Windows.Forms.Label();
            this.resText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.calMd5_Btn = new System.Windows.Forms.Button();
            this.calSha256_Btn = new System.Windows.Forms.Button();
            this.calSha1_Btn = new System.Windows.Forms.Button();
            this.copyToClipBoard_Btn = new System.Windows.Forms.Button();
            this.lowerCase_Ratio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.upperCase_Radio = new System.Windows.Forms.RadioButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.copied_label = new System.Windows.Forms.Label();
            this.input_TextBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.HomePage = new System.Windows.Forms.TabPage();
            this.HashPage = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.HashPage.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hash_Label
            // 
            this.hash_Label.AutoSize = true;
            this.hash_Label.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.hash_Label.Location = new System.Drawing.Point(52, 34);
            this.hash_Label.Name = "hash_Label";
            this.hash_Label.Size = new System.Drawing.Size(297, 40);
            this.hash_Label.TabIndex = 0;
            this.hash_Label.Text = "哈希摘要值计算";
            this.hash_Label.Click += new System.EventHandler(this.label1_Click);
            // 
            // resText
            // 
            this.resText.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resText.Location = new System.Drawing.Point(101, 434);
            this.resText.Name = "resText";
            this.resText.ReadOnly = true;
            this.resText.Size = new System.Drawing.Size(798, 39);
            this.resText.TabIndex = 2;
            this.resText.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(39, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "结果";
            // 
            // calMd5_Btn
            // 
            this.calMd5_Btn.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.calMd5_Btn.Location = new System.Drawing.Point(59, 314);
            this.calMd5_Btn.Name = "calMd5_Btn";
            this.calMd5_Btn.Size = new System.Drawing.Size(112, 33);
            this.calMd5_Btn.TabIndex = 4;
            this.calMd5_Btn.Text = "MD5";
            this.calMd5_Btn.UseVisualStyleBackColor = true;
            this.calMd5_Btn.Click += new System.EventHandler(this.cal_md5_btn_Click);
            // 
            // calSha256_Btn
            // 
            this.calSha256_Btn.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.calSha256_Btn.Location = new System.Drawing.Point(295, 314);
            this.calSha256_Btn.Name = "calSha256_Btn";
            this.calSha256_Btn.Size = new System.Drawing.Size(112, 33);
            this.calSha256_Btn.TabIndex = 5;
            this.calSha256_Btn.Text = "SHA256";
            this.calSha256_Btn.UseVisualStyleBackColor = true;
            this.calSha256_Btn.Click += new System.EventHandler(this.cal_sha256_btn_Click);
            // 
            // calSha1_Btn
            // 
            this.calSha1_Btn.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.calSha1_Btn.Location = new System.Drawing.Point(177, 314);
            this.calSha1_Btn.Name = "calSha1_Btn";
            this.calSha1_Btn.Size = new System.Drawing.Size(112, 33);
            this.calSha1_Btn.TabIndex = 6;
            this.calSha1_Btn.Text = "SHA1";
            this.calSha1_Btn.UseVisualStyleBackColor = true;
            this.calSha1_Btn.Click += new System.EventHandler(this.cal_sha1_btn_Click);
            // 
            // copyToClipBoard_Btn
            // 
            this.copyToClipBoard_Btn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.copyToClipBoard_Btn.Location = new System.Drawing.Point(917, 433);
            this.copyToClipBoard_Btn.Name = "copyToClipBoard_Btn";
            this.copyToClipBoard_Btn.Size = new System.Drawing.Size(166, 39);
            this.copyToClipBoard_Btn.TabIndex = 7;
            this.copyToClipBoard_Btn.Text = "复制到剪贴板";
            this.copyToClipBoard_Btn.UseVisualStyleBackColor = true;
            this.copyToClipBoard_Btn.Click += new System.EventHandler(this.copyToClipBoard_Btn_Click);
            // 
            // lowerCase_Ratio
            // 
            this.lowerCase_Ratio.AutoSize = true;
            this.lowerCase_Ratio.Checked = true;
            this.lowerCase_Ratio.Location = new System.Drawing.Point(15, 57);
            this.lowerCase_Ratio.Name = "lowerCase_Ratio";
            this.lowerCase_Ratio.Size = new System.Drawing.Size(82, 19);
            this.lowerCase_Ratio.TabIndex = 8;
            this.lowerCase_Ratio.TabStop = true;
            this.lowerCase_Ratio.Text = "小写a~f";
            this.lowerCase_Ratio.UseVisualStyleBackColor = true;
            this.lowerCase_Ratio.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.upperCase_Radio);
            this.groupBox1.Controls.Add(this.lowerCase_Ratio);
            this.groupBox1.Location = new System.Drawing.Point(723, 314);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "16进制字母大小写";
            // 
            // upperCase_Radio
            // 
            this.upperCase_Radio.AutoSize = true;
            this.upperCase_Radio.Location = new System.Drawing.Point(15, 24);
            this.upperCase_Radio.Name = "upperCase_Radio";
            this.upperCase_Radio.Size = new System.Drawing.Size(82, 19);
            this.upperCase_Radio.TabIndex = 9;
            this.upperCase_Radio.Text = "大写A~F";
            this.upperCase_Radio.UseVisualStyleBackColor = true;
            this.upperCase_Radio.CheckedChanged += new System.EventHandler(this.upperCase_Radio_CheckedChanged);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 31);
            this.button1.TabIndex = 10;
            this.button1.Text = "打开文件";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 31);
            this.button2.TabIndex = 11;
            this.button2.Text = "清空输入";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // copied_label
            // 
            this.copied_label.AutoSize = true;
            this.copied_label.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.copied_label.Location = new System.Drawing.Point(1027, 486);
            this.copied_label.Name = "copied_label";
            this.copied_label.Size = new System.Drawing.Size(56, 13);
            this.copied_label.TabIndex = 12;
            this.copied_label.Text = "Copied!";
            this.copied_label.Visible = false;
            this.copied_label.Click += new System.EventHandler(this.label2_Click);
            // 
            // input_TextBox
            // 
            this.input_TextBox.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.input_TextBox.Location = new System.Drawing.Point(59, 97);
            this.input_TextBox.Multiline = true;
            this.input_TextBox.Name = "input_TextBox";
            this.input_TextBox.Size = new System.Drawing.Size(840, 197);
            this.input_TextBox.TabIndex = 1;
            this.input_TextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.HomePage);
            this.tabControl1.Controls.Add(this.HashPage);
            this.tabControl1.Location = new System.Drawing.Point(22, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1276, 762);
            this.tabControl1.TabIndex = 13;
            // 
            // HomePage
            // 
            this.HomePage.Cursor = System.Windows.Forms.Cursors.Cross;
            this.HomePage.Location = new System.Drawing.Point(4, 25);
            this.HomePage.Name = "HomePage";
            this.HomePage.Padding = new System.Windows.Forms.Padding(3);
            this.HomePage.Size = new System.Drawing.Size(1268, 733);
            this.HomePage.TabIndex = 0;
            this.HomePage.Text = "首页";
            this.HomePage.UseVisualStyleBackColor = true;
            // 
            // HashPage
            // 
            this.HashPage.Controls.Add(this.flowLayoutPanel1);
            this.HashPage.Controls.Add(this.hash_Label);
            this.HashPage.Controls.Add(this.groupBox1);
            this.HashPage.Controls.Add(this.copied_label);
            this.HashPage.Controls.Add(this.input_TextBox);
            this.HashPage.Controls.Add(this.resText);
            this.HashPage.Controls.Add(this.label1);
            this.HashPage.Controls.Add(this.calMd5_Btn);
            this.HashPage.Controls.Add(this.copyToClipBoard_Btn);
            this.HashPage.Controls.Add(this.calSha256_Btn);
            this.HashPage.Controls.Add(this.calSha1_Btn);
            this.HashPage.Location = new System.Drawing.Point(4, 25);
            this.HashPage.Name = "HashPage";
            this.HashPage.Padding = new System.Windows.Forms.Padding(3);
            this.HashPage.Size = new System.Drawing.Size(1268, 733);
            this.HashPage.TabIndex = 1;
            this.HashPage.Text = "哈希计算";
            this.HashPage.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(928, 97);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(195, 197);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // HashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HashForm";
            this.Text = "工具箱";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.HashPage.ResumeLayout(false);
            this.HashPage.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label hash_Label;
        private System.Windows.Forms.TextBox resText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calMd5_Btn;
        private System.Windows.Forms.Button calSha256_Btn;
        private System.Windows.Forms.Button calSha1_Btn;
        private System.Windows.Forms.Button copyToClipBoard_Btn;
        private System.Windows.Forms.RadioButton lowerCase_Ratio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton upperCase_Radio;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label copied_label;
        private System.Windows.Forms.TextBox input_TextBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage HomePage;
        private System.Windows.Forms.TabPage HashPage;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

