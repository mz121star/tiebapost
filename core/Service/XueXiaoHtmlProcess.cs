using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace core.Service
{
    public class XueXiaoHtmlProcess:IProcess
    {
        public string Process(string html)
        {
             
           var resulthtml= HtmlHelper.GetHtml(html, "/html/body/div[4]/div[1]/div/div[2]/div[2]/div[2]");

           var mathcs = Regex.Matches(resulthtml, "(?<=target=\"_blank\" title=\")\\w+");
            string[] result = new string[mathcs.Count];
            int i = 0;
           foreach (Match mathc in mathcs)
           {
               result[i++] = mathc.Value;
           }
            return string.Join(",", result);
        }
    }
}
