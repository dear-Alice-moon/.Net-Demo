using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Test_161018_002
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  练习1，顺利完成。(^__^)
            //234-----234--------------34------55中连续的'-'替换成一个'-'
            //string msg = "234-----234--------------34------55";

            //msg = Regex.Replace(msg, "-+", "-");

            //Console.WriteLine(msg);
            //Console.ReadKey();

            #endregion


            #region  练习2
            //将一段文本中的MM/DD/YYYY格式的日期转换为YYYY-MM-DD格式 ，
            //比如“我的生日是05/21/2010耶”转换为“我的生日是2010-05-21耶”。

            //string msg = "我的生日是05/21/2010耶我的生日是05/21/2010耶";

            //msg = Regex.Replace(msg, @"(\d{2})/(\d{2})/(\d{4})", "$3-$1-$2",  RegexOptions.ECMAScript);

            //Console.WriteLine(msg);
            //Console.ReadKey();
            #endregion


            #region  练习3
            //给一段文本中匹配到的url添加超链接，比如把http://www.test.com
            //替换为<a href="http://www.test.com"> http://www.test.com</a>。

            string msg = "给一段文本中匹配到的url添加超链接，比如把http://www.test.com替换为href=http://www.test.com 哈哈http://www.test.com";

            msg = Regex.Replace(msg, @"[a-zA-Z0-9]+://[-a-zA-Z0-9.?&=#\/_]+", "<a href=\"$0\">$0</a>");  //备注：\/的顺序不能替换。
            Console.WriteLine(msg);

            Console.ReadKey();

            #endregion


        }
    }
}
