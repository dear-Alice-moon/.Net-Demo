using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Class1;


namespace Test_161029_002
{
    class Program
    {
        static void Main(string[] args)
        {
            //this.test = 
            //Test1 t1 = new Test1();
            //Test2 = (TestDelegate) Test1;

        }

        static string Test1() 
        {
            return "这是一个测试(^__^)";
        }

        static string Test2() 
        {
            return "这是一个检验！！！";
        }

        private TestDelegate test;

    }

    public delegate string TestDelegate();

    public class MyClass 
    {

    }


}
