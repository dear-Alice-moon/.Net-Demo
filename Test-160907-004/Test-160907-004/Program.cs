using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160907_004
{
    class Program
    {
        //不是所有的静态成员都必须写在静态类中
        static void Main(string[] args)
        {
            //Person h1 = new Person();
            //h1.Name = "黄林";
            //h1.Age = 18;
            //h1.Email = "h1@yahoo.com";

            //h1.Email = "huanglin@163.com";
            //Person.Planet = "地球";

            //Person my = new Person();
            //my.Name = "马毅";
            //my.Age = 17;
            //my.Email = "ma@yahoo.com";

            //Console.WriteLine(my.Email);
            //Console.WriteLine(h1.Email);
            //Console.ReadKey();

            //Class1 c = new Class1();

            Class1 c = Class1.GetObject();




        }
    }

    public class Class1 
    {
        private Class1()   //将Class1函数定义为私有方法后，不可直接创建对象。
        {

        }

        public static Class1 GetObject() 
        {
            return new Class1();
        }

    }


    public class Person 
    {
        //这三个属性都是“实例属性”
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

        public static string Planet
        {
            get;
            set;
        }


        //静态成员是属于“类”的，不是属于具体“对象”的。


    }

    static class MyClass 
    {
        //静态类中，所包含的所有成员必须都是"静态成员"
        static void M1()
        {

        }

    }



}
