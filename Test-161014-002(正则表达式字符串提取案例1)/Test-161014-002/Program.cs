using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Test_161014_002
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  字符串提取
            //大家好呀，hello，2010年10月10日是个好日子。嗯，9494，吼吼！866.
            //string msg = "大家好呀，hello，2010年10月10日是个好日子。嗯，9494，吼吼！866.";

            //Regex.IsMatch()

            ////一般字符串提取不加^和$
            ////Regex.Match只能提取一个匹配。
            //Match match = Regex.Match(msg, "[0-9]+");
            //Console.WriteLine(match.Value);

            ////Regex.Matches()提取字符串中的所有匹配。
            //MatchCollection match = Regex.Matches(msg, "[0-9]+");
            //foreach (Match item in match)
            //{
            //    Console.WriteLine(item.Value);
            //}

            //Console.ReadKey();

            #endregion


            #region  提取html网页中的邮箱地址
            string html = File.ReadAllText("1.htm");

            //for (int i = 0; i < html.Length; i++)
            //{
            //    Console.WriteLine(html[i]);
            //}

            //从字符串中提取子字符串
            //如果想要对已经匹配的字符串再进行分组提取，就用到了“提取组”的功能。
            //通过添加()就能实现提取组
            //在正则表达式中只要出现了()就表示进行了分组。小括号既有改变优先级的作用又具有提取组的功能。
            MatchCollection matches = Regex.Matches(html, @"([-a-zA-Z0-9_]+)@([-a-zA-Z0-9_]+(\.[a-zA-Z])+)");
            foreach (Match item in matches)
            {
                //从字符串中提取子字符串
                //如果想要对已经匹配的字符串再进行分组提取，就用到了“提取组”的功能。
                //通过添加()就能实现提取组
                //在正则表达式中只要出现了()就表示进行了分组。小括号既有改变优先级的作用又具有提取组的功能。
                //Console.WriteLine(item.Value);
                Console.WriteLine("第0组：{0}", item.Groups[0].Value);
                Console.WriteLine("第1组：{0}", item.Groups[1].Value);
                Console.WriteLine("第2组：{0}", item.Groups[2].Value);
                Console.WriteLine("第3组：{0}", item.Groups[3].Value);
                Console.WriteLine("=================================");

            }

            Console.WriteLine("Ok");
            Console.WriteLine(matches.Count);

            Console.ReadKey();

            #endregion




        }
    }
}
