using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160910_002
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  值类型与引用类型

            //值类型赋值的时候将栈中的数据拷贝了一个副本。
            //int n = 100;
            //int m = n;
            //m = m + 1;

            //Console.WriteLine(m);
            //Console.WriteLine(n);
            //Console.ReadKey();
//==================================================

            //Person p = new Person();
            //p.Name = "黄林";

            //Person p1 = new Person();
            ////引用类型赋值的时候是将栈中的地址拷贝了一个副本！
            //p1 = p;

            //p1.Name = "张三";

            //Console.WriteLine("p是：{0}", p.Name);

            //Console.ReadKey();

            #endregion


            #region  案例,值类型与引用类型都是值传递的情况。
            int number = 100;
            M1(number);

            Console.WriteLine(number);  //????

            //====================================


            int[] arr = { 1, 2, 3 };
            M2(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");  //?????
            }
            Console.WriteLine();
            //====================================


            int[] arr1 = new int[] { 1, 2, 3 };
            M3(arr1);
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i] + " ");  //?????
            }
            Console.WriteLine();
            //====================================


            Person h1 = new Person();
            h1.Name = "黄林";
            M4(h1);
            Console.WriteLine(h1.Name);  //????

            //===================================


            Person zdd = new Person();
            zdd.Name = "郑丹丹";
            M5(zdd);
            Console.WriteLine(zdd.Name);
            


            Console.ReadKey();

            #endregion


        }

        static void M5(Person p1) 
        {
            p1.Name = "苏坤";
            p1 = new Person();
            p1.Name = "许正龙";
        }

        static void M4(Person p) 
        {
            Person px = new Person();
            px.Name = "马毅";
            p = px;
        }

        static void M3(int[] arrArg) 
        {
            arrArg = new int[] { 9, 10, 11 };
        }

        static void M2(int[] arrArg) 
        {
            for (int i = 0; i < arrArg.Length; i++)
            {
                arrArg[i] = 2 * arrArg[i];
            }
        }
        static void M1(int m) 
        {
            m = m + 1;
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



}
