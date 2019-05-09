using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160903_005_22
{
    class Program
    {
        static void Main(string[] args)
        {
            //22.请将字符串数组{ "中国", "美国", "巴西", "澳大利亚", "加拿大" }中的内容反转。
            //然后输出反转后的数组。不能用数组的Reverse()方法。

            string[] msg = { "中国", "美国", "巴西", "澳大利亚", "加拿大"};
            
            //所用数组都是引用类型 int[] arr;

            //反转该数组
            MyReverse(msg);
            for (int i = 0; i < msg.Length; i++)
            {
                Console.WriteLine(msg[i]);
            }

            Console.ReadKey();

        }

        private static void MyReverse(string[] msg)
        {
            for (int i = 0; i < msg.Length / 2; i++)
            {
                string temp = msg[i];
                msg[i] = msg[msg.Length - 1 - i];
                msg[msg.Length - 1 - i] = temp;
            }
        }
    }
}
