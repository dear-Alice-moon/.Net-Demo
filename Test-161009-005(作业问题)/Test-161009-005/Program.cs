using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Test_161009_005
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader stRead = new StreamReader("工资文件.txt", Encoding.Default))
            {
                List<string> list = new List<string>();
                int count = 0;

                //StreamReader是逐行读取文本文件
                while (! stRead.EndOfStream)
                {
                    //list.Add(stRead.ReadLine());
                    string[] str = (stRead.ReadLine()).Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                    int x = Convert.ToInt32(str[1]) * 2;
                    str[1] = Convert.ToString(x);
                    list.Add(str[0]+"|" +str[1]);
                    count++;


                }  //将工资加倍后返还给原集合

                //创建StreamWriter流将加倍后的工资写入新文件中。
                using (StreamWriter stWrite = new StreamWriter("test.txt",  true, Encoding.Default) )
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        stWrite.WriteLine(list[i]);
                    }
                }

            }

            Console.WriteLine("OK");

            Console.ReadKey();

        }
    }
}
