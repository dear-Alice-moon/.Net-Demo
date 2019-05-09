using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_161030_003
{
    class Program
    {
        static void Main(string[] args)
        {
            //Action
            //Action<T>
            //Func<>

            //1、需要保存一个无参数，无返回值的一个方法。
            //Action action1 = new Action(M1);
            //action1();
            //Console.ReadKey();

            //2、需要保持一个有一个string类型参数，但没有返回值的方法。
            //MyDelegate md = M1;
            //md();
            //Console.ReadKey();

            //MyDelegate1 md = M1;  //个人 不需纠结M1到底是哪一个，编译器会根据初始化时调用的委托自动寻找相应的M1方法。
            //md("hello");
            //Console.ReadKey();

            //MyGenericDelegate<string> md = M1;
            //md("aaaa");
            //Console.ReadKey();

            //Action委托，其非泛型版本就是一个无参数、无返回值的委托。
            //Action的泛型版本，就是一个无返回值，但是参数可以变化的委托。
            //Action<string> a1 = m => { Console.WriteLine(m); };
            //a1("你好啊？");

            //Action<int, int> a2 = (x, y) => { Console.WriteLine(x + y); };
            //a2(100, 10);
            //Console.WriteLine(a2);

            //Console.ReadKey();

            //Func委托只有一个泛型版本的，没有非泛型版本的。
            //Func<int, int, int, int> fun = M2;
            //int n = fun(1, 2, 3);
            //Console.WriteLine(n);
            //Console.ReadKey();

            //AddDelegate2 fun = M2;
            //int x;
            //int n = fun(1, 2, out x);
            //Console.WriteLine(n);
            //Console.WriteLine(x);
            //Console.ReadKey();

            //Func<int> f = () => { return 100; };
            //int x = f();
            //Console.WriteLine(x);
            //Console.ReadKey();







        }

        static int M2(int n1, int n2, out int n3) 
        {
            n3 = 10;
            return n1 + n2 + n3;
        }

        static int M2(int n1, int n2, int n3)
        {
            return n1 + n2 + n3;
        }

        static void M1(string msg)
        {
            Console.WriteLine(msg);
        }

        static void M1() 
        {
            Console.WriteLine("Ok111");
        }

        

    }


    public delegate int AddDelegate2(int n1, int n2, out int n3);
    public delegate int AddDelegate1(params int[] arr);
    public delegate int AddDelegate(int n1, int n2, int n3);

    public delegate void MyGenericDelegate<T>(T args);

    public delegate void MyDelegate1(string msg);
    public delegate void MyDelegate();
}
