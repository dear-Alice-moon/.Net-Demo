using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160909_005
{
    class Program
    {
        static void Main(string[] args)
        {
            //Duck duck = new RubberDuck();
            Duck duck = new RealDuck();

            duck.Swim();
            duck.Bark();

            Console.ReadKey();

        }
    }
}
