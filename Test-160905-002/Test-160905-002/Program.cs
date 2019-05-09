using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160905_002
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("张三", 18, "zs@163.com");
            s1.SayHi();
            Console.ReadKey();


        }
    }

    public class Person 
    {
        private string _name;
        private int _age;
        private string _email;

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

        public Person() 
        {
            this.Name = "黄玲";
        }

        public Person(string name, int age, string email) 
        {
            this.Name = _name;
            this.Age = _age;
            this.Email = _email;
        }

    }  //Person类的尾括号


    public class Student : Person 
    {
        private string _sid;

        public string Sid
        {
            get;
            set;
        }

        public Student(string name, int age, string email) 
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public void SayHi() 
        {
            Console.WriteLine(this.Name);  // 程序运行结果为“张三”
            //Console.WriteLine(this.Email);

            Console.WriteLine(base.Name);  // 程序运行结果为“张三”
            Console.WriteLine(base.Email);

        }

    }  //Stuendt类的尾括号



}
