﻿namespace baidutieba
{
    partial class DownSchoolInfo
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
            this.txtp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtc = new System.Windows.Forms.TextBox();
            this.txtl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "初始化学校信息";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtp
            // 
            this.txtp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtp.Location = new System.Drawing.Point(26, 32);
            this.txtp.Name = "txtp";
            this.txtp.Size = new System.Drawing.Size(52, 20);
            this.txtp.TabIndex = 1;
            this.txtp.Text = "辽宁";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "省";
            // 
            // txtc
            // 
            this.txtc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtc.Location = new System.Drawing.Point(108, 32);
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(56, 20);
            this.txtc.TabIndex = 3;
            this.txtc.Text = "鞍山市";
            this.txtc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtl
            // 
            this.txtl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtl.Location = new System.Drawing.Point(195, 32);
            this.txtl.Name = "txtl";
            this.txtl.Size = new System.Drawing.Size(35, 20);
            this.txtl.TabIndex = 5;
            this.txtl.Text = "中学";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 6;
            // 
            // DownSchoolInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 188);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtl);
            this.Controls.Add(this.txtc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtp);
            this.Controls.Add(this.button1);
            this.Name = "DownSchoolInfo";
            this.Text = "初始化学校信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtc;
        private System.Windows.Forms.TextBox txtl;
        private System.Windows.Forms.Label label3;
    }
}