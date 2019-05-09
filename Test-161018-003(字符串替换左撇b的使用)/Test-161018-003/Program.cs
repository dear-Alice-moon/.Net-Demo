using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Test_161018_003
{
    class Program
    {
        static void Main(string[] args)
        {

            #region  字符串替换\b的使用 ^ $

            //string msg = "The day after tomorrow is my wedding day.The row we are looking for is .row. number 10.";

            ////\b：表示单词的边界
            ////什么叫做"单词"？[a-zA-Z0-9_]
            ////Welcome come come come hello.
            ////love evol

            ////msg = msg.Replace(@"row", "line");  //将msg中所有的字符串"row"替换成了"line"。
            //msg = Regex.Replace(msg, @"\brow\b", "line");  //将msg中所有的"row"单词替换成了"line"。
            ////msg = Regex.Replace(msg, @" row ", " line ");  //该行代码对于要实现的功能不能完全匹配。
            //Console.WriteLine(msg);
            //Console.ReadKey();


            //==========================================
            //请提取出3个字母的单词

            //string msg = "Hi, how are you ? Welcome to our country!";
            //MatchCollection matches = Regex.Matches(msg, @"\b[a-zA-Z]{3}\b", RegexOptions.IgnoreCase);

            //foreach (Match item in matches)
            //{
            //    Console.WriteLine(item.Value);
            //}

            //Console.ReadKey();


            //=============================================
            string msg = "# ## ### #### ## ### # ###.";
            //MatchCollection matches = Regex.Matches(msg, @"\b###\b");  //无任何返回
            //MatchCollection matches = Regex.Matches(msg, @"###");  //返回4个###
            MatchCollection matches = Regex.Matches(msg, @"(?<= )###(?= )");  //返回2个###

            foreach (Match item in matches)
            {
                Console.WriteLine(item.Value);
            }

            Console.ReadKey();


            #endregion


        }
    }
}
