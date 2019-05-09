using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160901_001
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.声明两个变量：int n1 = 10, n2 = 20;要求将两个变量交换，最后输出n1为20,
            //n2为10。扩展（*）：不使用第三个变量如何交换？



            int n1 = 10, n2 = 20;
            Console.WriteLine("n1的值为{0}，n2的值为{1}。", n1, n2);

            n1 = n1 - n2;
            n2 = n1 + n2;
            n1 = n2 - n1;

            #region   方法二
            //n1 = n1 + n2;
            //n2 = n1 - n2;
            //n1 = n1 - n2;

            #endregion

            Console.WriteLine("n1、n2交换后，n1的值为{0}，n2的值为{1}。", n1, n2);

            Console.ReadKey();
        }
    }
}
