using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Captcha
{
    public sealed class CharModel
    {
        private Dictionary<string, string> MODEL = new Dictionary<string, string>();

        #region define a constructor that initialize class CharModel with specified values
        public CharModel() {
            MODEL.Add("2", "");
            MODEL.Add("3","");
            MODEL.Add("4", "");
            MODEL.Add("5", "");
            MODEL.Add("6", "");
            MODEL.Add("7", "");
            MODEL.Add("8", "");
            MODEL.Add("9", "");
            MODEL.Add("A", "");
            MODEL.Add("B", "");
            MODEL.Add("C", "");
            MODEL.Add("D", "");
            MODEL.Add("E", "");
            MODEL.Add("F", "");
            MODEL.Add("G", "");
            MODEL.Add("H", "");
            MODEL.Add("J", "");
            MODEL.Add("K", "");
            MODEL.Add("L", "");
            MODEL.Add("M", "");
            MODEL.Add("N", "");
            MODEL.Add("P", "");
            MODEL.Add("Q", "");
            MODEL.Add("R", "");
            MODEL.Add("S", "");
            MODEL.Add("T", "");
            MODEL.Add("U", "");
            MODEL.Add("V", "");
            MODEL.Add("W", "");
            MODEL.Add("X", "");
            MODEL.Add("Y", "");
            MODEL.Add("Z", "");
        }
        #endregion 

        public Dictionary<string, string> Model {
            get {
                return MODEL;
            }
        }

    }
}
