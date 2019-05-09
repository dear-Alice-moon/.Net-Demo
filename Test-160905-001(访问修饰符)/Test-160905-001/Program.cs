using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160905_001
{
    class Program
    {
        static void Main(string[] args)
        {
            //访问修饰符
            //public
            //internal
            //protected
            //protectec internal
            //private


        }

        //类可以使用private访问修饰符，前提是其没有直接在命名空间下。
        private class Mybook 
        {
            public void SayHi() 
            {
                Console.WriteLine("你好啊！");
            }
        }




    }
}
