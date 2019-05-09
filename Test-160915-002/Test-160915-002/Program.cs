using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160915_002
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  params可变参数
            //int[] arrInt = new int[] { 1, 2, 3, 4, 5 };
            //Test("xxx");
            ////Test("aaa", arrInt);
            //Test("aaa", null);

            #endregion

            #region  out参数
            ////int m = 1000;
            //int m;
            //Test1(out m);
            //Console.WriteLine(m);

            #endregion

            //int.TryParse("12",)



            Console.ReadKey();

        }

        #region  ref参数
        static void Test2(ref int x) 
        {


        }

        #endregion

        #region  out参数
        static void Test1(out int x) 
        {

            x = 101;
            Console.WriteLine(x);
            x = 100;
            x++;
        }

        #endregion

        #region  params可变参数
        static void Test(string msg, params int[] args) 
        {
            if (args != null)
            {
                
            }

        }

        #endregion

    }


}
