using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorDll
{
    public abstract class Calculator
    {
        public Calculator() 
        {

        }

        public Calculator(double d1, double d2) 
        {
            this.Number1 = d1;
            this.Number2 = d2;
        }


        public double Number1
        {
            get;
            set;
        }

        public double Number2
        {
            get;
            set;
        }

        public abstract double JiSuan();



    }
}
