using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Test_161012_001
{
    class Program
    {
        static void Main(string[] args)
        {

            #region  验证是否是合法的手机号
            //while (true)
            //{
            //    Console.WriteLine("手机号为：");
            //    string num = Console.ReadLine();

            //    //Console.WriteLine(Regex.IsMatch(num, @"^\d{11}$"));
            //    Console.WriteLine(Regex.IsMatch(num, @"^[1-9]\d{10}$"));

            //}

            #endregion


            #region  检测'|'的运算优先级别，'|'的运算级别最低！
            //while (true)
            //{
            //    Console.WriteLine("请输入：");
            //    string msg = Console.ReadLine();
            //    //Console.WriteLine(Regex.IsMatch(msg, "z|food"));
            //    //Console.WriteLine(Regex.IsMatch(msg, "(z|f)ood"));
            //    Console.WriteLine(Regex.IsMatch(msg, "^(z|food)$"));
            //}

            #endregion


            #region  判断一个字符串是不是身份证号码
            //1、长度为15或者18位的字符串，首位不能是0.
            //2、如果是15位，则全部是数字。
            //3、如果是18位，则前17位都是数字，末位可能是数字也可能是X。
            //while (true)
            //{
            //    Console.WriteLine("请输入任意一个身份证号码，以判断其是否合法。");
            //    string str = Console.ReadLine();

            //    //自写正则表达式代码
            //    //Console.WriteLine(Regex.IsMatch(str, "^[1-9][0-9]{16}[0-9xX]|[1-9][0-9]{14}$"));

            //    //视频中老师所写正则表达式代码
            //    //Console.WriteLine(Regex.IsMatch(str, @"^[1-9]\d{16}[0-9xX]|[1-9]\d{14}$"));
            //    //Console.WriteLine(Regex.IsMatch(str, @"^[1-9]\d{16}[0-9xX]$|^[1-9]\d{14}$"));
            //    Console.WriteLine(Regex.IsMatch(str, @"^[1-9][0-9]{16}[0-9xX]$|^[1-9][0-9]{14}$"));

            //}


            #endregion


            //zxh  @  itcast.cn
            //12306  @  vip.qq.comm
            //aaaa  @  sina.com.cn
            //zhangsan  @  163.com
            //li.si.abc  @  qq.com
            #region  验证是否是合法的邮箱

            while (true)
            {
                Console.WriteLine("请输入一个Email地址：");
                string email = Console.ReadLine();
                Console.WriteLine(Regex.IsMatch(email, @"^[-0-9a-zA-Z_\.]+@[a-zA-Z0-9]+(\.[a-zA-Z]+){1,2}$"));

            }


            #endregion


        }
    }
}
