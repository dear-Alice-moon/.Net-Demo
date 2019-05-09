using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_161130_002.xxx.aaa;

namespace Test_161130_002
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> list = new List<int>();
            //list.Add(10);
            //list.Add(11);
            //list.Add(12);

            ////list.Concat;

            #region  自己写一个扩展方法

            //Person p = new Person();
            //p.Name = "杨硕";
            //p.SayHello();
            //Console.WriteLine("OK");
            //Console.ReadKey();
            
            //==================================

            string s = "大家好";
            //扩展方法只是看起来像是某个对象的方法，但实际上根本不是该
            //对象的方法，实际上就是调用了某个静态类中的方法。

            //虽然扩展方法看起来像某个类型的方法，但实际上完全不是这个类的方法。
            int n = s.GetCount();



            //Console.WriteLine(n);
            //Console.ReadKey();

            #endregion



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

    namespace xxx.aaa 
    {
        //1、扩展方法第一步:先定义一个静态类
        public static class PersonExt
        {
            public static int GetCount(this string msg)
            {
                //在扩展方法中，无法访问类型中的那些私有成员。
                return msg.Length;
            }

            public static int GetCount(this string msg, string s1, int n2)
            {
                //在扩展方法中，无法访问类型中的那些私有成员。
                return msg.Length;
            }

            public static void SayHello(this Person p)
            {
                Console.WriteLine(p.Name);
                Console.WriteLine("Hi~~~,你好啊。");
            }
        }
    }


    


}
