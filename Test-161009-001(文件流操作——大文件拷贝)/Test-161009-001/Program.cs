using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Test_161009_001
{
    class Program
    {
        static void Main(string[] args)
        {
            string source = @"D:\澳门风云3_超清.kux";
            string target = @"F:\澳门风云3_超清.kux";
            BigFileCopy(source, target);
            Console.WriteLine("Ok");

            Console.ReadKey();
        }


        /// <summary>
        /// 通过文件流实现将source中的文件拷贝到target
        /// </summary>
        /// <param name="source"></param>
        /// <param name="target"></param>
        private static void BigFileCopy(string source, string target)
        {
            //1、创建一个读取源文件的文件流
            using (FileStream fsRead = new FileStream(source, FileMode.Open, FileAccess.Read) )
            {
                //2、创建一个写入新文件的文件流
                using (FileStream fsWrite = new FileStream(target, FileMode.Create, FileAccess.Write) )
                {
                    //拷贝文件的时候，创建一个中间缓冲区
                    byte[] bytes = new byte[1024 * 1024 * 10];
                    //string str = System.Te
                    //返回值表示本次实际读取到的字节个数.
                    int r = fsRead.Read(bytes, 0, bytes.Length);
                    while (r > 0)
                    {
                        //将读取到的内容写入到新文件中
                        //第三个参数应该是实际读取到的字节数，而不是数组的长度。
                        fsWrite.Write(bytes, 0, r);
                        //Console.WriteLine(".");
                        double d = (fsWrite.Position / (double)fsRead.Length) * 100;
                        Console.WriteLine("{0}%", d);
                        r = fsRead.Read(bytes, 0, bytes.Length);
                    }


                }


            }


        }
    }


}
