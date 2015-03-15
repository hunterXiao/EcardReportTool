using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace EcardReportTool
{
    public class WebControl
    {
        private static WebControl _instance;
        private HttpRequest httpRequest;

        private WebControl() {
            httpRequest = new HttpRequest();
        }

        public static WebControl Instance() {
            if (_instance == null) {
                _instance = new WebControl();
            }
            return _instance;
        }

        public  bool Login(string userName,string passWord,string uri="http://ecard.efoxconn.com/login.aspx") {
            //TODO:确认登陆数据发送格式
            string loginData = string.Format(@"");
        }

    }   
    
}
