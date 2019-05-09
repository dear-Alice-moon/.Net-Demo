using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160920_003
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person p = new Person();
            //p.Name = "张三";

            //Person p1 = p;

            ////p = null;


            //Console.WriteLine("//===================");
            //Console.WriteLine(p.Name);
            //Console.WriteLine(p1.Name);

            //=================================================

            Person p1 = new Person();
            Person p2 = new Person();
            Person p3 = new Person();
            Person p4 = new Person();

            Person[] pers = new Person[4];
            pers[0] = p1;
            pers[1] = p2;
            pers[2] = p3;
            pers[3] = p4;

            p1 = null;
            p2 = null;
            p3 = null;
            p4 = null;

            //垃圾回收是.net CLR自动来执行的。一般不需要手动干预。

            Console.ReadKey();

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

        public string Email
        {
            get;
            set;
        }

    }

}
