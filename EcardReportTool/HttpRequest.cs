using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Web;
using HtmlAgilityPack;


namespace EcardReportTool
{

    /// <summary>
    /// Represents the return structure of HttpWebResponse
    /// </summary>
    public struct ReturnValue
    {

        public HttpStatusCode StatusCode { get; set; }
        public Stream RetStream { get; set; }
    }
    /// <summary>
    /// Http请求类，提供GET，POST方法及Download功能
    /// </summary>
    public class HttpRequest
    {
        private static CookieContainer cookieContainer = new CookieContainer();

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
            req.AllowAutoRedirect = false;
            req.CookieContainer = cookieContainer;
        }

        public ReturnValue request(string uri, string referer)
        {
            string retStr = string.Empty;
            ReturnValue retVal = new ReturnValue();
            try
            {
                HttpWebRequest req = WebRequest.Create(uri) as HttpWebRequest;

                Init(req, referer);
                HttpWebResponse resp = req.GetResponse() as HttpWebResponse;

                int retLength = (int)resp.ContentLength;
                byte[] data = new byte[retLength];
                Stream tempStream = resp.GetResponseStream();
                tempStream.Read(data, 0, data.Length);

                MemoryStream ms = new MemoryStream();
                ms.Write(data, 0, data.Length);

                retVal.StatusCode = resp.StatusCode;
                retVal.RetStream = ms;
            }
            catch (WebException e)
            {
                if(MessageBox.Show(e.Message, "Warning", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning)==DialogResult.Abort){
                    Application.Exit();
                }
            }
            return retVal;
        }

        public ReturnValue request(string uri, string referer, string postData, string defaultEncode = "utf-8")
        {
            string retStr = string.Empty;
            ReturnValue retVal = new ReturnValue();
            Encoding encode = Encoding.GetEncoding(defaultEncode);
            try
            {
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
                retVal.StatusCode = resp.StatusCode;
                retVal.RetStream = resp.GetResponseStream();
            }
            catch (WebException e)
            {
                MessageBox.Show(e.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return retVal;
        }

        public string GetViewState(ReturnValue retVal)
        {
            string viewState = string.Empty;
            //byte[] bArray = Encoding.Default.GetBytes(retVal.RetStream);
            //MemoryStream ms = new MemoryStream(bArray);
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.Load(retVal.RetStream);
            HtmlNode node = doc.DocumentNode.SelectSingleNode("//input[@name=\"__VIEWSTATE\"]");
            if (node != null)
            {
                viewState = node.Attributes["value"].Value;
            }
            retVal.RetStream.Close();
            return viewState;
        }


    }
}
