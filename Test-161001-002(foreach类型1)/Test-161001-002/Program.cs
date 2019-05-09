using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_161001_002
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习1：（1）、创建几个Person对象。
            //       （2）、new一个集合对象，List<Person> list ....
            //       （3）、list.Sort(ICompare<T> xx);

            List<Person> list = new List<Person>();

            //list.Add();



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


    }



}
