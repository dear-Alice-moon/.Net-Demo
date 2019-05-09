using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorDll
{
    public class ChengFa : Calculator
    {
        public ChengFa() 
        {

        }

        public ChengFa(double d1, double d2) : base(d1, d2) 
        {

        }

        public override double JiSuan()
        {
            return this.Number1 * this.Number2;
        }
    }
}
