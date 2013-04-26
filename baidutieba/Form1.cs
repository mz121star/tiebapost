using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using GitSharp.Commands;
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
                webBrowser1.Url = new Uri(ENV.TieBaUrl + a.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rFile = new RFile(ENV.BaseDir + "/school.txt");
            listSchools.DataSource = rFile.ReadFromFile().Split(',');
            BindPost();
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
        private PostModel GetPostContent()
        {
            PostModel post = new PostModel();
            var file = (FileInfo) cmbposts.SelectedItem;
            var rfile = new RFile(file.FullName);
            post.Content = rfile.ReadFromFile();
            post.Title = file.Name.Replace(".txt","").Replace(".html","");
            return post;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            LoginModel loginModel = new LoginModel();
            loginModel.LoginUrl = ENV.BaiduLoginUrl;
            loginModel.UserName = "jarrick@126.com";
            loginModel.PassWord = "880121mz";
            TiebaHelper.LoginBaidu(webBrowser1, loginModel);
             
           
        }

        private void btnAccountManager_Click(object sender, EventArgs e)
        {
            AccountManager accountManager = new AccountManager();
            accountManager.ShowDialog(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Common.GetLastContentFromSVN(BindPost);

        }
    }
}
