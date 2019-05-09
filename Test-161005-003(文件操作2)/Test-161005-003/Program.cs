using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_161005_003
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  Directory类基本操作

            //1、创建一些目录
            //for (int i = 0; i < 10; i++)
            //{
            //    Directory.CreateDirectory(@"D:\ABC" + i);
            //}
            //Console.WriteLine("Ok");

            //Console.ReadKey();

            //2、删除一些目录
            //for (int i = 0; i < 10; i++)
            //{
            //    //删除目录时，如果给定的目录不存在，则报异常。
            //    //Delete方法直接删除目录的时候，如果目录不为空，则报异常。
            //    Directory.Delete(@"D:\ABC" + i);
            //    Directory.Delete(@"D:\ABC" + i, true);  //该行代码可删除不为空的文件夹
            //}

            //Console.WriteLine("Ok");

            //Console.ReadKey();

            //3、移动（剪切）一些目录
            //移动不能跨磁盘操作
            Directory.Move(@"D:\Test-001", @"D:\IDE\Test-001");
            Console.WriteLine("Ok");
            Console.ReadKey();

            #endregion




        }
    }

}
