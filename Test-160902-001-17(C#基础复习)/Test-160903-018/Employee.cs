using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160903_018
{
    public class Employee : Person
    {
        public double Salary
        {
            get;
            set;
        }

        public override void SayHi()
        {
            Console.WriteLine("员工的sayHi~~~~");
        }


    }
}
