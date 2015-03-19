using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Drawing;
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

        public string GetViewState(ReturnValue retValue)
        {
            string retVal = httpRequest.GetViewState(retValue);
            VIEWSTATE = retVal;
            return retVal;
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

        public static string GetVerifyCode(string picFile) {
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

        public static void Retrieve(Stream srcStream, string fileName) {
            using (StreamWriter sw = new StreamWriter(fileName)) {
                sw.Write(WebControl.ToString(srcStream));
            }
        }

        public static void RetrieveImage(Stream srcStream, string fileName)
        {
            Image image = Image.FromStream(srcStream);
            image.Save(fileName);
            srcStream.Close();
        }


        //===================================================================================

        public bool Login(string userName, string passWord, string viewState, string verifyCode, string uri = "http://ecard.efoxconn.com/login.aspx")
        {
            //TODO:确认登陆数据发送格式
            string loginData = string.Format(@"__VIEWSTATE={0}&tbUserName={1}&tbPassword={2}&txtVerifyCode={3}&ibLogin.x=20&ibLogin.y=14",
                                                viewState, userName, passWord, verifyCode);
            ReturnValue retVal = Get(uri, @"http://ecard.efoxconn.com");
            if (retVal.StatusCode == HttpStatusCode.Found)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

}
