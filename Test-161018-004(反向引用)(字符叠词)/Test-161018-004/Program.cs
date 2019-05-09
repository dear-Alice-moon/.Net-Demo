using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Test_161018_004
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                //杨杨杨杨杨中中中中科科科科科
                Console.WriteLine("请输入叠词：");
                //string msg = Console.ReadLine();
                string msg = "你们喜欢张张张全全全全全蛋蛋蛋蛋么么么？";
                msg = Regex.Replace(msg, @"(.)\1+", "$1");

                Console.WriteLine(msg);

                Console.WriteLine("OK");
                Console.ReadKey();
            }



        }
    }
}
