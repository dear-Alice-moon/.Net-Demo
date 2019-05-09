using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160901_002
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.用方法来实现：将上题封装一个方法来做，方法有两个参数分别为num1,num2,
            //将num1与num2交换。提示：方法有两个参数n1,n2,在方法中将n1与n2进行交换，使用ref。（*）


            int n1 = 10, n2 = 20;

            Change(ref n1, ref n2);

            Console.WriteLine("n1, n2交换后的值为{0}、{1}", n1, n2);

            Console.ReadKey();
        }

        public static void Change(ref int num1, ref int num2) 
        {
            num1 = num1 - num2;
            num2 = num1 + num2;
            num1 = num2 - num1;

        }



    }
}
