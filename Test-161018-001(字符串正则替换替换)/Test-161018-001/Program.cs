using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Test_161018_001
{
    class Program
    {
        static void Main(string[] args)
        {

            #region  字符串替换
            //===========================================
            //string msg = "你aaaa好aa啊aaaaa？";
            ////msg = Regex.Replace(msg, "[a-z]+", "A");   //该行代码正确
            //msg = Regex.Replace(msg, "a", "A");

            //Console.WriteLine(msg);

            //Console.ReadKey();


            //string msg = "你aaaa好aa啊aaaaa？";
            //msg = Regex.Replace(msg, "a+", "A");

            //Console.WriteLine(msg);

            //Console.ReadKey();


            //==============================
            ////将hello 'Welcome' to 'China'  替换成：hello 【welcome】 to 【China】
            ////hello 【welcome】 to 【China】
            //string msg = "hello 'Welcome' to 'China'  'lss' 'ls'   'szj'    ";

            //msg = Regex.Replace(msg, @"'(.+?)'", "【$1】");
            //Console.WriteLine(msg);

            //Console.ReadKey();


            //===============隐藏手机号码=============
            //string msg = "张三三15012456021李四18045612345王二狗87345014611赵六六94124562055";

            //msg = Regex.Replace(msg, @"([0-9]{3})[0-9]{4}([0-9]{4})", "$1****$2");

            //Console.WriteLine(msg);
            //Console.ReadKey();


            //============隐藏邮箱名==========
            //string msg = "我的邮箱zxh@itcast.cn他的邮箱***@itcast.cn邮箱steve_zhao@163.com";
            //msg = Regex.Replace(msg, @"\w+(@\w+\.\w+)", RegexOptions.ECMAScript);
            //Console.WriteLine(msg);
            //Console.ReadKey();


            #endregion


        }
    }
}
