using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Test_161013_001
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  .Net默认使用的是Unicode匹配模式

            ////string msg = "123";  //123 　１２３
            //string msg = "１２３";  //全角字符１２３
            ////bool b = Regex.IsMatch(msg, @"\d+");  //半角、全角字符123均返回True
            //bool b = Regex.IsMatch(msg, @"\d+", RegexOptions.ECMAScript);  //半角字符返回true，全角字符返回false.
            ////bool b = Regex.IsMatch(msg, @"[0-9]+");  //半角字符返回true，全角字符返回false.

            ////bool b = Regex.IsMatch(msg, @"[0-9]+");  //这个可以准确判断是ASCII字符123，不包含unicode字符１２３,
            ////其实就是输入法中使用“全角”输出123

            //Console.WriteLine(b);
            //Console.ReadKey();


            //string msg = "abd097776_432ERWEWR__你好你好你好你好";
            //bool b = Regex.IsMatch(msg, @"^\w+$");   //返回true
            ////bool b = Regex.IsMatch(msg, @"^\w+$", RegexOptions.ECMAScript);  //返回False
            //Console.WriteLine(b);

            //Console.ReadKey();

            #endregion


            #region  判断字符串是否为正确的国内电话号码，不考虑分机。
            //010-8888888或010-88888880或010xxxxxxx            //0335-8888888或0335-88888888（区号-电话号）03358888888            //10086、10010、95595、95599、95588（5位）            //13888888888（11位都是数字）

            //while (true)
            //{
            //    Console.WriteLine("请输入：");
            //    string number = Console.ReadLine();
            //    //\d{3, 4}-?\d{7,8}
            //    //\d{5}
            //    //\d{11}
            //    //[a\-z]
            //    bool b = Regex.IsMatch(number, @"^(\d{3,4}-?\d{7,8}|\d{5})$");
            //    Console.WriteLine(b);
            //}

            #endregion


            #region  1、匹配IP地址，4段.分割的最多三位数字。

            //while (true)
            //{
            //    Console.WriteLine("请输入ip：");
            //    string ip = Console.ReadLine();
            //    bool b = Regex.IsMatch(ip, @"^([0-9]{1,3}\.){3}[0-9]{1,3}$");
            //    Console.WriteLine(b);
            //}

            #endregion


            #region  判断是否是合法的日期格式“2008-08-08”。四位数字-两位数字-两位数字 

            //while (true)
            //{
            //    Console.WriteLine("输入日期：");
            //    string date = Console.ReadLine();
            //    //bool b = Regex.IsMatch(date, @"^[0-9]{4}-[0-9]{2}-[0-9]{2}$");  //该行代码未实现预期功能

            //    //限制月份只能是1-12月
            //    //01-9
            //    //0[1-9]
            //    //1[0-2]
            //    bool b = Regex.IsMatch(date, @"^[0-9]{4}-(0[1-9]|1[0-2])-[0-9]{2}$");
            //    Console.WriteLine(b);

            //}


            #endregion


            #region  判断是否是合法的url地址。http://www.test.com/a.htm？id=3&name=aaa、
            //ftp://127.0.0.1/1.txt。字符串序列://字符串序列。
            //http、https、ftp、file、thunder、ed2k

            //while (true)
            //{
            //    Console.WriteLine("输入一个url：");
            //    string url = Console.ReadLine();
            //    //http://.............................
            //    bool b = Regex.IsMatch(url, @"^[a-zA-Z0-9]+://.+$");
            //    Console.WriteLine(b);

            //}


            #endregion


        }
    }
}
