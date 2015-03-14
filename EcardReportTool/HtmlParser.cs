using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using HtmlAgilityPack;
using System.Web;
using System.Net;

namespace EcardReportTool
{
   public class HtmlParser
    {

       public static string GetViewState(ReturnValue retVal) {
           byte[] bArray = Encoding.Default.GetBytes(retVal.RetStr);
           MemoryStream ms = new MemoryStream(bArray);
           HtmlDocument doc = new HtmlDocument();
           doc.Load(ms);
           HtmlNode node = doc.DocumentNode.SelectSingleNode("//input[@name=\"__VIEWSTATE\"]");
           string viewState = node.Attributes["value"].Value;
           ms.Close();
           return viewState;
       }
    }
}
