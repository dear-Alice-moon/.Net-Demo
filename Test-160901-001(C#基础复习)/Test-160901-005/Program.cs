using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160901_005
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sum;

            int sum = GetSum();

            Console.WriteLine("1-100之间所有数的和为：{0}", sum);

            Console.ReadKey();

        }

        public static int GetSum() 
        {
            int sum = 0;

            for (int i = 1; i <= 100; i++)
            {
                sum += i;
            }

            return sum;
        }

    }
}
