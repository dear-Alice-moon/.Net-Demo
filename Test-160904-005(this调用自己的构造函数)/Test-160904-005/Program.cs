using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160904_005
{
    class Program
    {
        static void Main(string[] args)
        {




        }
    }

    public class Person 
    {
        //使用this来调用本类中的其他构造函数。
        public Person(string name, int age) : this(name, age, 0, null)
        {
            this.Name = name;
            this.Age = age;
        }

        public Person(string name, int height) : this(name, 0, height, null)
        {
            this.Name = name;
            this.Height = height;
        }

        public Person(string name, string email) : this(name, 0, 0, email)
        {
            //this.Name = name;
            //this.Email = email;
        }

        public Person(string name, int age, int height) : this(name, age, height, null)
        {
            this.Name = name;
            this.Age = age;
            this.Height = height;
        }

        //public Person(string name, int age, string email)
        //{
        //    this.Name = name;
        //    this.Age = age;
        //    this.Email = email;
        //}

        public Person(string name, int age, int height, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Height = height;
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

        public int Height
        {
            get;
            set;
        }

    }
}
