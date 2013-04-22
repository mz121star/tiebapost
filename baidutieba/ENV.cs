using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace baidutieba
{
   public class ENV
    {
       /// <summary>
       /// 百度贴吧的URl地址
       /// </summary>
        public static string TieBaUrl
        {
            get { return ConfigurationManager.AppSettings["TieBaUrl"]; }
        }
       /// <summary>
        /// 贴吧用户的地址，通过该地址可查看用户的发帖纪录 
       /// </summary>
        public static string TieBaUser
        {
            get { return ConfigurationManager.AppSettings["TieBaUser"]; }
        }
        /// <summary>
        /// 百度登录地址
        /// </summary>
       public  static  string BaiduLoginUrl
       {
           get { return ConfigurationManager.AppSettings["BaiduLoginUrl"]; }
       }
        public static bool ReplaceAllImages
        {
            get { return Boolean.Parse(ConfigurationManager.AppSettings["ReplaceAllImages"]); }
        }
    }
}
