using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Test_161011_003
{
    class Program
    {
        static void Main(string[] args)
        {
            //Regex.IsMatch();  //用来判断给定的字符串是否匹配某个正则表达式
            //Regex.Match();  //用来从给定的字符串中按照正则表达式的要求提取[一个]匹配的字符串
            //Regex.Matches();  //用来从给定的字符串中按照正则表达式的要求提取[所有]匹配的字符串
            //Regex.Replace();  //替换所有正则表达式匹配的字符串为另外一个字符串
            //Regex.Split();

            //030031
            //100093
            //while (true)
            //{
            //    Console.WriteLine("请输入一个字符串：");
            //    string str = Console.ReadLine();
            //    //验证给定的字符串是否为一个合法的邮政编码
            //    //注意，要想完全匹配，必须要和^、$。否则只要字符串中有一部分与给定的正则表达式匹配，
            //    //就返回true了。
            //    bool b = Regex.IsMatch(str, "^[0-9]{6}$");
            //    Console.WriteLine("给定的字符串是一个合法的邮政编码么？ {0}", b);
            //}

            ////Console.ReadKey();

            //while (true)
            //{
            //    string msg = "1\r\n1\r\n1\r\n";
            //    bool b = Regex.IsMatch(msg, "(^[0-9]$){3}");
            //    Console.WriteLine(b);
            //}

            //10-25
            while (true)
            {
                Console.WriteLine("请用户输入一个 10-25(包含10、25)之间的任何一个数字！");
                string n = Console.ReadLine();
                bool b = Regex.IsMatch(n, "^(1[0-9]|2[0-5])$");
                Console.WriteLine(b); 

            }



        }  //static void Main(string[] args)
    }
}
