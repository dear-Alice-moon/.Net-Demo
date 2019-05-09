using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160903_007
{
    public class Teacher
    {
        public Teacher(string name) 
        {
            this.Name = name;
        }

        public string Name
        {
            get;
            set;
        }

        public void SayHello() 
        {
            Console.WriteLine("hello! ");
        }


    }
}
