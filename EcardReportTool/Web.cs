using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;


namespace EcardReportTool
{
    public class Web
    {
        private  CookieContainer cookiecontainer = new CookieContainer();

        private void Init(HttpWebRequest req,string referer) {
            req.Accept = "*/*";
            req.KeepAlive = true;
            req.Referer = referer;
            req.ContentType = "application/x-www-form-urlencoded";
            req.UserAgent = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.1; Trident/5.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; InfoPath.2; .NET4.0C; .NET4.0E)";
            req.Host = "ecard.efoxconn.com";
            req.CookieContainer = cookiecontainer;
        }

        public Stream request(string uri,string referer) {
            HttpWebRequest req = WebRequest.Create(uri) as HttpWebRequest;
            Init(req, referer);
            HttpWebResponse resp = req.GetResponse() as HttpWebResponse;
            Stream retStream = resp.GetResponseStream();
            resp.Close();
            return retStream;        
        }

        public Stream request(string uri, string referer, string postData) {

            HttpWebRequest req = WebRequest.Create(uri) as HttpWebRequest;
            Init(req, referer);
            req.Method = "POST";
            byte[] bs = Encoding.ASCII.GetBytes(postData);
            req.ContentLength = bs.Length;
            using (Stream reqStream = req.GetRequestStream()) {
                reqStream.Write(bs, 0, bs.Length);
                reqStream.Close();
            }

            HttpWebResponse resp = req.GetResponse() as HttpWebResponse;
            Stream retStream = resp.GetResponseStream();
            resp.Close();
            return retStream;

        }


    }
}
