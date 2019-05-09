using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_161030_002
{
    class Program
    {
        static void Main(string[] args)
        {
            //匿名方法
            //匿名方法不能直接在类中定义，而是在给委托变量赋值的时候，需要
            //赋值一个方法，此时可以“现做现卖”，定义一个匿名方法传递给该委托。
            //MyDelegate md = M1;

            #region  无参数，无返回值的一个匿名方法。

            //无参数，无返回值的一个匿名方法。
            //MyDelegate md = delegate()
            //{
            //    Console.WriteLine("小鸟说早早。");
            //};
            //md();
            //Console.ReadKey();

            #endregion


            #region  无参数无返回值的方法使用(lambda)λ表达式
            //MyDelegate md = () => { Console.WriteLine("lambda表达式！！"); };
            //md();
            //Console.ReadKey();

            #endregion


            #region  有参数无返回值的匿名方法

            ////有参数无返回值的匿名方法
            //MyDelegate1 md = delegate(string msg) 
            //{
            //    Console.WriteLine("早上好" + msg);
            //};
            //md("大家好!");
            //Console.ReadKey();

            #endregion


            #region  有参数无返回值的lambda表达式
            ////lambda表达式不需要传递数据类型，因为委托已经限定了数据类型。
            //MyDelegate1 md = m => { Console.WriteLine(m); };
            //md("你好，翻译挺好。");
            //Console.ReadKey();

            #endregion


            #region  有参数，有返回值的匿名函数

            //有参数，有返回值的匿名函数
            //AddDelegate ad = delegate(int n1, int n2, int n3)
            //{
            //    return n1 + n2 + n3;
            //};
            //int n = ad(10, 15, 20);
            //Console.WriteLine(n);
            //Console.ReadKey();

            #endregion


            #region  有参数有返回值的lambda表达式
            //AddDelegate ad = (x, y, z) => { return x + y + z; };
            //int r = ad(10, 20, 30);
            //Console.WriteLine(r);
            //Console.ReadKey();

            #endregion


            //可变参数lambda表达式
            AddDelegate1 ad1 = (arr) => 
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }
                return arr.Sum();
            };
            int x = ad1(1, 2, 3, 4, 5);
            Console.WriteLine(x);
            Console.ReadKey();

        }

        static void M1() 
        {
            Console.WriteLine("Ok");
        }

        //static int M2(int n1, int n2, int n3) 
        //{
        //    return n1 + n2 + n3;
        //}

    }

    public delegate int AddDelegate1(params int[] arr);

    public delegate int AddDelegate(int n1, int n2, int n3);
    public delegate void MyDelegate1(string msg);
    public delegate void MyDelegate();

}
