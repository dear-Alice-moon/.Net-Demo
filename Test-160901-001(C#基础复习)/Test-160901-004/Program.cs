using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160901_004
{
    class Program
    {
        static void Main(string[] args)
        {
            #region   计算两个数的大小,自写程序。
            //int n1 = 8, n2 = 12;
            //int max;

            //max = GetMax(n1, n2);

            //Console.ReadKey();

            #endregion


            #region   计算多个数的大小  自写程序
            //int[] nums = { 1, 13, 5, 20, 12, 27, 25};

            //int max = GetMaxs(nums);
           
            //Console.WriteLine("数组中最大值为：{0}", max);

            //Console.ReadKey();

            #endregion


            #region  计算两个数的大小，视频中老师所讲程序。

            //Console.WriteLine("请输入两个值：");
            //int num1 = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());

            //int max = GetMaxNumber(num1, num2);

            //Console.WriteLine("最大值是：{0}", max);
            //Console.ReadKey();

            #endregion


            #region  计算多个数的大小，视频中老师所讲代码。
            int max = GetMaxNumbers(10, 30, 40, 50, 80);
            Console.WriteLine("最大值是：{0}", max);
            Console.ReadKey();

            #endregion

        }


        #region   计算两个数的大小  自写程序
        //public static int GetMax(ref int num1, ref int num2) 
        //{
        //    if( num1 > num2) 
        //    {
        //       return numl;
        //    }
        //    else 
        //    {
        //        return num2;
        //    }

        //}

        #endregion


        #region   计算两个数的大小，视频中老师所讲程序。
        //private static int GetMaxNumber(int num1, int num2)
        //{
        //    return (num1 > num2) ? num1 : num2;
        //}

        #endregion


        #region   计算多个数的大小  自写程序
        //public static int GetMaxs(params int[] num) 
        //{
        //    int max = num[0];
        //    for (int i = 1; i < num.Length; i++)
        //    {
        //        if (max < num[i]) 
        //        {
        //            max = num[i];
        //        }  //if尾括号
        //    }  //for尾括号

        //    return max; 
        //}

        #endregion


        #region   计算多个数的大小，视频中老师所讲代码。
        private static int GetMaxNumbers(params int[] pms)
        {
            int max = pms[0];
            
            for (int i = 1; i < pms.Length; i++)
			{
                if(pms[i] > max) 
                {
                    max = pms[i];
                }
			}

            return max;
        }


        #endregion

    }
}
