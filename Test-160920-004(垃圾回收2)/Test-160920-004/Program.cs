using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160920_004
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  垃圾回收2

            ////GC.Collect();
            //int n = GC.MaxGeneration;
            //Console.WriteLine(n);
            //GC.Collect(0);
            //GC.Collect(1);
            //GC.Collect(2);

            //Console.ReadKey();

            #endregion

        }
    }

    public class Myclass: IDisposable 
    {
        public void Myclass() 
        {

        }

        ~Myclass()   //析构函数，也称终结函数。
        {

        }


        #region  IDisposeable成员
        public void Dispose()
        {
            //...................
            //释放非托管资源
        }
    }

}
