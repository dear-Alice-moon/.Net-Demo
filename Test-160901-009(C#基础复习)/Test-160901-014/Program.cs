using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160901_014
{
    class Program
    {
        //备注：本程序仅为半成品！！！

        static void Main(string[] args)
        {
            #region  自写程序，半成品！

            //string str = "  hello      world,你  好 世界   !    ";
            ////str = str.Trim();
            ////string[] strr = new string [str.Length];

            ////str = str.Trim();
            //string[] strr = str.Trim().Split();

            //str = null;
            //for (int i = 0; i < strr.Length; i++)
            //{
            //    str += strr[i] + " ";
            //}

            //Console.WriteLine(str);
            //Console.ReadKey();

            #endregion


            #region  视频中老师所讲代码
            string msg = "  hello      world,你  好 世界   !    ";

            //msg = msg.Trim();  //这样表示去掉两边空格
            string[] words = msg.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            msg = string.Join(" ", words);

            Console.WriteLine("======" + msg + "==========");

            Console.ReadKey();

            #endregion

        }
    }
}
