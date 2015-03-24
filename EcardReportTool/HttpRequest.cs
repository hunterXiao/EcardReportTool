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
            req.UserAgent = "Mozilla/5.0 (Windows NT 6.1; rv:32.0) Gecko/20100101 Firefox/32.0";
            req.Host = host;
            req.AllowAutoRedirect = false;
            //req.Proxy = new WebProxy("127.0.0.1:8080");
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

                Stream tempStream=resp.GetResponseStream();
                MemoryStream ms=new MemoryStream();

                byte[] data = new byte[1024];
                int size = tempStream.Read(data, 0, data.Length);

                while (size > 0)
                {
                    ms.Write(data, 0, data.Length);
                    size = tempStream.Read(data, 0, data.Length);
                }

                retVal.StatusCode = resp.StatusCode;
                retVal.RetStream = ms;
                resp.Close();
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

            try
            {
                HttpWebRequest req = WebRequest.Create(uri) as HttpWebRequest;
                Init(req, referer);
                //string encodeData = HttpUtility.UrlEncode(postData, encode);
                byte[] bs = Encoding.ASCII.GetBytes(postData);
                req.Method = "POST";
                req.ContentLength = bs.Length;
                using (Stream reqStream = req.GetRequestStream())
                {
                    reqStream.Write(bs, 0, bs.Length);
                    reqStream.Close();
                }
                HttpWebResponse resp = req.GetResponse() as HttpWebResponse;
                Stream tempStream = resp.GetResponseStream();
                MemoryStream ms = new MemoryStream();

                byte[] data = new byte[1024];
                int size = tempStream.Read(data, 0, data.Length);

                while (size > 0)
                {
                    ms.Write(data, 0, data.Length);
                    size = tempStream.Read(data, 0, data.Length);
                }

                retVal.StatusCode = resp.StatusCode;
                retVal.RetStream = ms;
                resp.Close();
            }
            catch (WebException e)
            {
                MessageBox.Show(e.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return retVal;
        }

        public string GetViewState(ReturnValue retVal)
        {
            retVal.RetStream.Position=0;
            string viewState = string.Empty;
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.Load(retVal.RetStream);
            HtmlNode node = doc.DocumentNode.SelectSingleNode("//input[@name=\"__VIEWSTATE\"]");
            if (node != null)
            {
                viewState = node.Attributes["value"].Value;
            }
            else
            {
                MessageBox.Show("__VIEWSTATE 获取失败，当前为null", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            retVal.RetStream.Close();
            return viewState;
        }


    }
}
