using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;

namespace Test_161018_005
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  练习1，实验未能实现预期目标。(^__^)
            //将"我...我我..我我我我....爱爱爱..爱..爱...你你...你..你你你..."，
            //变成"我爱你"

            string msg = "我...我我..我我我我....爱爱爱..爱..爱...你你...你..你你你...";
            //Regex.Replace(msg, @"");
            string[] strNum = Regex.Split(msg, @"\.", RegexOptions.IgnorePatternWhitespace);
            //Console.WriteLine(strNum);
            string msg2 = null;
            for (int i = 0; i < strNum.Length; i++)
            {
                msg2 += strNum[i];
            }

            msg2 = Regex.Replace(msg2, @"(.)\1+", "$1");

            Console.WriteLine(msg2);

            Console.ReadKey();

            #endregion

            #region  练习1，视频中老师所讲代码



            #endregion


            #region  练习2，实验未能实现预期目标。(^__^)  //经个人修改后实现了预期目标
            //从【英汉词典TXT格式.txt】中，提取所有的带叠词的英文单词，比如sheep、tool、
            //proof、queen、professor、zoo、eel...
            //string[] strNum = File.ReadAllLines("1.txt", Encoding.Default);
            //for (int i = 0; i < strNum.Length; i++)
            //{
            //    string[] strNum2 = strNum[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //    //在这里判断strNum2[0]中是否有叠词，如果有则输出，没有则继续。
            //    MatchCollection matches =  Regex.Matches(strNum2[0], @"[a-zA-Z]*([a-zA-Z])\1+[a-zA-Z]*");
            //    foreach (Match item in matches)
            //    {
            //        Console.WriteLine(item.Value);
            //    }

            //}

            //Console.ReadKey();

            #endregion

            #region  练习2，视频中老师所讲代码
            //string txt = File.ReadAllText("1.txt", Encoding.Default);
            //MatchCollection matches = Regex.Matches(txt, @"[a-zA-Z]*(.)\1+[a-zA-Z]*?");

            //foreach (Match item in matches)
            //{
            //    Console.WriteLine(item.Value);
            //}

            //Console.ReadKey();

            #endregion


            #region  练习3，实验未能实现预期目标。(\^_^/)  //经个人修改后实现了预期目标
            //从一段文本中提取所有的叠词：
            //（1）、“浩浩荡荡、清清白白”、...AABB
            //（2）、“如火如荼”、“愈演愈烈”、...AXAY
            //string msg = File.ReadAllText("2.txt", Encoding.Default);
            //string[] msgNum = msg.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            ////在此处判断各个msgNum[i]中是否含有叠词，如果有则输出，没有则继续循环。
            //for (int i = 0; i < msgNum.Length; i++)
            //{
            //    MatchCollection matches = Regex.Matches(msgNum[i], @"(.)\1(.)\2");
            //    foreach (Match item in matches)
            //    {
            //        Console.WriteLine(item.Value);
            //    }

            //}

            //Console.ReadKey();

            #endregion

            #region  练习3，视频中老师所讲代码

            //string txt = File.ReadAllText("2.txt", Encoding.Default);
            //MatchCollection matches = Regex.Matches(txt, @"(.)\1(.)\2");

            //foreach (Match item in matches)
            //{
            //    Console.WriteLine(item.Value);
            //}

            //Console.ReadKey();

            #endregion


        }
    }
}
