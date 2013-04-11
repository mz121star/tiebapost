using System;
using System.Collections.Generic;
using System.Text;
using HtmlAgilityPack;

namespace core
{
   public class HtmlHelper
   {
       /// <summary>
       /// 通过xpath，抓取html片段
       /// </summary>
       /// <param name="htmlcontent"></param>
       /// <param name="xpath"></param>
       /// <returns></returns>
       public static string GetHtml(string htmlcontent, string xpath)
      {
          var document = new HtmlDocument();
          document.LoadHtml(htmlcontent);

          string htmlSegment = string.Empty;
          string galleryStageXpath1 = xpath;

          HtmlNode galleryStageDivNode = document.DocumentNode.SelectSingleNode(galleryStageXpath1);
          if (galleryStageDivNode != null)
          {
              //PropGalleryStage div
              htmlSegment = galleryStageDivNode.OuterHtml;
          }
          return htmlSegment; ;

      }
   }
}
