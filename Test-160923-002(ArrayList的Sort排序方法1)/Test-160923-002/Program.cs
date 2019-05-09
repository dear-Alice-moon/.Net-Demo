using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160923_002
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  ArrayList的Sort方法
            //ArrayList arr = new ArrayList(new int[] { 1, 32, 87, 48, 2, 5 });

            ////默认Sort()方法是升序排序
            //arr.Sort();
            ////没有降序的方法，但是有一个反转的方法。
            //arr.Reverse();
            //for (int i = 0; i < arr.Count; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}


            //====================================================
            //ArrayList arrlist = new ArrayList(new string[] { "h1", "xzl", "yzk", "fxh", "sr", "yhb", "abm" });
            //arrlist.Sort();
            //for (int i = 0; i < arrlist.Count; i++)
            //{
            //    Console.WriteLine(arrlist[i]);
            //}


            //====================================================

            ArrayList arr = new ArrayList();

            Person p1 = new Person();
            //p1.Name = "cjl";
            p1.Name = "chenjinling";
            p1.Age = 19;
            p1.Email = "cjl@yahoo.com";

            Person p2 = new Person();
            //p2.Name = "zdd";
            p2.Name = "zhengdd";
            p2.Age = 18;
            p2.Email = "zdd@yahoo.com";

            Person p3 = new Person();
            //p3.Name = "zbq";
            p3.Name = "zhubq";
            p3.Age = 17;
            p3.Email = "zbp@yahoo.com";

            Person p4 = new Person();
            //p4.Name = "pdh";
            p4.Name = "pdh";
            p4.Age = 16;
            p2.Email = "pdh@yahoo.com";

            arr.Add(p1);
            arr.Add(p2);
            arr.Add(p3);
            arr.Add(p4);
            

            Console.WriteLine(arr.Count);
            //直接调用Sort()方法是使用Person类型实现了IComparable接口的默认方式来排序
            arr.Sort();

            for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine(((Person)arr[i]).Name);
            }


            Console.ReadKey();


            #endregion


        }

    }

    public class Person : IComparable
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



        public int CompareTo(object obj)
        {
            Person p = obj as Person;
            if (p != null)
            {
                //return p.Age - this.Age;  //降序
                //return this.Age - p.Age;    //升序
                //return this.Name.Length - p.Name.Length; //升序
                return p.Name.Length - this.Name.Length;  //降序

            }
            return 0;
        }
    }


}
