using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Drawing;
using System.Web;
using Captcha;

namespace EcardReportTool
{
    public class WebControl
    {
        private static WebControl _instance;
        private static HttpRequest httpRequest;
        public static string _viewstate = string.Empty;

        public string VIEWSTATE
        {
            get
            {
                return _viewstate;
            }
            set
            {
                if (value != string.Empty)
                {
                    _viewstate = value;
                }
            }
        }

        //===================================================================================
        private WebControl()
        {
            httpRequest = new HttpRequest();
        }

        //===================================================================================

        public static WebControl Instance()
        {
            if (_instance == null)
            {
                _instance = new WebControl();
            }
            return _instance;
        }

        //===================================================================================

        public void GetViewState(ReturnValue retValue)
        {
            string retVal = httpRequest.GetViewState(retValue);
            VIEWSTATE = retVal;
        }

        //===================================================================================

        public ReturnValue Get(string uri, string referer)
        {
            return httpRequest.request(uri, referer);
        }

        //===================================================================================

        public ReturnValue Post(string uri, string referer, string postData, string encoding = "UTF-8")
        {
            return httpRequest.request(uri, referer, postData, encoding);
        }

        //===================================================================================

        public static string GetVerifyCode(string picFile)
        {
            Captcha.Captcha cap = new Captcha.Captcha();
            return cap.GetCode(picFile);
        }

        public static string GetVerifyCode(Stream picStream)
        {
            Captcha.Captcha cap = new Captcha.Captcha();
            return cap.GetCode(picStream);
        }

        public static string ToString(Stream srcStream)
        {
            string retStr = string.Empty;
            using (StreamReader sr = new StreamReader(srcStream))
            {
                retStr = sr.ReadToEnd();
            }
            return retStr;
        }

        public static void Retrieve(Stream srcStream, string fileName)
        {
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                sw.Write(WebControl.ToString(srcStream));
            }
        }

        //===================================================================================

        public bool Login(string userName, string passWord, string viewState, string verifyCode, string uri = "http://ecard.efoxconn.com/login.aspx")
        {
            string loginData = string.Format(@"__VIEWSTATE={0}&tbUserName={1}&tbPassword={2}&txtVerifyCode={3}&ibLogin.x=20&ibLogin.y=14",
                                                HttpUtility.UrlEncode(viewState),
                                                HttpUtility.UrlEncode(userName),
                                                HttpUtility.UrlEncode(passWord),
                                                HttpUtility.UrlEncode(verifyCode));
            ReturnValue retVal = Post(uri, @"http://ecard.efoxconn.com", loginData);
            if (retVal.StatusCode == HttpStatusCode.Found)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// Export excel report file
        /// </summary>
        /// <param name="accountCode"></param>
        /// <param name="vendorListPath"></param>
        public void ExportExcel(string accountCode, string savePath, string vendorListPath)
        {
            string url = @"http://ecard.efoxconn.com/XF/ReporstTotal_LH.aspx";
            ReturnValue rv = Get(url, "");
            GetViewState(rv);

            using (StreamReader sr = new StreamReader(new FileStream(vendorListPath, FileMode.Open, FileAccess.Read)))
            {
                string vendor = string.Empty;
                while ((vendor = sr.ReadLine()) != null)
                {
                    string postData = string.Format("__VIEWSTATE={0}&dllCode={1}&tVendor={2}&ibExcel.x=28&ibExcel.y=5",
                                                     HttpUtility.UrlEncode(VIEWSTATE),
                                                     HttpUtility.UrlEncode(accountCode),
                                                     HttpUtility.UrlEncode(vendor));
                    ReturnValue rv2 = Post(url, url, postData);
                    string fileName = string.Format("{0}\\{1}.xls", savePath, vendor);
                    using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
                    {
                        rv2.RetStream.Position = 0;
                        byte[] data = new byte[1024];
                        int size = rv2.RetStream.Read(data, 0, data.Length);
                        while (size > 0)
                        {
                            fs.Write(data, 0, data.Length);
                            size = rv2.RetStream.Read(data, 0, data.Length);
                        }
                        rv2.RetStream.Close();
                    }
                }
            }

        }
    }

}
