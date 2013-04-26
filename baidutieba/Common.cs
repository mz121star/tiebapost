using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using core;
using core.Service;

namespace baidutieba
{
    public class Common
    {
        /// <summary>
        /// 读取学校信息，绑定到list上
        /// </summary>
        /// <param name="rfile"></param>
        /// <param name="list"></param>
        public static void BindSchoolInfo(RFile rfile, ListBox list, string url)
        {
            IList<string> namelist = new List<string>();
            string txtnames = "";

            var tempurl = url;
            try
            {

                for (int i = 1; i < 24; i++)
                {
                    url = string.Format(tempurl, i.ToString());

                    string htmlcontent = core.WebHelper.GetDownLoadHTMLGB2312(url);
                    IProcess process = new XueXiaoHtmlProcess();
                    var resulthtml = process.Process(htmlcontent);
                    txtnames = txtnames + resulthtml;
                    var arryresult = resulthtml.Split(',');
                    foreach (string s in arryresult)
                    {
                        namelist.Add(s);

                    }

                }

            }
            catch (Exception ex)
            {

                
            }


            rfile.WriteToFile(txtnames);

            list.DataSource = namelist;
        }
        /// <summary>
        /// 读取用户账户
        /// </summary>
        /// <param name="rfile"></param>
        /// <returns></returns>
        public static List<LoginModel> ReadAccount(RFile rfile)
       {
            string s = "{user:miao,pwd:123;}";

            var accountstr = rfile.ReadFromFile();
            accountstr=SecurityHelper.DecryptDES(accountstr, ENV.PrivateKEY);
            var LoginModels = JavaScriptConvert.DeserializeObject<List<LoginModel>>(accountstr);
            return LoginModels;
           
       }
        /// <summary>
        /// 写入用户账户
        /// </summary>
        /// <param name="rfile"></param>
        /// <param name="loginModels"></param>
        public static void WriteAccount(RFile rfile,IList<LoginModel> loginModels )
        {
            string json = JavaScriptConvert.SerializeObject(loginModels);
            json = SecurityHelper.EncryptDES(json, ENV.PrivateKEY);
            rfile.WriteToFile(json);

        }
        /// <summary>
        /// 从SVN更新最新的程序所需的数据
        /// </summary>
        /// <param name="action">回调函数</param>
        public static void GetLastContentFromSVN(Action action)
        {
            var r = VCSHelper.HasRepository(ENV.GitDBLocation);
            if (!r)
            {
                var rep = VCSHelper.Clone(ENV.GitDB, ENV.GitDBLocation);
            }
            else
            {
                VCSHelper.Update(ENV.GitDBLocation);
                DirectoryHelper.MoveFolderTo(ENV.BaseDir + ENV.GitDBLocation, ENV.BaseDir + ENV.PostFiles);
                action();
            }
        }
    }
}
