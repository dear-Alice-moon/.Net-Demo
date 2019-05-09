using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160924_001
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = {"张三 = 1800;", "李四 = 5000;", "王五 = 3000;"};

            double n1 = double.Parse(lines[0].Split(new char[] { '=', ';' })[1]);



            #region  错误代码
            //string str1 = lines[0].Split(new char[] { '=', ';' }).ToString();

            //for (int i = 0; i < str1.Length; i++)
            //{
            //    Console.WriteLine(str1[i]);
            //}

            #endregion


            Console.ReadKey();
        }
    }




}
