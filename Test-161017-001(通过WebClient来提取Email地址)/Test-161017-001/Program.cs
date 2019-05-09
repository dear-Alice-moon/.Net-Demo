using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Test_161017_001
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  通过WebClient下载
            ////1、下载字符串
            //WebClient client = new WebClient();
            //string html = client.DownloadString("http://localhost:8080/留下你的Email.html");

            ////从html字符串中提取邮件地址
            //MatchCollection matches = Regex.Matches(html, @"[-a-zA-Z0-9_.]+@[a-zA-Z0-9]+(\.[a-zA-Z]+){1,2}");
            //foreach (Match item in matches)
            //{
            //    Console.WriteLine(item.Value);
            //}

            //Console.WriteLine("共{0}个邮箱地址。", matches.Count);
            //Console.ReadKey();


            //string s = "abcccc";
            //bool f = Regex.IsMatch(s, @"abc*?$");

            //Console.WriteLine(f);
            //Console.ReadKey();

            #endregion


            #region  提取图片

            //WebClient wb = new WebClient();

            ////1、下载html
            //string html = wb.DownloadString("http://localhost:8080//test001.html");


            ////2、提取里面的<img/>标签
            ////<img alt="" src="hotgirls/00_00.jpg" />
            //MatchCollection matches = Regex.Matches(html, @"<img\s+alt="""" src=""(.+)"" />", RegexOptions.IgnoreCase);


            ////3、通过“提取组”获取img的src属性
            //foreach (Match item in matches)
            //{
            //    Console.WriteLine(item.Value + "  " + item.Groups[1].Value);
            //    string pathImg = "http://localhost:8080/test002.html" + item.Groups[1].Value;

            //    //下载图片
            //    wb.DownloadFile(pathImg, @"d:\" + System.DateTime.Now.ToFileTime() + ".jpg");

            //}


            ////4、通过拼接路径实现下载图片
            //Console.WriteLine("OK");
            //Console.ReadKey();

            #endregion


            #region  提取超链接
            //WebClient wb = new WebClient();
            //string html = wb.DownloadString("http://localhost:8080/test003.html");
            ////<a href="www.baidu.com">baidu</a>
            //MatchCollection matches = Regex.Matches(html, @"<a\s*href="".+?"">.+?</a>", RegexOptions.IgnoreCase);

            //foreach (Match item in matches)
            //{
            //    Console.WriteLine(item.Value);
            //}

            //Console.WriteLine("OK");
            //Console.ReadKey();

            #endregion


            string s = @"""";
            Console.WriteLine(s);

            Console.ReadKey();

        }
    }
}
