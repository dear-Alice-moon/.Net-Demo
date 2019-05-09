using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160922_002
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList arrayList = new ArrayList();

            //Person p1 = new Person();
            //p1.Name = "马毅";
            //p1.Age = 18;
            //p1.Email = "my@yahoo.com";

            //arrayList.Add(p1);
            //arrayList.Add(99);
            //arrayList.Add("黄林");

            //Person p2 = new Person();
            //p2.Name = "马毅";
            //p2.Age = 18;
            //p2.Email = "my@yahoo.com";

            //arrayList.Add(p2);

            //arrayList.Remove(99);

            //Person p3 = new Person();
            //p3.Name = "马毅";
            //p3.Age = 18;
            //p3.Email = "my@yahoo.com";

            //p3 = p1;

            //arrayList.Remove(p3);
            //string name = new string(new char[] { '黄', '林' });
            //arrayList.Remove(name);
            //arrayList.AddRange(new int[] {1, 2, 3, 4});

            //Console.WriteLine(arrayList.Count);

            //arrayList.RemoveRange(1, 2);

            //for (int i = 0; i < arrayList.Count; i++)
            //{
            //    Console.WriteLine(arrayList[i]);
            //}

            //Console.ReadKey();


            //============代码段二分隔符=============

            ArrayList arrayList = new ArrayList();

            Person p1 = new Person();
            p1.Name = "马毅";
            p1.Age = 18;
            p1.Email = "my@yahoo.com";

            arrayList.Add(p1);
            arrayList.Add(99);
            arrayList.Add("黄林");

            Person p2 = new Person();
            p2.Name = "马毅";
            p2.Age = 18;
            p2.Email = "my@yahoo.com";

            arrayList.Add(p2);

            //Console.WriteLine(arrayList.Contains(p2));  //返回true

            string s = new string(new char[] { '黄', '林' });
            Console.WriteLine(arrayList.Contains(new char[] { '黄', '林' }));
            Console.WriteLine(arrayList.Contains(s));


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


    }

}
