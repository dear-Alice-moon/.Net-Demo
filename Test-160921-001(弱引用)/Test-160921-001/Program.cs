using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160921_001
{
    class Program
    {
        static void Main(string[] args)
        {
            //弱引用
            Person p = new Person();
            WeakReference wr = new WeakReference(p);
            Console.WriteLine(".................");

            p = null;

            Console.WriteLine("=================");
            Console.WriteLine("=================");
            Console.WriteLine("=================");
            Console.WriteLine("=================");
            Console.WriteLine("=================");

            //p

            //重新使用p对象
            object o = wr.Target;
            if (o != null)
            {
                Person p1 = o as Person;
                //然后就可以使用Person对象了(这个对象还是原来的对象。)

            }


            Console.WriteLine("p就可以被垃圾回收了...........");

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
