using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160901_009
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 3, 5, 7, 90, 2, 4, 6, 8, 10 };
           //int max;

            int max = GetMax(nums);

            Console.WriteLine("数组中最大值为：{0}", max);

            Console.ReadKey();
        }

        public static int GetMax(params int[] nums) 
        {
            int max = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (max < nums[i]) 
                {
                    max = nums[i];
                }
            }
            return max;
        }

    }
}
