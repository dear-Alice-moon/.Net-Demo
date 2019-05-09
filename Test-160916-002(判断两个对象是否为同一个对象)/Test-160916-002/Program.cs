using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160916_002
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  代码块1
            //Person p1 = new Person();
            //p1.Name = "张三";
            //p1.Age = 18;

            //Person p2 = new Person();
            //p2.Name = "张三";
            //p2.Age = 18;

            //Person p3 = p1;

            //bool b1 = p1.Equals(p2);
            //bool b2 = p1.Equals(p3);
            ////Console.WriteLine(b1);
            ////Console.WriteLine(b2);

            //if (p1 == p2)  
            //{
            //    Console.WriteLine(true);
            //}
            //else
            //{
            //    Console.WriteLine(false);
            //}

            ////判断两个对象是否为同一个对象
            //Console.WriteLine(object.ReferenceEquals(p1, p2));
            //Console.WriteLine(object.ReferenceEquals(p1, p3));

            #endregion

            #region  代码块1.1
            Person p1 = new Person();
            p1.Name = "黄林";
            p1.Age = 18;
            p1.Email = "h1@yahoo.com";

            Person p2 = new Person();
            p2.Name = "黄林";
            p2.Age = 18;
            p2.Email = "h1@yahoo.com";

            Console.WriteLine(p1 == p2);
            Console.WriteLine(p1.Equals(p2));

            Console.WriteLine(object.ReferenceEquals(p1, p2));

            #endregion

            #region  代码块2
            //这个两个是s1、s2是两个不同的对象，因为new了两次，在堆中确实存在两块不同的内存。
            //string s1 = new string(new char[] { 'a', 'b', 'c' });
            //string s2 = new string(new char[] { 'a', 'b', 'c' });

            ////下面的s1和s2确实是同一个对象。
            ////string s1 = "abc";
            ////string s2 = "abc";

            //Console.WriteLine(s1 == s2);
            //Console.WriteLine(s1.Equals(s2));
            //Console.WriteLine(object.ReferenceEquals(s1, s2));


            #endregion

            Console.ReadKey();
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

        //public override bool Equals(object obj)
        //{
        //    Person p = obj as Person;
        //    if (p == null)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        if (this.Name == p.Name && this.Age == p.Age && this.Email == p.Email)
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //}  //public override bool Equals(object obj)

        //public static bool Equals(Person p1, Person p2) 
        //{
        //    if (p1 == null || p2 == null)
        //    {
        //        return false;
        //    }
        //    if (p1.Name == p2.Name && p1.Age == p2.Age && p1.Email == p2.Email)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        //public static bool operator ==(Person a, Person b) 
        //{
        //    return Equals(a, b);
        //}

        //public static bool operator !=(Person a, Person b) 
        //{
        //    return !Equals(a, b);
        //}


    }


}
