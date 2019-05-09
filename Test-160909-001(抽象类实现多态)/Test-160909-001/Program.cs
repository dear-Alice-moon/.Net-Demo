using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160909_001
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            Person p = new Student();
            p.SayHi();
            p.Standup();

        }

        //static void M1(Person p) 
        //{
        //    p.SayHi();
        //}

        //static Person M2() 
        //{

        //}


    }

    abstract class Person 
    {
        public abstract void SayHi();

        public abstract void Standup();

    }

    class Student : Person
    {
        public override void SayHi()
        {
            throw new NotImplementedException();
        }

        public override void Standup()
        {
            throw new NotImplementedException();
        }
    }
  



}
