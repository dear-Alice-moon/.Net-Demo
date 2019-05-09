using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160918_002
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  练习1， 实验成功。
            //Console.WriteLine("请输入任意字符串！");
            //string str = Console.ReadLine();

            //for (int i = str.Length - 1 ; i >= 0; i--)
            //{
            //    Console.Write(str[i]);
            //}

            //Console.ReadKey();

            #endregion


            #region  练习2，实验未做出！  //经修改后，已成功运行。
            //Console.WriteLine("请输入任意一组字符串！");
            //string strNum = Console.ReadLine();
            //string str = "my first class! ";
            //string[] strNum = str.Split();

            #region  为实现预期功能的代码
            //for (int i = 0; i < strNum.Length; i++)
            //{
            //    string[] str2 = { strNum[i].ToString() };
            //    for (int j = 0; j < (str2.Length / 2); j++)
            //    {
            //        string s = null;
            //        s = str2[j];
            //        str2[j] = str2[str2.Length - 1 - j];
            //        str2[j] = s;

            //    }
            //    //strNum[i] = new string();
            //}

            #endregion

            //for (int i = 0; i < strNum.Length; i++)
            //{
            //    char[] chs = strNum[i].ToCharArray();
            //    for (int j = 0; j < chs.Length / 2; j++)
            //    {
            //        char ch = chs[j];
            //        chs[j] = chs[chs.Length - 1 - j];
            //        chs[chs.Length - 1 - j] = ch;
            //    }
            //    strNum[i] = new string(chs);
            //}


            //for (int i = 0; i < strNum.Length; i++)
            //{
            //    Console.Write(strNum[i] + " ");
            //}

            //Console.ReadKey();

            #endregion


            #region  练习3  实验成功
            //string str = "2012年12月21日";
            //string str1 = str.Substring(4, 1);
            //string str2 = str.Substring(7, 1);
            //string str3 = str.Substring(10, 1);

            //Console.WriteLine(str1);
            //Console.WriteLine(str2);
            //Console.WriteLine(str3);

            //Console.ReadKey();

            #endregion


            #region  练习4



            #endregion


        }

        private static string MyReverse(string p) 
        {
            char[] chs = p.ToCharArray();
            for (int i = 0; i < chs.Length / 2; i++)
            {
                char ch = chs[i];
                chs[i] = chs[chs.Length - 1 - i];
                chs[chs.Length - 1 - i] = ch;
            }
            return new string(chs);

        }


    }
}
