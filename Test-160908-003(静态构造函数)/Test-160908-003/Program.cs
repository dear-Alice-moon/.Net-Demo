using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160908_003
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();

            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            MyClass.n1 = 1000;
            MyClass.name = "马毅";
            Console.WriteLine(MyClass.n1);
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

        public static string Sid = "0001";

        public static int Weight;


    }

    public class MyClass 
    {
        public MyClass() 
        {
            Console.WriteLine("=======实例构造函数被执行啦！！！=====");
        }

        static MyClass() 
        {
            Console.WriteLine("静态构造函数被执行了！");
            n1 = 100;
            name = "黄林";     
        }

        public static int n1;

        public static string name;


    }

}
