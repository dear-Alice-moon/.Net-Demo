using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160913_002
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new BestStudent();
            BestStudent bs = p as BestStudent;

            if (bs != null)
            {
                Console.WriteLine("Ok");
            }

            Console.ReadKey();

        }
    }

    class Person 
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

    class Student : Person 
    {

    }

    class BestStudent : Person 
    {

    }


}
