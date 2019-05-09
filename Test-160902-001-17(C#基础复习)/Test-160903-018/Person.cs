using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160903_018
{
    public class Person
    {
        private string _name;
        private char _gender;
        private int _age;

        public string name 
        {
            get 
            {
                return _name;
            }
            set 
            {
                _name = value;
            }
        }

        public char Gender 
        {
            get 
            {
                return _gender;
            }
            set 
            {
                _gender = value;
            }
        }

        public int Age 
        {
            get 
            {
                return _age;
            }
            set 
            {
                _age = value;
            }
        }

        public virtual void SayHi() 
        {

            Console.WriteLine("Hi~~~~~~~");
        }

    }
}
