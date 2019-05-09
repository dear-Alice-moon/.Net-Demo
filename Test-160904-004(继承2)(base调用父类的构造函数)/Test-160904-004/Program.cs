using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160904_004
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student("张三", 18, 170, "001");


        }
    }

    class Person 
    {
        public Person(string name, int age, int height) 
        {
            this.Name = name;
            this.Age = age;
            this.Height = height;
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

        public int Height
        {
            get;
            set;
        }

    }

    //当一个子类继承父类以后，该子类中的所有构造函数默认情况下，在自己被
    //调用之前都会先调用一次父类的无参数构造函数，如果此时父类中没有
    //无参数的构造函数，程序运行，系统提示报错。

    class Student : Person 
    {
        //解决方法二：在子类的构造函数后面通过:base()的方式，明确指定要调用父类的那个构造函数。
        public Student(string name, int age, int height, string sid) : base(name, age, height)  //:base()表示调用父类的构造函数。  
        {                                                                                       // 构造函数不能被继承，但可调用。
            this.SId = sid;
        }

        public string SId
        {
            get;
            set;
        } 
    }

    class Teacher : Person 
    {
        public Teacher(int age, string name, string empid,int height) : base(name, age, height) 
        {
            this.EmpId = empid;
        }

        public string EmpId
        {
            get;
            set;
        }

    }

}
