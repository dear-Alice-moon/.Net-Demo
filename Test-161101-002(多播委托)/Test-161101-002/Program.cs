using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_161101_002
{
    class Program
    {
        public delegate void MyDelegate();

        static void Main(string[] args)
        {
            #region 多播委托
            //一般第一个要使用“=”赋值，后续的方法可以使用“+=”来赋值。
            //Action<string> action = M1;
            //action += M2;
            //action += M3;
            //action += M4;
            //action += M5;
            //action -= M3;

            //action("张三");
            //Console.ReadKey();

            #endregion

            MyDelegate md = new MyDelegate(T1);
            //md();
            //md = (MyDelegate)Delegate.Combine(md, new MyDelegate(T2));  //该行代码正确
            md = (MyDelegate)Delegate.Combine(md, new MyDelegate(T2), new MyDelegate(T3));
            //md();
            Delegate[] delegates = md.GetInvocationList();
            for (int i = 0; i < delegates.Length; i++)
            {
                (delegates[i] as MyDelegate)();
            }
            Console.ReadKey();

            //Queue<MyDelegate> queue = new Queue<MyDelegate>();
            


        }

        static void T1() 
        {
            Console.WriteLine("Ok");
        }

        static void T2() 
        {
            Console.WriteLine("OOk");
        }

        static void T3() 
        {
            Console.WriteLine("第三个Ok！");
        }

        static void M1(string msg) 
        {
            Console.WriteLine(msg);
        }

        static void M2(string msg)
        {
            Console.WriteLine(msg);
        }

        static void M3(string msg)
        {
            Console.WriteLine(msg);
            Console.WriteLine("第3个方法！");
        }

        static void M4(string msg)
        {
            Console.WriteLine(msg);
        }

        static void M5(string msg)
        {
            Console.WriteLine(msg);
        }


    }
}
