using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160908_002
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, p;

            Console.WriteLine("请输入商店货品价格R!");
            r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入顾客付款P！");
            p = Convert.ToDouble(Console.ReadLine());

            while ( (r < 0) || (r > 100) || (p < 0) || (p > 100))
            {
                Console.WriteLine("输入有误，请重新输入！");
                Console.WriteLine("请输入商店货品价格R!");
                r = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("请输入顾客付款P！");
                p = Convert.ToDouble(Console.ReadLine());

            }

            JiSuanAcount(r, p);

            Console.ReadKey();

        }

        private static void JiSuanAcount(double r, double p)
        {
            int a, b, c, d;
            double s;

            s = p - r;

            if (s < 0)
            {
                Console.WriteLine("付款金额不足！");
                //return 0;
            }
            else
            {
                a = (int)(s / 50);
                b = (int)((s % 50) / 10);
                c = (int)(((s % 50) % 10) / 5);
                d = (int)((((s % 50) % 10) % 5) / 1);
                Console.WriteLine("应找{0}张50元。", a);
                Console.WriteLine("应找{0}张10元。", b);
                Console.WriteLine("应找{0}张5元。", c);
                Console.WriteLine("应找{0}张1元。", d);
            }



        }
    }
}
