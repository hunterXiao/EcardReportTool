using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using HtmlAgilityPack;

namespace EcardReportTool
{
   public class HtmlParser
    {
       static string VIEWSTATE = string.Empty;


       public static string GetViewState(Stream httpStream) {
           HtmlDocument doc = new HtmlDocument();
           doc.Load(httpStream);

       }
    }
}
