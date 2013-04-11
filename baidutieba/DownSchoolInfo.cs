using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using core;

namespace baidutieba
{
    public partial class DownSchoolInfo : Form
    {
        public DownSchoolInfo()
        {
            InitializeComponent();
        }

        private RFile rFile;
        private ListBox listbox;
        public DownSchoolInfo(RFile rfile, ListBox list)
        {
            InitializeComponent();
            rFile = rfile;
            listbox = list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string urltemplate =
              "http://xuexiao.eol.cn/yep_school/school.s?type=yep_schoolIndex&cengci={0}_cengci+&local1={1}_local1&local2={2}_local2&page=**";
            string[] paras = new string[] {txtl.Text.Trim(), txtp.Text.Trim(), txtc.Text.Trim()};
            string url = string.Format(urltemplate, paras);
           url= url.Replace("**", "{0}");
            Common.BindSchoolInfo(rFile, listbox,url);
        }
    }
}
