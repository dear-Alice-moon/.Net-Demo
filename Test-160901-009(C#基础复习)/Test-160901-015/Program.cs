using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160901_015
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  自写程序，实验成功。
            ////string[] strr = new string[100];
            //string str1 = null;
            //int n1 = 0;


            //while (true) 
            //{
            //    Console.WriteLine("请输入姓名！");
            //    string str = Console.ReadLine();

            //    if (str == "quit")
            //    {
            //        break;
            //    }
            //    else 
            //    {
            //        str1 += str + " ";
            //        n1++;
            //    }

            //    //else 
            //    //{
            //    //    for (int i = 0; i < strr.Length; i++)
            //    //    {
            //    //        strr[i] = str;
            //    //    }
            //    //}

            //}

            //Console.WriteLine("您一共录入了：{0}个学生，姓名分别为：", n1);

            //string[] strr = str1.Trim().Split();
            //for (int i = 0; i < strr.Length; i++)
            //{
            //    Console.WriteLine(strr[i]);
            //}

            //Console.ReadKey();

            #endregion


            #region  视频中老师所讲代码
            string name = string.Empty;
            List<string> list = new List<string>();

            do
            {
                Console.WriteLine("请输入姓名：");
                name = Console.ReadLine();
                list.Add(name);

            } while (name.ToLower() != "quit");

            //除去集合中的最后一个元素。
            list.RemoveAt(list.Count - 1);
            Console.WriteLine("输入学生个数为：{0}", list.Count);
            Console.WriteLine("分别是：");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            Console.ReadKey();

            #endregion

        }
    }
}
