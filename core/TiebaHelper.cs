using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
namespace core
{
    public class TiebaHelper
    {
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
    }
}
