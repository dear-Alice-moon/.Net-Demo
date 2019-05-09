using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Test_161020_002
{
    class Program
    {
        static void Main(string[] args)
        {
            //本实验代码未能运行出来结果。
            WebClient wc = new WebClient();
            string html = wc.DownloadString("http://search.51job.com/list/000000,000000,0000,00,9,99,IT,2,1.html?lang=c&stype=1&postchannel=0000&workyear=99&cotype=99&degreefrom=99&jobterm=99&companysize=99&lonlat=0%2C0&radius=-1&ord_field=0&confirmdate=9&fromType=&dibiaoid=0&address=&line=&specialarea=00&from=&welfare=");

            //提取职位信息的超链接
            MatchCollection matches = Regex.Matches(html, "<a.+?href=\"http://jobs.51job.com/.+?/[0-9]+?.+?\"\">(.+?)</a>");    //正则表达式匹配写的不对！

            foreach (Match item in matches)
            {
                Console.WriteLine(item.Groups[1].Value);
            }

            Console.WriteLine("共{0}条", matches.Count);
            Console.ReadKey();

        }
    }
}
