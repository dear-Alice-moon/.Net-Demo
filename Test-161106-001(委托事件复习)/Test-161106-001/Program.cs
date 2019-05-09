using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_161106_001
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  复习委托
            //1、委托是一种数据类型，使用之前先要定义一个委托类型。

            //2、声明委托变量，创建委托对象。
                              //(x, y) => { return x + y; };  //使用lambda表达式代替M1函数
            //MyDelegate1 md1 = (x, y) => x + y;     //M1;  //new MyDelegate1(M1);
            //int r = md1(10, 100);
            //Console.WriteLine(r);
            //Console.ReadKey();


            //======================================
            //MyDelegate2<double> md2 = (x, y) => x + y;
            //double r = md2(10, 10);
            //Console.WriteLine(r);
            //Console.ReadKey();


            //======================================
            //MyDelegate2<int> md2 = (x, y) => x + y;  //new MyDelegate2<int>(M1);
            //int r = md2(10, 10);
            //Console.WriteLine(r);
            //Console.ReadKey();



            //======================================
            //无返回值的委托
            //Action
            //Action<string, int>

            //有返回值的委托
            //Func<int, int, int, string> fun;
             

            //=======================================
            //(x, y) => (x + y).ToString()
            //M2((x, y) => (x - y).ToString());
            //Console.ReadKey();


            //=======================================
            //Func<string, string, string> fn = M3();
            //string result = fn("你", "好");
            //Console.WriteLine(result);
            //Console.ReadKey();


            //========================================
            //MyClass mc = new MyClass();
            //mc.Md = () => { Console.WriteLine("啥都没有！"); };
            //mc.Md();
            //Console.ReadKey();


            #endregion


            #region  复习事件
            MyClass1 mc1 = new MyClass1();

            //为事件注册处理程序
            mc1.ShiJian += new Action<string>(mc1_ShiJian);
            //mc1.ShiJian += new Action<string, string>(mc1_ShiJian);
            //mc1.ShiJian();  //事件不可直接在外部调用。
            mc1.Start();  //需要调用Start函数，ShiJian(事件)才能被触发，才可被调用。
            Console.WriteLine("OK");
            Console.ReadKey();


            #endregion


        }

        //static void mc1_ShiJian(string obj, string evt)  
        static void mc1_ShiJian(string obj)  
        {
            Console.WriteLine("某某事件被触发了，事件中的消息是：{0}", obj);
            //Console.WriteLine("某某事件被触发了，事件中的消息是：{0}", obj + "\t" + evt);
        }

        static Func<string, string, string> M3() 
        {
            return new Func<string, string, string>((x, y) => x + y + "平常心");
             
        }

        static void M2(Func<int, int, string> fn)   //委托作为一个参数来表示
        {
            Console.WriteLine(fn(100, 200));
        }

        static int M1(int x, int y)   //委托作为一个方法来表示
        {
            return x + y;
        }

    }

    public delegate void MyDelegate();

    public delegate int MyDelegate1(int n, int m);

    public delegate T MyDelegate2<T>(T t1, T t2);

    public class MyClass 
    {
        public Action Md;
        //public abstract Action<T> Md2<T>();
    }

    public delegate Action<T> Md22<T>();

    public delegate Action<T> Md2<T>(T t1);

    public delegate Func<T, T, T> Md3<T>(T t1, T t2, T t3);

    public delegate T MyDelegate3<T>(T t1, T t2);

    public class MyClass1 
    {
        public event Action<string> ShiJian;
        //public event Action<string, string> ShiJian;

        public void Start() 
        {
            if (ShiJian != null)
            {
                //触发事件
                ShiJian(System.DateTime.Now.ToString());
                //ShiJian(System.DateTime.Now.ToString(), "abc");
            }
        }

    }

}
