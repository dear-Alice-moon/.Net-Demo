using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_161011_001
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "张三|1800";
            string[] strNum = str.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < strNum.Length; i++)
            {
                Console.WriteLine(strNum[i]);
            }

            Console.ReadKey();

        }
    }
}
