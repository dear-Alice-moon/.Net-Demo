using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Test_161014_004
{
    class Program
    {
        static void Main(string[] args)
        {
            //Regex
            //string reg = "\d";  //此时C#会认为\是一个字符串的转义符。

            ////此时运行完毕后其实就是\d
            //string reg = "\\\\d";  //此时C#会认为\是一个字符串的转义符。

            //bool b = Regex.IsMatch(@"\d", reg);    //reg ——> \\d
            //Console.WriteLine(b);
            //Console.WriteLine(reg);
            //Console.ReadKey();

            //====================================

            //bool b = Regex.IsMatch(@"\d", "\\d");
            //Console.WriteLine(b);

            Console.WriteLine("a\\\\tb");
            Console.ReadKey();

        }
    }
}
