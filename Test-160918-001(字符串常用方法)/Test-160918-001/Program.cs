using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160918_001
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  字符串的只读性
            //string msg = "Aa我你他";
            //for (int i = 0; i < msg.Length; i++)
            //{
            //    //msg[i] = msg[i];  //该行语句错误，因为字符串中的字符为“只读”，不可对其赋值操作。
            //    Console.WriteLine(msg[i]);
            //}

            Console.ReadKey();

            #endregion


            #region  判断字符串是否为空字符串
            
            //string msg = "";
            //string msg = null;
            //if (msg == "")
            //{
                
            //}
            //if (msg == string.Empty)
            //{
                
            //}
            //if (msg.Length == 0)
            //{

            //}

            //if (msg != null)
            //{
            //    return (msg.Length == 0);
            //}
            //return true;

            //Console.ReadKey();

            #endregion


            #region  比较字符串的值是否相同
            //string s = "abc";
            //string s1 = "ABC";
            //Console.WriteLine(s == s1);
            //Console.WriteLine(s.Equals(s1));
            //Console.WriteLine(s.ToLower() == s1.ToLower());
            //Console.WriteLine(s.ToUpper().Equals(s1.ToUpper() ) );
            //Console.WriteLine(s.Equals(s1, StringComparison.CurrentCultureIgnoreCase  ) );

            //Console.ReadKey();

            #endregion


            //=================================
            char[] chs = new char[] { 'a', 'b', 'c' };
            string s = new string(chs);
            Console.WriteLine(s);
            Console.WriteLine(chs.ToString());

            Console.ReadKey();

            #region  截取字符串
            //string msg = "Welcome to our country !!!";
            //msg = msg.Substring(11, 3);
            //Console.WriteLine(msg);

            //Console.ReadKey();

            #endregion

        }
    }
}
