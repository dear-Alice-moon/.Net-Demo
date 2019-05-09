using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160901_006
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sum;

            int sum = GetSum1();

            Console.WriteLine("1-100中所有奇数的和为：{0}", sum);

            Console.ReadKey();
        }

        public static int GetSum1() 
        {
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                if ((i % 2) != 0) 
                {
                    sum += i;
                } 
            }

            return sum;
        }


    }
}
