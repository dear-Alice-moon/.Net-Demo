using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_161101_003
{
    public interface IInterface
    {
        void SayHi();

        string Name { get; set; }

        string this[int index] { get; set; }

        event Action MyEvent;

    }

    public class MyClass : IInterface
    {
        public void SayHi()
        {
            throw new NotImplementedException();
        }

        public string Name
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string this[int index]
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public event Action MyEvent;
    }




}
