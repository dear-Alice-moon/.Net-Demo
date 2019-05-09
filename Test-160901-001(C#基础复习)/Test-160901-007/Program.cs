using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160901_007
{
    class Program
    {
        //备注：本程序为半成品，其中代码有不完善的地方！
        static void Main(string[] args)
        {
            #region  求取质数，自写程序。
            //Console.WriteLine("请输入任意一个数字，以判断其是否为质数！");
            ////int n1 = string.ToString(Console.ReadLine());
            //string str = Console.ReadLine();
            //int n1 = Convert.ToInt32(str);

            //GetPrimeNumber(n1);

            //Console.ReadKey();

            #endregion


            #region  求取质数，视频中老师所讲代码。
            while (true) 
            {
                Console.WriteLine("请输入一个整数：");
                int number = Convert.ToInt32(Console.ReadLine());
                bool b = IsZhiShu(number);
                Console.WriteLine(b);

            }

            #endregion

        }


        #region  求取质数，自写程序
        //public static void GetPrimeNumber(int num) 
        //{
        //    if (num == 2) 
        //    {
        //        Console.WriteLine("{0}是质数。", num);
        //        //break;
        //    }
        //    for (int i = 2; i < num; i++)
        //    {
        //        if ((num % i) == 0)
        //        {
        //            Console.WriteLine("{0}不为质数!", num);
        //            //return 0; 
        //            break;
        //        }
        //        else
        //        {
        //            Console.WriteLine("{0}是质数。", num);
        //        }
        //    }

        //}

        #endregion


        #region  求取质数，视频中老师所讲代码。
        private static bool IsZhiShu(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        #endregion


    }
}
