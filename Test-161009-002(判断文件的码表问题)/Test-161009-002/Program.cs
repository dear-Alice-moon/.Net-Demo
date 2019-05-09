using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_161009_002
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte[] byte1 = File.ReadAllBytes("1GBK.txt");
            //byte[] byte2 = File.ReadAllBytes("2GBK.txt");
            //byte[] byte3 = File.ReadAllBytes("3GBK.txt");

            //byte[] byte1 = File.ReadAllBytes("1UTF8.txt");
            //byte[] byte2 = File.ReadAllBytes("2UTF8.txt");
            //byte[] byte3 = File.ReadAllBytes("3UTF8.txt");

            //FileStream fs = new FileStream();
            FileStream fsRead = File.OpenRead("a.txt");
            File.OpenWrite("aa.txt");

            Console.ReadKey();

        }
    }
}
