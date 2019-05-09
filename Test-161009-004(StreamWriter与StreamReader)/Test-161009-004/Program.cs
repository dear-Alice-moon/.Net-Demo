using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; 

namespace Test_161009_004
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  StreamReader

            //using (StreamReader reader = new StreamReader("1.txt", Encoding.Default) )
            //{
            //    ////StreamReader是逐行读取文本文件
            //    ////直到文件的末尾
            //    //while (! reader.EndOfStream)
            //    //{
            //    //    Console.WriteLine(reader.ReadLine());
            //    //}

            //    //或者判断文件读取的行是否为null
            //    string line = null;
            //    while ((line = reader.ReadLine()) != null)
            //    {
            //        Console.WriteLine(line);
            //    }

            //    Console.ReadKey();

            //}

            #endregion


            #region  StreamWriter

            using (StreamWriter writer = new StreamWriter("test-02.txt", true, Encoding.Default))
            {
                for (int i = 0; i < 100; i++)
                {
                    //writer.WriteLine(i);
                    writer.Write(i);
                }
            }

            Console.WriteLine("Ok");

            Console.ReadKey();

            #endregion

        }
    }
}
