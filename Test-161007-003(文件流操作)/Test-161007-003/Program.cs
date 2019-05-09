using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_161007_003
{
    class Program
    {
        static void Main(string[] args)
        {
            //文件流的使用方式

            #region  字符串与字节数组相互转化

            //string msg = "张三李四王二狗";

            ////把字符串转换成byte数组。
            //byte[] bytes = System.Text.Encoding.UTF8.GetBytes(msg);

            ////怎么把一个byte数组转换成一个字符串
            //string newmsg = System.Text.Encoding.UTF8.GetString(bytes);
            //Console.WriteLine(newmsg);
            //Console.ReadKey();

            #endregion


            //流操作的都是字节，不能直接操作字符串。

            #region  1、通过FileStream来写文件
            //文件流的使用步骤
            ////1、创建文件流
            //FileStream fsWrite = new FileStream("first.txt", FileMode.Create, FileAccess.Write);

            ////2、使用文件流，执行读写操作
            //string msg = "今天天气好晴朗，处处好风光。Hello, are you OK ?";
            //byte[] byts = System.Text.Encoding.UTF8.GetBytes(msg);
            ////写
            ////参数1：表示指定的字节数组中的内容写入到文件；
            ////参数2：参数1的数组的偏移量，一般为0；
            ////参数3：本次文件写入操作要写入的实际的字节个数。
            //fsWrite.Write(byts, 0, byts.Length);  //该行代码有不完善的地方 ???
            ////fsWrite.Write(byts, 0, 1024*1024*5);

            ////3、清空缓冲区、关闭文件流、释放资源
            //fsWrite.Flush();
            //fsWrite.Close();
            //fsWrite.Dispose();

            //Console.WriteLine("Ok");
            //Console.ReadKey();

            #endregion


            #region  1、通过FileStream来读文件
            //文件流的使用步骤
            //1、创建文件流
            using (FileStream fsRead = new FileStream("first.txt", FileMode.Open, FileAccess.Read))
            //使用FileStream文件流读取文本文件的时候，不需要指定编码，因为编码是在byte数组转换为字符串
            //的时候才需要使用编码，而这里是直接读取到byte[]，所以无需使用编码
            {
                //根据文件的总字节数，创建一个byte数组，这种方式会将文件内容一次性读取出来，读取到byte[]中。
                byte[] bytes = new byte[fsRead.Length];
                //2、读取文件
                fsRead.Read(bytes, 0, bytes.Length);  //该代码有不完善的地方。
                string newmsg = System.Text.Encoding.UTF8.GetString(bytes);

                Console.WriteLine(newmsg);

                fsRead.Flush();
                fsRead.Close();
                fsRead.Dispose();

                Console.ReadKey();

            }

            #endregion


        }
    }
}
