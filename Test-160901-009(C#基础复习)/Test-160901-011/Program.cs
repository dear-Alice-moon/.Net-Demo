using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160901_011
{
    class Program
    {
        //备注；本次实验未能成功！加油
        static void Main(string[] args)
        {
            #region  自写程序，实验未能实现。
            //int[] nums = { 1, 3, 5, 7, 90, 2, 4, 6, 8, 10};
            //int sum;
            //double avg;

            //sum = (int)GetSum(nums);


            ////Console.WriteLine("数组的平均值为：{0:0.00}", (sum / nums.Length));

            //Console.ReadKey();

            #endregion


            #region  视频中老师所讲代码
            int[] arrInt = { 1, 3, 5, 7, 90, 2, 4, 6, 8, 10, 1};
            double avg = GetAvg(arrInt);

            Console.WriteLine("平均值为：{0}", avg);

            Console.ReadKey();

            #endregion

        }

        #region  自写程序，实验未能实现。
        //public static double GetSum(int[] nums) 
        //{
        //    //double avg = 0;
        //    int sum = nums[0];

        //    for (int i = 1; i < nums.Length; i++)
        //    {
        //        sum += nums[i];
        //    }

        //    //avg = temp

        //    return sum;
        //}

        #endregion


        #region  视频中老师所讲代码
        private static double GetAvg(int[] arrInt)
        {
            int sum = 0;

            for (int i = 0; i < arrInt.Length; i++)
            {
                sum += arrInt[i];
            }

            return Math.Round( sum / (double)arrInt.Length, 2);
        }

        #endregion

    }
}
