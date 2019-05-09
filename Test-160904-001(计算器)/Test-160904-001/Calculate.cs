using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160904_001
{
    public class Calculate
    {
        public Calculate(double d1, double d2) 
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

        //封装加法
        public double Add() 
        {
            return Number1 + Number2;
        }

        //封装减法
        public double Sub()
        {
            return Number1 - Number2;
        }

        public double Mul()
        {
            return Number1 * Number2;
        }

        public double Div()
        {
            return Number1 / Number2;
        }

    }
}
