using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160908_001
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("请输入三个整数：");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());

            while (a < 0 || b < 0 || c < 0 || a > 200 || b > 200 || c > 200) 
            {
                Console.WriteLine("输入有误，请重新输入！");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                c = Convert.ToInt32(Console.ReadLine());
            }

            SanJiaoShip(a, b, c);

            Console.ReadKey();

        }

        private static void SanJiaoShip(int a, int b, int c)
        {
            if ((a + b > c) && (a + c > b) && (b + c > a))
            {
                if ((a == b) && (a == c))
                {
                    Console.WriteLine("根据输入的数据，判断其为等边三角形！");
                }
                else if ((a == b) || (a == c) || (b == c))
                {
                    Console.WriteLine("根据输入的数据，判断其为等腰三角形！");
                }
                else
                {
                    Console.WriteLine("根据输入的数据，判断其为一般三角形！");
                }
            }  //if ((a + b > c) && (a + c > b) && (b + c > a))
            else 
            {
                Console.WriteLine("无法构成三角形！");
            }  //if ((a + b > c) && (a + c > b) && (b + c > a))

        }

    }
}
