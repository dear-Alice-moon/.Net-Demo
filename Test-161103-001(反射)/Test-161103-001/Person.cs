﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_161103_001
{
    public class Person
    {
        public Person() 
        {

        }

        public Person(string name, int age, string email) 
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }


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

        public void SayHi() 
        {
            Console.WriteLine("Hello, 你好啊。");
        }

        public void SayHello(string msg) 
        {
            Console.WriteLine(msg);
        }

        public void SayHello() 
        {
            Console.WriteLine("Hi，我是SayHello的无参数重载方法。");
        }

        public int Add(int n1, int n2) 
        {
            return n1 + n2;
        }


    }

    public interface IFlyable 
    {
        void Fly();
    }

    public class Student : Person 
    {

    }

    internal class Teacher : Person 
    {

    }

    public class MyClass : IFlyable 
    {

        public void Fly()
        {
            throw new NotImplementedException();
        }

    }

    public delegate void MyDelegate();

    public struct MyStruct 
    {

    }

    struct MyStruct1
    {

    }

    public enum MyEnum 
    {

    }


}
