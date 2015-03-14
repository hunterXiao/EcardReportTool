using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Web;


namespace EcardReportTool
{

    /// <summary>
    /// Represents the return structure of HttpWebResponse
    /// </summary>
    public struct ReturnValue {

        public HttpStatusCode StatusCode { get; set; }
        public string RetStr { get; set; }
    }
    /// <summary>
    /// Http请求类，提供GET，POST方法及Download功能
    /// </summary>
    public class Web
    {
        private CookieContainer cookiecontainer = new CookieContainer();

        /// <summary>
        /// HttpWebRequest通用headers初始化
        /// </summary>
        /// <param name="req"></param>
        /// <param name="referer"></param>
        /// <param name="host"></param>
        private void Init(HttpWebRequest req, string referer, string host = "ecard.efoxconn.com")
        {
            req.Accept = "*/*";
            req.KeepAlive = true;
            req.Referer = referer;
            req.ContentType = "application/x-www-form-urlencoded";
            req.UserAgent = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.1; Trident/5.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; InfoPath.2; .NET4.0C; .NET4.0E)";
            req.Host = host;
            req.CookieContainer = cookiecontainer;
        }

        public ReturnValue request(string uri, string referer)
        {
            string retStr = string.Empty;
            ReturnValue retVal = new ReturnValue();
            HttpWebRequest req = WebRequest.Create(uri) as HttpWebRequest;
            Init(req, referer);
            HttpWebResponse resp = req.GetResponse() as HttpWebResponse;
            using (Stream rspStream = resp.GetResponseStream())
            {
                StreamReader sr = new StreamReader(rspStream);
                retStr = sr.ReadToEnd().ToString();
            }
            retVal.StatusCode = resp.StatusCode;
            retVal.RetStr = retStr;
            resp.Close();
            return retVal;
        }

        public ReturnValue request(string uri, string referer, string postData, string defaultEncode = "utf-8")
        {
            string retStr = string.Empty;
            ReturnValue retVal = new ReturnValue();
            Encoding encode = Encoding.GetEncoding(defaultEncode);
            HttpWebRequest req = WebRequest.Create(uri) as HttpWebRequest;
            Init(req, referer);
            string encodeData = HttpUtility.UrlEncode(postData, encode);
            byte[] bs = Encoding.ASCII.GetBytes(encodeData);
            req.Method = "POST";
            req.ContentLength = bs.Length;
            using (Stream reqStream = req.GetRequestStream())
            {
                reqStream.Write(bs, 0, bs.Length);
                reqStream.Close();
            }
            HttpWebResponse resp = req.GetResponse() as HttpWebResponse;
            using (Stream rspStream = resp.GetResponseStream())
            {
                StreamReader sr = new StreamReader(rspStream);
                retStr = sr.ReadToEnd().ToString();
            }
            retVal.StatusCode = resp.StatusCode;
            retVal.RetStr = retStr;
            resp.Close();
            return retVal;
        }


    }
}
