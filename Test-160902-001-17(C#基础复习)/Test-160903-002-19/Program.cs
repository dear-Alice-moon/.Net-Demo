using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160903_002_19
{
    class Program
    {
        static void Main(string[] args)
        {
            ItcastClass ic = new ItcastClass();

            ////Console.WriteLine(ic._name[0]);
            //for (int i = 0; i < ic._name.Length; i++)
            //{
            //    Console.WriteLine(ic._name[i]);
            //}

            for (int i = 0; i < ic.Count; i++)
            {
                Console.WriteLine(ic[i]);
                //ic[
            }

            //ic[0] = "sky";

            Console.ReadKey();

        }
    }
}
