using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Test_161014_003
{
    class Program
    {
        static void Main(string[] args)
        {

            #region  1、从文件路径中提取出文件名(包含后缀)  //实验未实现

            //Console.WriteLine("请输入任意文件的路径，以便提取出该文件(包含后缀名)!");
            //string msg = Console.ReadLine();

            //MatchCollection match = Regex.Matches(msg, @"^.+\.(.+)$");
            ////Console.WriteLine(match.Value);
            //foreach (Match item in match)
            //{
            //    Console.WriteLine(item.Groups[1].Value);
            //}

            //Console.WriteLine("Ok");

            //Console.ReadKey();

            #endregion

            #region  练习1，视频中老师所讲代码。

            ////Path.GetFileName
            //string path = @"D\Windows\App\test.txt";

            ////此处因为有“贪婪模式”的存在，所以正则表达式中的\\肯定匹配的是文件路径中的最后一个。
            //Match match = Regex.Match(path, @".+\\(.+)");
            //Console.WriteLine(match.Groups[1].Value);
            //Console.ReadKey();

            #endregion


            #region  练习2，自写程序，顺利实现预期目标。(^__^)
            //2、从“June         26       ,        1951    ”中
            //提取出月份June、26、1951来。
            //string msg = "June         26       ,        1951    ";
            //MatchCollection matchs = Regex.Matches(msg, @"^([a-zA-Z]+)\s*(\d{1,2})\s*,\s*(\d{4})\s*$");
            //                                             //([a-zA-Z])\s*([\d]{1,2})\s*\,\s([\d]{4})\s$  //自己第一次写时，正则匹配式有误！    
            //foreach (Match item in matchs)
            //{
            //    Console.WriteLine(item.Groups[1].Value);
            //    Console.WriteLine(item.Groups[2].Value);
            //    Console.WriteLine(item.Groups[3].Value);
            //}

            //Console.WriteLine("Ok");
            //Console.ReadKey();

            #endregion

            #region  练习2，视频中老师所讲代码。

            //string date = "June   26  ,    1995   ";
            //Match match = Regex.Match(date, @"([a-zA-Z]+)\s*(\d{2})\s*,\s*(\d{4})\s*");
            //                                //"([a-zA-Z]+)\s*([0-9]{2})\s*,\s*([0-9]{4})\s*"                                   
            //for (int i = 0; i < match.Groups.Count; i++)
            //{
            //    Console.WriteLine(match.Groups[i].Value);
            //}

            //Console.ReadKey();

            //========================================
            //string date = "June   26  ,    1995   ";
            //MatchCollection matches = Regex.Matches(date, "[a-zA-Z0-9]+");

            //foreach (Match item in matches)
            //{
            //    Console.WriteLine(item.Value);
            //}

            //Console.ReadKey();

            #endregion
            

            #region  练习3，自写程序，顺利实现预期目标。(^__^)
            //从Email中提取出用户名和域名，
            //比如从test@163.com中提取出test和163.com

            //Console.WriteLine("请输入一个合法的Email地址。");
            //string msg = Console.ReadLine();

            //MatchCollection matchs = Regex.Matches(msg, @"^([-a-zA-Z0-9_\.]+)@(([a-zA-Z0-9]+\.{1,2})([a-zA-Z]+))$");

            //foreach (Match item in matchs)
            //{
            //    Console.WriteLine(item.Groups[1].Value);
            //    Console.WriteLine(item.Groups[2].Value);
            //}

            //Console.WriteLine("Ok");
            //Console.ReadKey();

            #endregion

            #region  练习3，视频中老师所讲代码。

            //while (true)
            //{
            //    Console.WriteLine("请输入Email：");
            //    string email = Console.ReadLine();
            //    Match match = Regex.Match(email, @"([-a-zA-Z0-9._]+)@([-a-zA-Z0-9.]+[a-zA-Z]+)");
                                                   //@"(.+)@(.+)"
            //    Console.WriteLine("用户名：{0}， 域名：{1}", match.Groups[1].Value, match.Groups[2].Value);

            //}

            //Console.ReadKey();

            #endregion


            #region  练习4，自写程序，实验未成功！
            //“192.168.10.5[port=21,type=ftp]”，这个字符串表示IP地址为192.168.10.5的
            //服务器的21端口提供的是ftp服务，其中如果“,type=ftp”部分被省略，
            //则默认为http服务。请用程序解析此字符串，
            //然后打印出“IP地址为***的服务器的***端口提供的服务为***”

            //Console.WriteLine("请输入任意一个IP地址及其端口号!");
            //string msg = Console.ReadLine();
            //string s1 = null, s2 = null, s3 = null;

            //while (true)
            //{
            //    MatchCollection matchs = Regex.Matches(msg, @"((\d{1,3}\.){3}[0-9])\[(\w{4}\=(\d{1,4}))(\,\w{4}\=(\w{3}))?\]");

            //    foreach (Match item in matchs)
            //    {
            //        s1 = item.Groups[1].Value;
            //        s2 = item.Groups[4].Value;
            //        if (item.Groups[5].Value == null)
            //        {
            //            s3 = "http";
            //        }
            //        else
            //        {
            //            s3 = item.Groups[6].Value;
            //        }

            //    }

            //    Console.WriteLine("IP地址为{0}的服务器的{1}端口提供的服务为{2}", s1, s2, s3);
            //}

            //Console.ReadKey();

            #endregion

            #region  练习4，视频中老师所讲代码。

            ////string msg = "192.168.10.5[port=21,type=ftp]";
            //string msg = "192.168.10.5[port=21]";

            //Match match = Regex.Match(msg, @"(.+)\[port=([0-9]{2,5})(,type=(.+))?\]");
            //Console.WriteLine("ip：{0}", match.Groups[1].Value);
            //Console.WriteLine("port:{0}", match.Groups[2].Value);
            //Console.WriteLine("services:{0}", match.Groups[4].Value.Length == 0 ? "http" : match.Groups[4].Value);

            //Console.ReadKey();

            #endregion


        }
    }
}
