using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160920_002
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  使用string拼接字符串

            //string[] lines = File.ReadAllLines("sbtest.txt", Encoding.Default);
            //string msg = string.Empty;
            //Stopwatch watch = new Stopwatch();

            //watch.Start();
            //for (int i = 0; i < lines.Length; i++)
            //{
            //    msg += lines[i];
            //}
            //watch.Stop();

            //Console.WriteLine(watch.Elapsed);
            //Console.WriteLine("OK");

            //Console.ReadKey();

            #endregion

            #region  使用StringBuilder

            string[] lines = File.ReadAllLines("sbtest.txt", Encoding.Default);
            StringBuilder msg = new StringBuilder();
            Stopwatch watch = new Stopwatch();

            watch.Start();
            for (int i = 0; i < lines.Length; i++)
            {
                msg.Append(lines[i]);
            }
            watch.Stop();

            Console.WriteLine(watch.Elapsed);
            Console.WriteLine("OK");

            Console.ReadKey();

            #endregion

        }
    }
}
