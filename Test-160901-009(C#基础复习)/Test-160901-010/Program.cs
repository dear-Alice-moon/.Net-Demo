using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160901_010
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strs = { "马龙", "迈克乔丹", "雷吉米勒", "蒂姆邓肯", "科比布莱恩特"};
            //string str;

            string str = GetLength(strs);

            Console.WriteLine("字符串数组中最长的字符串是:{0}", str);
            Console.ReadKey();
        }

        public static string GetLength(string[] str) 
        {
            string strr = str[0];

            for (int i = 1; i < str.Length; i++)
            {
                if (strr.Length < str[i].Length)
                {
                    strr = str[i];
                }
            }

            return strr;

        }

    }
}
