using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160908_004
{
    class Program
    {
        static void Main(string[] args)
        {
            //object o = new object();
            //Console.WriteLine(o.ToString());

            //Person p = new Person();
            //Console.WriteLine(p.ToString());

            #region  类型转换的另一种方式
            Person p = new Student();
            //Person p = new Person();

            //通过这种方式进行类型转换时，如果转换失败则直接报异常！！
            //Student s = (Student)p;

            //进行类型转换的另一种方式
            //通过as的方式进行类型转换，即使转换失败也不会报异常，而是返回一个null.
            Student s = p as Student;
            if (s != null)
            {
                Console.WriteLine("转换成功！");
            }
            else
            {
                Console.WriteLine("转换失败！");
            }


            Console.WriteLine("Ok");
            Console.ReadKey();

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

    public class Student : Person 
    {

    }


}
