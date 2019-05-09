using _08Test;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10ConsoleApplicationTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass tc = new TestClass();
            tc.DoSomething(WriteTimeToFile);

            Console.ReadKey();
        }

        static void WriteTimeToFile() 
        {
            File.WriteAllText("time.txt", System.DateTime.Now.ToString());
        }

    }
}
