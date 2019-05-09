using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_161005_002
{
    class Program
    {
        static void Main(string[] args)
        {

            #region  文件操作练习1
            ////File
            //string path = @"D:\IDE\b.txt";

            ////1、获取文件名
            //Console.WriteLine(Path.GetFileName(path));

            ////2、获取文件的后缀名
            //Console.WriteLine(Path.GetExtension(path));

            ////3、获取不带后缀的文件名
            //Console.WriteLine(Path.GetFileNameWithoutExtension(path));

            ////4、获取该路径的目录部分
            //Console.WriteLine(Path.GetDirectoryName(path));

            ////5、将路径中的文件名的后缀改为.exe
            //Console.WriteLine(Path.ChangeExtension(path, ".exe"));

            //Console.ReadKey();

            #endregion


            #region  文件操作练习2
            //string s1 = @"D:\abc\x\y";
            ////string s1 = @"D:\abc\x\y\";
            //string s2 = "hello.txt";

            ////Console.WriteLine(s1 + s2);

            //Console.WriteLine(Path.Combine(s1, s2) );

            //Console.ReadKey();

            #endregion


            #region  文件操作练习3
            //string path = "a.txt";

            //Console.WriteLine(Path.GetFullPath(path));
            ////Console.WriteLine(File.ReadAllText(path));  //改行代码只可读取英文，读取中文会出现乱码现象。
            //Console.WriteLine(File.ReadAllText(path, Encoding.Default));

            //Console.ReadKey();

            #endregion


            #region  文件操作练习4
            Console.WriteLine(Path.GetTempPath());
            Console.WriteLine(Path.GetTempFileName());
            string aa = Path.GetRandomFileName();

            Console.WriteLine(aa);

            //创建一个新的Guid
            //Guid.NewGuid().ToString();

            Console.ReadKey();

            #endregion

        }
    }

}
