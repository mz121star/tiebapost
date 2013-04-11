using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
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
    }
}
