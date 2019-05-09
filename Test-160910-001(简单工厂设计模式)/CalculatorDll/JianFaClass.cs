using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorDll
{
    public class JianFaClass : Calculator
    {
        public JianFaClass()
        {

        }

        public JianFaClass(double d1, double d2) : base(d1, d2) 
        {

        }

        public override double JiSuan()
        {
            return this.Number1 - this.Number2;
        }



    }
}
