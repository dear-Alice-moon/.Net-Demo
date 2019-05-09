using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace Test_161011_002
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  对象初始化器-集合初始化器
            //Person p = new Person();
            //p.Name = "张三";
            //p.Age = 18;
            //p.Email = "zs@itcast.com";

            //Person p2 = new Person() { Name = "李四", Age = 19, Email = "ls@itcast.com" };

            //Console.ReadKey();

            #endregion

            #region  压缩

            ////1、读取源文件
            //using (FileStream fsRead = File.OpenRead("2.txt"))
            //{
            //    //写入新文件的文件流
            //    using (FileStream fsWrite = File.OpenWrite("yasuo.rar"))
            //    {
            //        //创建压缩流
            //        using (GZipStream zip = new GZipStream(fsWrite, CompressionMode.Compress))
            //        {
            //            byte[] buffer = new byte[1024 * 10];
            //            int r;
            //            while ((r = fsRead.Read(buffer, 0, buffer.Length)) > 0)
            //            {
            //                zip.Write(buffer, 0, r);
            //            }

            //        }  //(GZipStream zip = new GZipStream(fsWrite, CompressionMode.Compress))
            //    }  //(FileStream fsWrite = File.OpenWrite("yasuo.rar"))

            //}  //(FileStream fsRead = File.OpenRead("2.txt"))

            //Console.WriteLine("OK");
            //Console.ReadKey();

            #endregion

            #region  解压

            //1、读取压缩文件
            using (FileStream fsRead = File.OpenRead("yasuo.rar"))
            {
                //创建压缩流
                using (GZipStream zip = new GZipStream(fsRead, CompressionMode.Decompress))
                {
                    //写入新文件的文件流
                    using (FileStream fsWrite = File.OpenWrite("jieya.txt"))
                    {
                        byte[] buffer = new byte[1024 * 10];
                        //解压读取
                        int r;
                        while ((r = fsRead.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            //写入新文件
                            fsWrite.Write(buffer, 0, r);
                        }

                    }
                }  //(GZipStream zip = new GZipStream(fsRead, CompressionMode.Decompress))

            }  //(FileStream fsRead = File.OpenRead("yasuo.rar"))

            Console.WriteLine("OK");

            Console.ReadKey();

            #endregion

        }
    }

    public class Person 
    {
        public Person() 
        {

        }

        public Person(string name, int age, string email) 
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public string Name
        {
            get;
            set;
        }

        public int Age
        {
            get;
            set;
        }

        public string Email
        {
            get;
            set;
        }


    }


}
