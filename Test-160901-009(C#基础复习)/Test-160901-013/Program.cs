using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160901_013
{
    class Program
    {
        //备注：该题不知如何做！！！

        static void Main(string[] args)
        {
            #region  视频中老师所讲代码, 13题第（1）小题。

            string msg = "“患者：“大夫，我咳嗽得很重。”     大夫：“你多大年记？”     患者：“七十五岁。”     大夫：“二十岁咳嗽吗”患者：“不咳嗽。”     大夫：“四十岁时咳嗽吗？”     患者：“也不咳嗽。”     大夫：“那现在不咳嗽，还要等到什么时咳嗽？”";

            ////msg.IndexOf("咳嗽", 0);

            ////记录“咳嗽”出现的次数
            //int count = 0;
            //int index = 0;

            //while ( (index = msg.IndexOf("咳嗽", index)) != -1 )  //while的条件就是查找时返回的值不是-1
            //{
            //    count++;
            //    Console.WriteLine("第{0}次出现“咳嗽”的索引位置为：{1}", count, index);
            //    index = index + "咳嗽".Length;
            //}

            //Console.WriteLine("“咳嗽”一共出现了{0}次", count);

            //Console.ReadKey();

            #endregion


            #region  视频中老师所讲代码，13题第（2）小题
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for (int i = 0; i < msg.Length; i++)
            {
                if (!dict.ContainsKey(msg[i]))
                {
                    dict.Add(msg[i], 1);
                }
                else 
                {
                    dict[msg[i]]++;
                }
            }

            foreach (KeyValuePair<char, int> item in dict)
            {
                Console.WriteLine("字符{0}出现了{1}次。", item.Key, item.Value);
            }
            Console.ReadKey();

            #endregion

        }
    }
}
