using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_161105_001
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 5, 7, 1, 3, 8 };  //1, 3, 5, 7, 8, 9, 2, 6, 4
            //9, 8, 7, 6, 5, 4, 3, 2, 1   //9, 2

            int x = 0, y = 0;
            if (nums.Length != 1)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    x++;
                    for (int j = 0; j < nums.Length - 1 - i; j++)
                    {
                        int temp;
                        if (nums[j]> nums[j +1])
                        {
                            temp = nums[j];
                            nums[j] = nums[j + 1];
                            nums[j + 1] = temp;
                        }  //if (nums[j]> nums[j +1])
                        y++;
                    }  //for (int j = 0; j < nums.Length - 1 - i; j++)
                }  //for (int i = 0; i < nums.Length; i++)
            }
            else
            {
                Console.WriteLine("数组中仅有1个元素，不需要循环。");
            }

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}

            Console.WriteLine("外循环次数x={0}", x);
            Console.WriteLine("内循环次数y={0}", y);
            Console.ReadKey();

        }
    }
}
