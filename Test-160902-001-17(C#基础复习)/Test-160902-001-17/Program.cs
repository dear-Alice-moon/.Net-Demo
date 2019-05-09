using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace Test_160902_001_17
{
    class Program
    {
        //思路：使用switch-case语句，对输入的字符串进行字符匹配。数字0、1、2...
        //换算成汉字:零、一、二....。之后输入字符串。

        //本次实验未能成功！

        static void Main(string[] args)
        {
            #region  自写程序，实验未成功。
            //string str = Console.ReadLine();

            //for (int i = 0; i < str.Length; i++)
            //{
            //    switch (str[i]) 
            //    {
            //        case '0': str[i] = '零';
            //            break;
            //        case '1': str[i] = '一';
            //            break;
            //        case '2': str[i] = '二';
            //            break;
            //        case '3': str[i] = '三';
            //            break;
            //        case '4': str[i] = '四';
            //            break;
            //        case '5': str[i] = '五';
            //            break;
            //        case '6': str[i] = '六';
            //            break;
            //        case '7': str[i] = '七';
            //            break;
            //        case '8': str[i] = '八';
            //            break;
            //        case '9': str[i] = '九';
            //            break;
            //        default: break;

            //    }
            //}

            #endregion


            #region
            string msg = "1990年6月4日";

            msg = ConvertToDate(msg);

            Console.WriteLine(msg);
            Console.ReadKey();

            #endregion

        }

        private static string ConvertToDate(string msg)
        {
            //不能这么做，因为字符串的不可变性。
            //msg[0] = '二';
            char[] chs = msg.ToCharArray();

            #region
            for (int i = 0; i < chs.Length; i++)
            {
                switch (chs[i])
                {
                    case '0': chs[i] = '零';
                        break;
                    case '1': chs[i] = '一';
                        break;
                    case '2': chs[i] = '二';
                        break;
                    case '3': chs[i] = '三';
                        break;
                    case '4': chs[i] = '四';
                        break;
                    case '5': chs[i] = '五';
                        break;
                    case '6': chs[i] = '六';
                        break;
                    case '7': chs[i] = '七';
                        break;
                    case '8': chs[i] = '八';
                        break;
                    case '9': chs[i] = '九';
                        break;
                    default: break;
                }  //switch尾括号
            }  //for尾括号 

            #endregion

            //把一个char数组转换为字符串
            return new string(chs);

        }
    }
}
