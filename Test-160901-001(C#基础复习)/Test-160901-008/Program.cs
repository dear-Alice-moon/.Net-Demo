using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160901_008
{
    class Program
    {
        //备注：本程序未能写出！！！
        static void Main(string[] args)
        {
            #region   求取1-100之间质数的和，自写程序，未能做出。(^__^)

            ////int sum = 0;
            //int sum = GetSum();

            //Console.WriteLine("1-100之间所有质数的和为：{0}", sum);

            //Console.ReadKey();

            #endregion


            #region  用方法求取1-100之间质数之和，视频中老师所讲代码。

            int r = GetZhiShuSum();
            Console.WriteLine(r);
            Console.ReadKey();

            #endregion

        }

        #region  求取1-100之间质数的和，自写程序，未能做出。(^__^)
        //public static int GetSum() 
        //{
        //    int sum = 3;
        //    for (int i = 2; i <= 100; i++)
        //    {
        //        for (int j = 1; j < i-1; j++)
        //        {
        //            if ((i % j) == 0)
        //            {
        //                break;
        //            }
        //            else 
        //            {
        //                sum += i;
        //            }
        //        }  //内for尾括号
        //    }  //外for尾括号

        //    return sum;
        //}

        #endregion


        #region  用方法求取1-100之间质数之和，视频中老师所讲代码。
        private static int GetZhiShuSum()
        {
            int sum = 0;
            for (int i = 2; i <= 100; i++)
            {
                if (IsZhiShu(i))
                {
                    sum += i;
                }
            }

            return sum;
        }

        private static bool IsZhiShu(int i)
        {
            for (int j = 2; j < i; j++)
            {
                if (i % j == 0)
                {
                    return false;
                }
            }
            return true;
        }


        #endregion

    }
}
