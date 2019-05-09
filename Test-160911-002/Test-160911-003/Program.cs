using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160911_003
{
    class Program
    {
        static void Main(string[] args)
        {
            ICollectHomework person = new Teacher();  //Student();

            person.Collect();



            Console.ReadKey();
        }
    }
}
