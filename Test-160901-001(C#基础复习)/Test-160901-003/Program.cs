using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160901_003
{
    class Program
    {
        static void Main(string[] args)
        {
            //请用户输入一个字符串，计算字符串中的字符个数，并输出。

            Console.WriteLine("请输入任意个数的字符！");
            string str = Console.ReadLine();

            //int n1 = str.Length;

            Console.WriteLine("输入的字符串个数为:{0}", str.Length);

            Console.ReadKey();
        }
    }
}
