using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160928_001
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  类型转换
            //int n = 100;
            //string s = Convert.ToString(n);
            //int m = int.Parse(s);
            //Console.ReadKey();

            #endregion

            #region  拆箱和装箱
            //int n = 100;
            //object o = n;  //发生了一次装箱
            //int m = (int)o;  //发生了一次拆箱

            //int n = 100;
            //IComparable com = n;  //装箱
            //int m = (int)com;
            //Console.WriteLine(m);
            //Console.ReadKey();


            //Person p = new Student();

            //double d = 100.9;
            //object o = d;
            //int n = (int)o;
            //Console.WriteLine(n);
            //Console.ReadKey();

            //int n = 10;
            //object o = n;
            //double d = (double)o;
            //Console.WriteLine(d);
            //Console.ReadKey();


            #endregion

            //=====================
            //int n = 100;
            //Console.WriteLine(n);  //这里调用了int参数的重载，所以没有发生装箱。
            //Console.WriteLine("黄林：{0}， 许正龙：{1}， 杨硕：{2}", 10, 11, 12);
            //Console.ReadKey();


            //========================
            //int n = 100;
            //int m = 100;
            //Console.WriteLine(n.Equals(m));
            //Console.WriteLine(object.ReferenceEquals(n, m));  //m、n是两个对象，所以结果返回一个False.
            //Console.ReadKey();

            //=======================
            //int n = 10;
            //object o = n;
            //n = 100;
            //Console.WriteLine(n + "," + (int)o);
            //Console.ReadKey();

            //string str = 5 + "sss" + 10;
            //Console.WriteLine(str);
            //Console.ReadKey();


            //=======================
            //string s = 5 + "===========" + 10;
            //Console.WriteLine(s);
            //Console.ReadKey();

            //=======================
            #region  装箱和拆箱性问题

            //ArrayList arrInt = new ArrayList();
            //Stopwatch watch = new Stopwatch();
            //watch.Start();
            //for (int i = 0; i < 10000000; i++)
            //{
            //    arrInt.Add(i);
            //}
            //watch.Stop();
            //Console.WriteLine(watch.Elapsed);
            //Console.ReadKey();



            List<int> arrInt = new List<int>();
            Stopwatch watch = new Stopwatch();
            watch.Start();
            for (int i = 0; i < 10000000; i++)
            {
                arrInt.Add(i);
            }
            watch.Stop();
            Console.WriteLine(watch.Elapsed);
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
