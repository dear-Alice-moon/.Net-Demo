using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160903_016
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = string.Empty;
            int count = 0;
            List<string> list = new List<string>();

            do
            {
                Console.WriteLine("请输入姓名：");
                name = Console.ReadLine();
                if (name.IndexOf('王') == 0)
                {
                    count++;
                }

                list.Add(name);

            } while (name.ToLower() != "quit");

            //除去集合中的最后一个元素。
            list.RemoveAt(list.Count - 1);
            Console.WriteLine("输入学生个数为：{0}", list.Count);
            Console.WriteLine("分别是：");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            Console.WriteLine("姓王的个数是：{0}", count);

            Console.ReadKey();



        }
    }
}
