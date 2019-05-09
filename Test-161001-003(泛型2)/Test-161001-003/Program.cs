using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_161001_003
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 5, 7, 9 };
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("================");
            ArrayList list = new ArrayList() { 5, 6, 7, 3, 89, 4 };
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("======================");
            List<int> list1 = new List<int>() { 9, 9, 9, 9, 3, 3, 3, 4};
            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("======================");
            Person p = new Person();
            //for (int i = 0; i < p.Count; i++)
            //{
            //    Console.WriteLine(p[i]);
            //}


            //其实通过foreach遍历数据，实际上时调用了一个“枚举器”来遍历数据，和foreach一点关系都没有，foreach只是一个语法上的简化而已。
            //凡是具有GetEnumerator()这个方法的类型都能使用foreach来遍历。
            //GetEnumerator
            //foreach (var item in p)
            //{
            //    Console.WriteLine(item);
            //}



            Console.ReadKey();

        }
    }

    public class Person 
    {
        private string[] name = { "hl", "xzl", "pdh", "zbq" };

        public int Count 
        {
            get 
            {
                return name.Length;
            }
        }

        public string this[int index] 
        {
            get 
            {
                return name[index];
            }
        }

        public string Name
        {
            get;
            set;
        }

        public int Age
        {
            get;
            set;
        }

        public string Email
        {
            get;
            set;
        }


    }


}
