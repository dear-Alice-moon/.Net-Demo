using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160912_002
{
    class Program
    {
        static void Main(string[] args)
        {



        }
    }

    public interface IF1 
    {
        void Fly();
    }

    public interface IF2 
    {
        void Swim();
    }

    public interface IF3
    {
        void Jump();
    }

    public interface ISuperMan : IF1, IF2, IF3
    {
        void Fly(string msg);
    }

    class MyClass : ISuperMan
    {
        public void Fly()
        {
            throw new NotImplementedException();
        }

        public void Swim()
        {
            throw new NotImplementedException();
        }

        public void Jump()
        {
            throw new NotImplementedException();
        }
    }
 



}
