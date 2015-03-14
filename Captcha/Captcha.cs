using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;

namespace Captcha
{
    public class Captcha
    {
        private readonly Dictionary<string, string> model = new CharModel().Model;
        private Bitmap bitmap = null;

        /// <summary>
        /// 从Stream对象初始化BitMap类,并返回图片验证码
        /// </summary>
        /// <param name="picStream"></param>
        /// <returns></returns>

        public string GetCode(Stream picStream)
        {
            bitmap = new Bitmap(picStream);
            string retCode = "";
            Dictionary<int, string> retDict = null;

            string pixelData = GetAreaPixel(bitmap, 10, 10, 50, 12);//参数根据实际范围确定

            //迭代字模特征值字符串与pixelDate比较，得出对应的字符
            foreach (KeyValuePair<string, string> KeyAndValue in model)
            {
                if (SubstringCount(pixelData, KeyAndValue.Value) > 1)
                {
                    retDict.Add(pixelData.IndexOf(KeyAndValue.Value), KeyAndValue.Key);
                    retDict.Add(pixelData.LastIndexOf(KeyAndValue.Value), KeyAndValue.Key);
                }
                else if (SubstringCount(pixelData, KeyAndValue.Value) == 1)
                {
                    retDict.Add(pixelData.IndexOf(KeyAndValue.Value), KeyAndValue.Key);
                }
            }

            var result = from pair in retDict orderby pair.Key select pair;

            foreach (KeyValuePair<int, string> ret in result)
            {
                retCode += ret.Value;
            }
            bitmap.Dispose();
            return retCode.Length == 0 ? "????" : retCode;

        }

        /// <summary>
        /// 从文件初始化BitMap构造类,并返回图片验证码
        /// </summary>
        /// <param name="picFile"></param>
        /// <returns></returns>
        public string GetCode(String picFile)
        {
            if (File.Exists(picFile))
            {
                bitmap = new Bitmap(picFile);
                string retCode = "";
                Dictionary<int, string> retDict = null;

                //for (int step = 0; step < 4; step++)
                //{
                //    retCode += CharMatch(GetAreaPixel(bitmap, 20 + step * 50, 20, 8, 16));
                //}

                string pixelData = GetAreaPixel(bitmap, 10, 10, 50, 12);//参数根据实际范围确定

                //迭代字模特征值字符串与pixelDate比较，得出对应的字符
                foreach (KeyValuePair<string, string> KeyAndValue in model)
                {
                    if (SubstringCount(pixelData, KeyAndValue.Value) > 1)
                    {
                        retDict.Add(pixelData.IndexOf(KeyAndValue.Value), KeyAndValue.Key);
                        retDict.Add(pixelData.LastIndexOf(KeyAndValue.Value), KeyAndValue.Key);
                    }
                    else if (SubstringCount(pixelData, KeyAndValue.Value) == 1)
                    {
                        retDict.Add(pixelData.IndexOf(KeyAndValue.Value), KeyAndValue.Key);
                    }
                }

                var result = from pair in retDict orderby pair.Key select pair;

                foreach (KeyValuePair<int, string> ret in result)
                {
                    retCode += ret.Value;
                }
                bitmap.Dispose();
                return retCode.Length == 0 ? "????" : retCode;
            }
            else
            {
                throw (new FileNotFoundException());
            }
        }

        /// <summary>
        /// 从BitMap对象中获取指定的矩形区域像素信息，并返回以“00100111”形式的字符串；
        /// </summary>
        /// <param name="srcBitmap">BitMap图片实例</param>
        /// <param name="startX">指定的矩形区域左上角X坐标</param>
        /// <param name="startY">指定的矩形区域左上角Y坐标</param>
        /// <param name="width">矩形宽度</param>
        /// <param name="height">矩形高度</param>
        /// <returns>区域内“00011110011”形式信息</returns>
        private string GetAreaPixel(Bitmap srcBitmap, int startX, int startY, int width, int height)
        {
            string retStr = "";
            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    Color color = bitmap.GetPixel(startX + i, startY + j);
                    if (color.R < 180 && color.G < 180 && color.B < 180)
                        retStr = retStr + "0";
                    else
                        retStr = retStr + "1";
                }
            }
            return retStr;
        }

        private string CharMatch(string charStr)
        {
            foreach (KeyValuePair<string, string> kw in model)
            {
                if (charStr == kw.Value)
                {
                    return kw.Key;
                }
            }
            return "?";
        }

        /// <summary>
        /// 查询字符串在另一个字符串出现的次数
        /// </summary>
        /// <param name="srcString"></param>
        /// <param name="subString"></param>
        /// <returns></returns>
        public static int SubstringCount(string srcString, string subString)
        {
            string tempString = srcString.Replace(srcString, subString);
            return (srcString.Length - tempString.Length) / subString.Length;
        }

    }
}
