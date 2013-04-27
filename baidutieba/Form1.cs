using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

using Newtonsoft.Json;
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


        private void GetSchoolInfo()
        {
            DownSchoolInfo downSchoolInfo = new DownSchoolInfo(rFile, listSchools);
            downSchoolInfo.ShowDialog(this);
        }

        private void listSchools_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var a = ((ListBox)sender).SelectedItem;
            if (a != null)
            {
                webBrowser1.Url = new Uri(ENV.TieBaUrl + a.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {

                rFile = new RFile(ENV.BaseDir + "/school.txt");
                listSchools.DataSource = rFile.ReadFromFile().Split(',');
            }
            catch (NullReferenceException ex)
            {
                GetSchoolInfo();
            }
            BindPost();

            webBrowser1.Url = new Uri(ENV.BaseDir + "intro/readme.html");

        }



        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var document = webBrowser1.Document;
                TiebaHelper.Post(document, GetPostContent());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }

        private void BindPost()
        {
            var dir = DirectoryHelper.Getfiles(ENV.BaseDir + ENV.PostFiles);
            cmbposts.DataSource = dir;

        }
        /// <summary>
        /// 获取本地文章
        /// </summary>
        /// <returns></returns>
        private PostModel GetPostContent()
        {
            PostModel post = new PostModel();
            var file = (FileInfo)cmbposts.SelectedItem;
            var rfile = new RFile(file.FullName);
            post.Content = rfile.ReadFromFile();
            post.Title = file.Name.Replace(".txt", "").Replace(".html", "");
            return post;
        }
        /// <summary>
        /// 登录百度
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click_1(object sender, EventArgs e)
        {

            List<LoginModel> accounts = Common.ReadAccount(Common.GetAccountRFile());
            if (accounts.Count == 0)
            {
                MessageBox.Show("还没有配置百度账户，请先配置");
                ShowAccountManager();
                return;
            }

            SelectAccount selectAccount = new SelectAccount(accounts);
            selectAccount.ShowDialog(this);

            if (selectAccount.CurrentLogin != null && selectAccount.DialogResult == DialogResult.OK)
            {

                selectAccount.CurrentLogin.LoginUrl = ENV.BaiduLoginUrl;

                TiebaHelper.LoginBaidu(webBrowser1, selectAccount.CurrentLogin);

            }
            else
            {
                if (selectAccount.DialogResult == DialogResult.OK)
                    MessageBox.Show("选择错误");

            }



        }


        /// <summary>
        /// 显示账户管理
        /// </summary>
        private void ShowAccountManager()
        {
            AccountManager accountManager = new AccountManager();
            accountManager.ShowDialog(this);
        }



        /// <summary>
        /// 初始化说明页面的事件
        /// </summary>
        private void initWebbrowser()
        {
            var btnLogin = getPageButton("btn_login");
            var btnGetContent = getPageButton("btn_getcontent");
            var btnGetSchool = getPageButton("btn_getschool");
            
            AttachEvent(btnLogin, button2_Click_1);
            if (btnLogin != null)
            {
                webBrowser1.DocumentCompleted -= webBrowser1_DocumentCompleted_1;
            }
            AttachEvent(btnGetContent, btn_getcontent_Click);
            AttachEvent(btnGetSchool, btn_getschool_Click);
        }

        private HtmlElement getPageButton(string id)
        {
            HtmlDocument htmlDoc = webBrowser1.Document;
            HtmlElement btnElement = htmlDoc.GetElementById(id);
            return btnElement;
        }
        private void AttachEvent(HtmlElement btnElement, HtmlElementEventHandler handler)
        {
            if (btnElement != null)
            {
                btnElement.Click += handler;
            }
        }

        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            initWebbrowser();
        }
        /// <summary>
        /// 获取学校信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_getschool_Click(object sender, EventArgs e)
        {
            GetSchoolInfo();
        }
        /// <summary>
        /// 从svn获取最新内容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_getcontent_Click(object sender, EventArgs e)
        {
            Common.GetLastContentFromSVN();
            BindPost();
        }
        /// <summary>
        /// 账户管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AccountManager_Click(object sender, EventArgs e)
        {
            ShowAccountManager();
        }


    }
}
