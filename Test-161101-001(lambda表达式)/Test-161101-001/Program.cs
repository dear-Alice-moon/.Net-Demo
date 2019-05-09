using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_161101_001
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用lambda表达式
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //IEnumerable<int> ie = list.Where(Condition);
            IEnumerable<int> ie = list.Where(x => { return x > 6; });

            foreach (var item in ie)
            {
                Console.WriteLine(item);
            }
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}
            Console.ReadKey();




        }

        static bool Condition(int x) 
        {
            return x > 6;
        }


    }




}
