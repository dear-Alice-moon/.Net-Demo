using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160908_005
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new Myclass1();
            mc.SayHi();
            Console.ReadKey();
             

        }
    }

    abstract class MyClass 
    {
        //1/抽象类中可包含实例成员。
        public int Age
        {
            get;
            set;
        }

        //2、抽象成员不能有任何实现
        public abstract void SayHi();

    }

    class Myclass1 : MyClass 
    {
        public override void SayHi()
        {
            Console.WriteLine("子类中的SayHi");
        }
    }


}
