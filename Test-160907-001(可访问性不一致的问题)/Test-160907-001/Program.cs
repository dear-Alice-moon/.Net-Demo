using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160907_001
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    #region  1、父类与子类的访问修饰符需保持一致。
    //class Person 
    //{

    //}

    //public class Student : Person 
    //{

    //}

    #endregion


    #region  2、方法的访问修饰符需要和方法的参数的类型的访问修饰符保持一致。
    //class Person 
    //{
    //    public string Name
    //    {
    //        get;
    //        set;
    //    }
    //}

    //public class MyClass 
    //{
    //    public void SayHi(Person per) 
    //    {
    //        //return per.Name;
    //        Console.WriteLine(per.Name);
    //    }
    //}

    #endregion


    #region  3、没问题
    //class Person 
    //{

    //}

    //class MyClass 
    //{
    //    public void SayHi(Person p) 
    //    {

    //    }
    //}

    #endregion


    #region  4、方法的参数与方法的返回值都必须和方法保持一致的访问修饰符。
    //class Person 
    //{

    //}

    //public class MyClass 
    //{
    //    public Person GetPerson() 
    //    {
    //        return new Person();
    //    }
    //}

    #endregion


    #region  5、属性的返回值得和属性保持一致的访问修饰符。
    //class Person 
    //{

    //}

    //public class MyClass 
    //{
    //    public Person Friend
    //    {
    //        get;
    //        set;
    //    }
    //}


    #endregion

}
