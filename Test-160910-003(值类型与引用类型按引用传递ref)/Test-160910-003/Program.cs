using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160910_003
{
    class Program
    {
        static void Main(string[] args)
        {
            //int m = 100;

            ////这种传递方式其实m和n就是同一个变量的两个不同的别名。
            //M1(ref m);
            //Console.WriteLine(m);

            //=============================

            //Person my = new Person();
            //my.Name = "马毅";
            //M3(ref my);
            //Console.WriteLine(my.Name);

            //===============================
            Person p1 = new Person();
            p1.Name = "黄林";
            M2(ref p1);
            Console.WriteLine(p1.Name);
            

           
            Console.ReadKey();
        }

        static void M3(ref Person per) 
        {
            per.Name = "石国庆";

        }

        static void M2(ref Person p2) 
        {
            p2 = new Person();
            p2.Name = "许正龙";
        }

        static void M1(ref int n) 
        {
            n = n + 1;
        }

    }

    public class Person 
    {
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

    }


}
