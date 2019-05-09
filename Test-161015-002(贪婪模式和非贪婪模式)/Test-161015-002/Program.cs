using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Test_161015_002
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  贪婪模式

            //贪婪模式
            ////1111。  11。  111。  111111。
            //string msg = "1111。  11。  111。  111111。";
            //Match match = Regex.Match(msg, ".+");
            //Console.WriteLine(match.Value);
            //Console.ReadKey();

            //终止贪婪模式
            //1111。 11。  111。  111111。      
            //string msg = "1111。 11。 111。 111111。";
            ////.+，默认按照贪婪模式来匹配，尽可能多的去匹配。
            ////当在“限定符”后使用?的时候，表示终止贪婪模式。
            ////当终止贪婪模式之后，会尽可能少的匹配。
            //Match match = Regex.Match(msg, ".+?。");  //返回1111。
            //Match match = Regex.Match(msg, ".+?");  //返回1 
            //Console.WriteLine(match.Value);
            //Console.ReadKey();

            #endregion


            //string reg = "ab??";
            //string str = "abbb";
            ////Match match = Regex.Match(str, "ab*");  //返回abbb
            ////Match match = Regex.Match(str, "ab*?");   //返回a
            //Match match = Regex.Match(str, ".*?");  //返回空字符串
            //Console.WriteLine(match.Value);

            //Console.ReadKey();


            #region  贪婪模式2
            //string msg = "1111。  11。  111。  111111。";
            //Match match = Regex.Match(msg, ".+。");  //返回msg：1111。  11。  111。  111111。
            //Console.WriteLine(match.Value);

            //Console.ReadKey();

            //============================================

            //string msg = "1111。  11。  111。  111111。";
            //Match match = Regex.Match(msg, ".+?。");  //返回：1111。
            //Console.WriteLine(match.Value);

            //Console.ReadKey();

            //=============================================

            //string msg = "1111。  11。  111。  111111。1。1。1。";
            //Match match = Regex.Match(msg, "(.+。)");  //返回msg：1111。  11。  111。  111111。1。1。1。
            //Console.WriteLine(match.Value);

            //Console.ReadKey();

            //==============================================

            //string msg = "大家好。我们是S.H.E。我是S。我是H。我是E。我是N.L.L。我是★蒋坤★。呜呜。fffff";
            ////string msg = "大家好。我们是S.H.E。我是S。我是H。我是E。我爱吃饭。我是★蒋坤★。呜呜。fffff";

            //MatchCollection matches = Regex.Matches(msg, "我是(.+?)。");
            //foreach (Match item in matches)
            //{
            //    Console.WriteLine(item.Groups[1].Value);
            //}

            //Console.ReadKey();

            #endregion


        }
    }
}
