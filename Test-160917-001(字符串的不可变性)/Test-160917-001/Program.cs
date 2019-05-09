using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160917_001
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  字符串的不可变性1
            //1、字符串的不可变性
            //string s1 = "Hello World";
            //string x = s1.ToUpper();

            //Console.WriteLine(x);

            #endregion

            #region  字符串的不可变性2  
            //string a = "a", b = "b", c = "c";
            //a = a + b;
            //a = a + c;

            //Console.WriteLine(a);

            #endregion

            #region  字符串池

            //string s1 = new string(new char[] { 'a', 'b', 'c' });
            //string s2 = new string(new char[] { 'a', 'b', 'c' });
            //s2 = s1;

            string s1 = "abc", a = "a", b = "b", c = "c";
            string s2 = a + b + c;
            //string s2 = "a" + "b" + "c";

            Console.WriteLine(s1);
            Console.WriteLine(s2);

            //将字符串变量加进字符串池中
            string s = "a";
            string ss1 = "b";



            #endregion

            Console.ReadKey();
        }
    }



}
