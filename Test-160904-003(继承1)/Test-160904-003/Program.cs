using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160904_003
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student s1 = new Student();
            //Teacher t1 = new Teacher();
            //Person p1 = new Person();

            //Student s1 = new Student();
            //Teacher t1 = new Teacher();

            //多态： ——> 增加程序的可扩展性、灵活性
            Person p1 = new Student();

            Person p2 = new Teacher();

            Animal a1 = new Student();

            //这样做是不行！！！！
            //Teacher t1 = new Student();

            Student ss1 = (Student)new Animal();

            Student s1 = (Student)p1;
            //Student s2 = (Student)p2;  //该行语句在运行时报错，不可将Teacher类转换为Student类




            Console.ReadKey();

        }
    }

    class Animal 
    {
        public void Bark() 
        {
            Console.WriteLine("动物会吼叫。");

        }
    }

    //继承的单根性
    //"传递性"
    class Person : Animal
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

        public int Height
        {
            get;
            set;
        }

        public void Eat() 
        {
            Console.WriteLine("吃饭！");
        }

        public void Sleep() 
        {
            Console.WriteLine("睡觉！");
        }


    }

    class Student : Person
    {
        //public string Name
        //{
        //    get;
        //    set;
        //}

        //public int Age
        //{
        //    get;
        //    set;
        //}

        //public int Height
        //{
        //    get;
        //    set;
        //}

        public void SayHi() 
        {
            Console.WriteLine("Hi~~~~~~~~~");
        }

    }

    class Teacher : Person
    {
        //public string Name
        //{
        //    get;
        //    set;
        //}

        //public int Age
        //{
        //    get;
        //    set;
        //}

        //public int Height
        //{
        //    get;
        //    set;
        //}

        public double Salary
        {
            get;
            set;
        }




    }



}
