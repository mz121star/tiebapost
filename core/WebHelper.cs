using System;
using System.Collections.Generic;
using System.Net;
using System.Text;


namespace core
{
    public  class WebHelper
    {
        /// <summary>
        /// Base
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static string GetDownLoadHTML(string url)
        {
            WebClient wc = new WebClient();
            try
            {
               return wc.DownloadString(url);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            finally
            {
                
            }
         
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static string GetDownLoadHTMLGB2312(string url)
        {

            try
            {
                WebClient wc = new WebClient();
                wc.Encoding = System.Text.Encoding.GetEncoding("GB2312");
                return Encoding.UTF8.GetString(wc.DownloadData(url));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            finally
            {

            }
         
        }
    }
}
