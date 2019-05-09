using _08Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _09ConsoleApplicationTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习1
            //TestClass tc = new TestClass();
            //tc.DoSomething(PrintTimeToConsole);
            //Console.ReadKey();

            //练习2
            //TestClass tc = new TestClass();
            //string[] names = new string[] { "张三", "李四", "王五", "赵六", "钱多多" };
            //tc.ChangeStrings(names);
            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i]);
            //}
            //Console.ReadKey();

            //练习3
            TestClass tc = new TestClass();
            string[] names = new string[] { "ZhangSan", "LiSi", "WangWu", "ZhaoLiu", "QianDuoduo" };
            tc.ChangeStringsToUpper(names, ChangeToUpper);
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadKey();






        }

        static string ChangeToUpper(string str) 
        {
            return str.ToUpper();
        }

        static void PrintTimeToConsole()
        {
            Console.WriteLine(System.DateTime.Now.ToString());
        }


    }


}
