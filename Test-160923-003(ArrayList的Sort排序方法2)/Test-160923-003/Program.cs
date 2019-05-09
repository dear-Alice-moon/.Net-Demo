using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160923_003
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  ArrayList集合中的Sort()方法2
            //ArrayList arr = new ArrayList();

            //Person p1 = new Person();
            ////p1.Name = "cjl";
            //p1.Name = "chenjinling";
            //p1.Age = 19;
            //p1.Email = "cjl@yahoo.com";

            //Person p2 = new Person();
            ////p2.Name = "zdd";
            //p2.Name = "zhengdd";
            //p2.Age = 18;
            //p2.Email = "zdd@yahoo.com";

            //Person p3 = new Person();
            ////p3.Name = "zbq";
            //p3.Name = "zhubq";
            //p3.Age = 17;
            //p3.Email = "zbp@yahoo.com";

            //Person p4 = new Person();
            ////p4.Name = "pdh";
            //p4.Name = "pdh";
            //p4.Age = 16;
            //p2.Email = "pdh@yahoo.com";

            //arr.Add(p1);
            //arr.Add(p2);
            //arr.Add(p3);
            //arr.Add(p4);
            //arr.Add(null);

            ////Console.WriteLine(arr.Count);
            ////直接调用Sort()方法是使用Person类型实现了IComparable接口的默认方式来排序
            ////arr.Sort();

            //arr.Sort(new PersonSortByNameLengthASCII());

            //for (int i = 0; i < arr.Count; i++)
            //{
            //    Console.WriteLine(((Person)arr[i]).Name);
            //}


            //Console.ReadKey();

            #endregion

            //======================================

            ArrayList list = new ArrayList();
            list.Add("abc");
            list.Add("axy");
            list.Add("aac");
            list.Add(null);

            list.Sort();

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

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

    public class PersonSortByNameLengthASCII : IComparer
    {
        public int Compare(object x, object y)
        {
            Person p1 = x as Person;
            Person p2 = y as Person;
            if (p1 != null && p2 != null)
            {
                return p1.Name.Length - p2.Name.Length;  //升序
            }
            else
            {
                //return 0;
                throw new Exception("null无法比较。。。");
            }
        }
    }


}
