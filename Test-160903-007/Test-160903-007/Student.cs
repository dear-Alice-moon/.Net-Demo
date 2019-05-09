using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160903_007
{
    public class Student
    {
        //定义一个类以后，不写构造函数，程序会有一个默认的无参构造函数。

        //当为类手动编写一个构造函数后，会覆盖默认的构造函数。
        public Student() 
        {

        }

        public Student(string name, int age, string gender, string sid) 
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.SId = sid;
        }

        public void A() 
        {
            new Student();
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

        public string Gender
        {
            get;
            set;
        }

        public string SId
        {
            get;
            set;
        }

        public void SayHi() 
        {
            Console.WriteLine("hi!!");
        }



    }
}
