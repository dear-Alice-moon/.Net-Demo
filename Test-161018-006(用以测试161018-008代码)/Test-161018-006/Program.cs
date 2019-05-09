using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Test_161018_006
{
    class Program
    {
        static void Main(string[] args)
        {
            //1、替换【】
            string msg = "【你好，我发现一个[b]新网站[/b]，[b]大家[/b]来看呀[url=http://www.qq.com]秋秋[/url]，另外一个有时间也可以看看[url=http://www.rupeng.com]如鹏[/url]，还有[url=http://www.itcast.cn]传智播客[/url]】。吼吼！<b></b>";
            msg = Regex.Replace(msg, @"\【(.+)\】", "$1");
            //Console.WriteLine(msg);
            //2、替换[b][/b]
            msg = Regex.Replace(msg, @"\[b\](.+?)\[/b\]", "<b>$1</b>");
            //Console.WriteLine(msg);
            //3、替换[url][/url]
            msg = Regex.Replace(msg, @"\[url(.+?)\](.+?)\[/url\]", "<url$1>$2</url>");
            Console.WriteLine(msg);

            Console.ReadKey();
        }
    }
}
