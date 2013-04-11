using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
 

namespace core
{
   public  class HtmlDocumentHelper
    {
       public static HtmlElement GetHtmlByClassName(HtmlDocument document, string classname)
       {
           return getElement(document, classname,"div");
       }

       public static HtmlElement GetInputByClassName(HtmlDocument document, string classname)
       {
           return getElement(document, classname,"input");
       }

       private static HtmlElement getElement(HtmlDocument document, string classname,string type)
       {
           var elements = document.GetElementsByTagName(type);
           foreach (HtmlElement he in elements)
           {
               string eles = he.GetAttribute("className");

               if (eles == classname)
               {
                   return he;
               }
           }
           return null;
       }
    }
}
