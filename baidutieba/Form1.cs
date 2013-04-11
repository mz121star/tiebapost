using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using core;
using core.Service;
using mshtml;
namespace baidutieba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private RFile rFile;
        private void button1_Click(object sender, EventArgs e)
        {
            
            DownSchoolInfo downSchoolInfo = new DownSchoolInfo(rFile, listSchools);
            downSchoolInfo.ShowDialog(this);
        }

        private void listSchools_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var a = ((ListBox)sender).SelectedItem;
            if (a != null)
            {
                webBrowser1.Url = new Uri("http://tieba.baidu.com/f?kw=" + a.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rFile = new RFile(AppDomain.CurrentDomain.BaseDirectory + "/school.txt");
            listSchools.DataSource = rFile.ReadFromFile().Split(',');
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var document = webBrowser1.Document;
            document.GetElementById("title1").InnerText = "大家好，交友贴";
            HtmlDocumentHelper.GetHtmlByClassName(document, "tb-editor-editarea").InnerHtml =
                " 大家好！贴吧的朋友们！。　<img unselectable=\"on\" pic_type=\"1\" class=\"BDE_Image\" src=\"http://t1.baidu.com/it/u=305118534,2056704168&amp;fm=21&amp;gp=0.jpg\">　";
            HtmlElement htmlElement = HtmlDocumentHelper.GetInputByClassName(document,"subbtn_bg");
            htmlElement.InvokeMember("click");
        }
    }
}
