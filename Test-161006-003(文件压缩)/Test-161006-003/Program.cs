using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_161006_003
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  小测试
            //string s = "杨中科";
            //for (int i = 0; i < 25; i++)
            //{
            //    s = s + s;
            //}
            //File.WriteAllText("test.txt", s);
            //Console.WriteLine("Ok");

            //Console.ReadKey();

            #endregion

            #region  文件压缩
            //GZipStream就是对FileStream的又一个包装
            //将文本文件test.txt压缩
            //1、创建读取文本文件的流
            //using (FileStream fsRead = File.OpenRead("test.txt"))
            //{
            //    //2、创建写入文本文件的流
            //    using (FileStream fsWrite = File.OpenWrite("yasuo.txt"))
            //    {
            //       //3、创建压缩流
            //        using (GZipStream zipStream = new GZipStream(fsWrite, CompressionMode.Compress))
            //        {
            //            //4、每次读取1024byte
            //            byte[] byts = new byte[1024];
            //            int len = 0;
            //            while ((len = fsRead.Read(byts, 0, byts.Length)) > 0 )
            //            {
            //                //通过压缩流写入文件
            //                zipStream.Write(byts, 0, len);
            //            }
            //        }  //GZipStream
            //    }  //fsWrite
            //}  //fsRead
            //Console.WriteLine("Ok");
            //Console.ReadKey();

            #endregion

            #region  文件解压

            //解压文件
            //1、创建读取文本文件的流
            using (FileStream fsRead = File.OpenRead("yasuo.txt"))
            {
                //2、创建压缩流
                using (GZipStream gzipStream = new GZipStream(fsRead, CompressionMode.Decompress))
                {
                    //3、创建写入文本文件的流
                    using (FileStream fsWrite = File.OpenWrite("jieya.txt"))
                    {
                        byte[] byts = new byte[1024];
                        int len = 0;
                        while ((len = gzipStream.Read(byts, 0, byts.Length)) > 0 )
                        {
                            fsWrite.Write(byts, 0, len);
                        }
                    }
                }
            }
            Console.WriteLine("Ok");
            Console.ReadKey();

            #endregion



        }
    }



}
