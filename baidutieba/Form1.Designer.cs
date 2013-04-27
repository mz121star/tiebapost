namespace baidutieba
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listSchools = new System.Windows.Forms.ListBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnpost = new System.Windows.Forms.Button();
            this.cmbposts = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_getcontent = new System.Windows.Forms.Button();
            this.btn_AccountManager = new System.Windows.Forms.Button();
            this.btn_getschool = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listSchools
            // 
            this.listSchools.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listSchools.FormattingEnabled = true;
            this.listSchools.Location = new System.Drawing.Point(688, 3);
            this.listSchools.Name = "listSchools";
            this.listSchools.Size = new System.Drawing.Size(144, 394);
            this.listSchools.TabIndex = 2;
            this.listSchools.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listSchools_MouseDoubleClick);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(679, 417);
            this.webBrowser1.TabIndex = 3;
            this.webBrowser1.Url = new System.Uri("", System.UriKind.Relative);
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted_1);
            // 
            // btnpost
            // 
            this.btnpost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnpost.Location = new System.Drawing.Point(103, 457);
            this.btnpost.Name = "btnpost";
            this.btnpost.Size = new System.Drawing.Size(75, 23);
            this.btnpost.TabIndex = 4;
            this.btnpost.Text = "发一条";
            this.btnpost.UseVisualStyleBackColor = true;
            this.btnpost.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbposts
            // 
            this.cmbposts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbposts.FormattingEnabled = true;
            this.cmbposts.Location = new System.Drawing.Point(184, 459);
            this.cmbposts.Name = "cmbposts";
            this.cmbposts.Size = new System.Drawing.Size(302, 21);
            this.cmbposts.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(22, 457);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "登录百度";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new System.Drawing.Size(843, 525);
            this.tabControl1.TabIndex = 9;
            this.tabControl1.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.webBrowser1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.cmbposts);
            this.tabPage1.Controls.Add(this.btnpost);
            this.tabPage1.Controls.Add(this.listSchools);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(835, 499);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "首页";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(835, 499);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "配置";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_getcontent
            // 
            this.btn_getcontent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_getcontent.Location = new System.Drawing.Point(49, 67);
            this.btn_getcontent.Name = "btn_getcontent";
            this.btn_getcontent.Size = new System.Drawing.Size(97, 23);
            this.btn_getcontent.TabIndex = 11;
            this.btn_getcontent.Text = "获取所有文章";
            this.btn_getcontent.UseVisualStyleBackColor = true;
            this.btn_getcontent.Click += new System.EventHandler(this.btn_getcontent_Click);
            // 
            // btn_AccountManager
            // 
            this.btn_AccountManager.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_AccountManager.Location = new System.Drawing.Point(167, 67);
            this.btn_AccountManager.Name = "btn_AccountManager";
            this.btn_AccountManager.Size = new System.Drawing.Size(97, 23);
            this.btn_AccountManager.TabIndex = 10;
            this.btn_AccountManager.Text = "账户管理";
            this.btn_AccountManager.UseVisualStyleBackColor = true;
            this.btn_AccountManager.Click += new System.EventHandler(this.btn_AccountManager_Click);
            // 
            // btn_getschool
            // 
            this.btn_getschool.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_getschool.Location = new System.Drawing.Point(289, 67);
            this.btn_getschool.Name = "btn_getschool";
            this.btn_getschool.Size = new System.Drawing.Size(97, 23);
            this.btn_getschool.TabIndex = 9;
            this.btn_getschool.Text = "获取学校";
            this.btn_getschool.UseVisualStyleBackColor = true;
            this.btn_getschool.Click += new System.EventHandler(this.btn_getschool_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_getcontent);
            this.groupBox1.Controls.Add(this.btn_getschool);
            this.groupBox1.Controls.Add(this.btn_AccountManager);
            this.groupBox1.Location = new System.Drawing.Point(185, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 154);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "配置";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 525);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "贴吧精灵--帮您省下喝咖啡的时间";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listSchools;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnpost;
        private System.Windows.Forms.ComboBox cmbposts;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_getcontent;
        private System.Windows.Forms.Button btn_AccountManager;
        private System.Windows.Forms.Button btn_getschool;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

