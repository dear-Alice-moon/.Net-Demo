using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160928_001
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyClass<string> mc = new MyClass<string>();
            //mc.SayHi("大家好，我叫张三三。");

            MyClass<string, int, double, string, bool, int> mc = new MyClass<string, int, double, string, bool, int>();
            mc.SayHi("你们好啊？国庆快乐！");


            Console.ReadKey();

        }
    }

    //实现泛型接口的时候有两种情况：
    //1、普通类来实现泛型接口
    public class Class2 : IFace<string>
    {
        #region  IFace<string>成员
        public string SayHi()
        {
            throw new NotImplementedException();
        }

        public void SayHello(string msg)
        {
            throw new NotImplementedException();
        }

        #endregion



    }

    //2、泛型类，实现泛型接口。
    public class Class3<U> : IFace<U>
    {
        #region  IFace<U>成员

        public U SayHi() 
        {
            throw new NotImplementedException();
        }

        public void SayHello(U msg) 
        {
            throw new NotImplementedException();
        }

        #endregion

    }


    //泛型接口
    public interface IFace<T> 
    {
        T SayHi();
        void SayHello(T msg);
    }


    //普通类中包含泛型方法
    public class Class1 
    {
        //这是一个泛型方法
        public void SayHello<T>(T msg) 
        {
            Console.WriteLine(msg);
        }
    }


    //泛型类
    public class MyClass<HL, X, V, W, Y, Z> 
    {
        public void SayHi(HL arg) 
        {
            Console.WriteLine(arg);

        }
    }


    //泛型类
    public class MyClass<T> 
    {
        public void SayHi(T arg) 
        {
            Console.WriteLine(arg);
        }

    }



}
