using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
namespace core
{
    public class TiebaHelper
    {
        private static LoginModel _loginModel = null;
        public static bool FillPostForm(HtmlDocument document,PostModel postModel )
        {

            try
            {
                document.GetElementById("title1").InnerText =postModel.Title;
                HtmlDocumentHelper.GetHtmlByClassName(document, "tb-editor-editarea").InnerHtml = postModel.Content;
                
                return true;
            }
            catch (Exception)
            {

                return false;
            }
           
        }

        public static bool ClickPostButton(HtmlDocument document)
        {
            try
            {
                HtmlElement htmlElement = HtmlDocumentHelper.GetInputByClassName(document, "subbtn_bg");
                htmlElement.InvokeMember("click");
                return true;
            }
            catch (Exception)
            {

                return false;
            }
         
           
        }
        /// <summary>
        /// 提交
        /// </summary>
        /// <param name="document"></param>
        /// <param name="postModel"></param>
        /// <returns></returns>
        public static bool Post(HtmlDocument document,PostModel postModel )
        {
            FillPostForm(document, postModel);
           return ClickPostButton(document);
        }

        /// <summary>
        /// 登录百度
        /// </summary>
        /// <param name="webBrowser"></param>
        /// <param name="loginModel"></param>
        public static void LoginBaidu(WebBrowser webBrowser,LoginModel loginModel)
        {
            _loginModel = loginModel;
            webBrowser.Url = new Uri(loginModel.LoginUrl);
            webBrowser.DocumentCompleted += LoginDocumentComplete;
            
        }
        /// <summary>
        /// 登录百度实现
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void LoginDocumentComplete(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
            var wb = (WebBrowser) sender;
            //if (wb.ReadyState < WebBrowserReadyState.Complete || wb.Url == e.Url) return;
            var doc = wb.Document;
            if (doc.GetElementById("TANGRAM__3__userName") == null)
            {
                wb.DocumentCompleted -= LoginDocumentComplete;
                return;
            }
            if (doc != null)
            {
                doc.GetElementById("TANGRAM__3__userName").InnerText = _loginModel.UserName;
                doc.GetElementById("TANGRAM__3__password").InnerText = _loginModel.PassWord;
                doc.GetElementById("TANGRAM__3__submit").InvokeMember("click");
                
            }
           
        }
    }
}
