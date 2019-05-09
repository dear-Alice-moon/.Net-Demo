using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160907_003
{
    class Program
    {
        static void Main(string[] args)
        {
            ParentClass a = new A();
            a.M1();  //爷爷类中的M1
            //((A)a).M1();  //A类中的M1

            Console.ReadKey();

        }
    }

    class ParentClass 
    {
        public virtual void M1() 
        {
            Console.WriteLine("爷爷类中的M1");
        }
    }

    class A : ParentClass 
    {
        //这个表示子类全新的添加了一个M1方法,为什么可以添加一个可以
        //和M1方法中一模一样的方法呢？因为这里用了new关键字，将从父类中
        //继承下来的那个M1方法给隐藏掉了。所以此时，这个类中只有一个M1方法。
        //通过this.M1()调用的一定是子类中的全新的这个M1方法，但是如果通过
        //base.M1()则调用的是父类中原来的那个M1方法。
        public new void M1() 
        {
            Console.WriteLine("A类中的M");
        }
    }

    class B : A 
    {
        //public override void M1() 
        //{
        //    Console.WriteLine("B类中的M1");
        //}
    }



}
