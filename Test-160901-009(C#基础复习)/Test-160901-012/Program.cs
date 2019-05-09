using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160901_012
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  自写程序，实验成功。

            //int[] nums = { 1, 3, 5, 7, 90, 2, 4, 6, 8, 10};

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    for (int j = 0; j < nums.Length -1 -i; j++)
            //    {
            //        if (nums[j] < nums[j + 1]) 
            //        {
            //            int temp = nums[j];
            //            nums[j] = nums[j + 1];
            //            nums[j + 1] = temp;
            //        }
            //    }  //内for循环
            //}  //外for循环

            //Console.WriteLine("使用冒泡排序对数组进行升序后，数组为：");
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.Write(" {0} \t", nums[i]);
            //}

            //Console.ReadKey();

            #endregion


            #region  视频中老师讲授代码

            int[] arrInt = { 1, 3, 5, 7, 90, 2, 4, 6, 8, 10};

            for (int i = 0; i < arrInt.Length - 1; i++)
            {
                for (int j = arrInt.Length -1; j > i; j--)
                {
                    if (arrInt[j] < arrInt[j-1])
                    {
                        int temp = arrInt[j];
                        arrInt[j] = arrInt[j - 1];
                        arrInt[j - 1] = temp;
                    }
                }
            }

            for (int n = 0; n < arrInt.Length; n++)
            {
                Console.WriteLine(arrInt[n]);
            }

            Console.ReadKey();

            #endregion

        }
    }
}
