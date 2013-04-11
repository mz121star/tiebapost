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
            this.button1 = new System.Windows.Forms.Button();
            this.listSchools = new System.Windows.Forms.ListBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnpost = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(588, 490);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "获取学校";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listSchools
            // 
            this.listSchools.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listSchools.FormattingEnabled = true;
            this.listSchools.Location = new System.Drawing.Point(588, 6);
            this.listSchools.Name = "listSchools";
            this.listSchools.Size = new System.Drawing.Size(144, 472);
            this.listSchools.TabIndex = 2;
            this.listSchools.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listSchools_MouseDoubleClick);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(12, 6);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(570, 472);
            this.webBrowser1.TabIndex = 3;
            // 
            // btnpost
            // 
            this.btnpost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnpost.Location = new System.Drawing.Point(13, 489);
            this.btnpost.Name = "btnpost";
            this.btnpost.Size = new System.Drawing.Size(75, 23);
            this.btnpost.TabIndex = 4;
            this.btnpost.Text = "发一条";
            this.btnpost.UseVisualStyleBackColor = true;
            this.btnpost.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 525);
            this.Controls.Add(this.btnpost);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.listSchools);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "贴吧精灵";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listSchools;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnpost;
    }
}

