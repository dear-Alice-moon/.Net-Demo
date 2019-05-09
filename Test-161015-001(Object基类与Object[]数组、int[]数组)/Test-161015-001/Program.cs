using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_161015_001
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 2, 45, 257, 42, 33 };
            //object[] b = (object[])arr;  //不成功！

            
            string[] str = { "fds", "acd", "ddd" };
            object[] c = str;  //成功   //原因是因为存在“逆变、协变”

            Console.WriteLine("Ok");

            Console.ReadKey();

        }
    }
}
