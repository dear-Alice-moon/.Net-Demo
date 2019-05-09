
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Test_161007_001
{
    class Program
    {
        static void Main(string[] args)
        {
            //if (File.Exists(@"D:\我一定会学好html5.txt"))
            //{
            //    Console.WriteLine("有");
            //}
            //else
            //{
            //    Console.WriteLine("没有!");
            //}

            //Directory.Delete(@"D:\aaa");   //运行，编译器会报未在D盘找到该文件夹的异常。
            File.Delete(@"D\aaa");     //运行，编译器不会报未在D盘中找到该文件/文件夹的异常。

            Console.ReadKey();

        }
    }
}
