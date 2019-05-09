using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160924_002
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> list = new List<string>();
            //List<int> list2 = new List<int>();
            //Console.WriteLine(list.ToString());


            //List<int> list = new List<int>();
            //list.Add(100);
            //list.Add(999);
            //list.Add(889);

            //int[] nums =  list.ToArray();


            //Hashtable的泛型版本
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("huanglin", 100);
            dict.Add("xuzhenglong", 89);

            //Console.WriteLine(dict["huanglin"]);

            //遍历"键"
            Console.WriteLine("========遍历键========");
            foreach (string item in dict.Keys)
            {
                Console.WriteLine(item);
            }

            //遍历"值"
            Console.WriteLine("========遍历值========");
            foreach (int item in dict.Values)
            {
                Console.WriteLine(item);
            }

            //遍历键、值
            Console.WriteLine("========遍历键、值========");
            foreach (KeyValuePair<string, int> item in dict)
            {
                Console.WriteLine("键为：{0}， 值为：{1}", item.Key, item.Value);
            }


            Console.ReadKey();
        }
    }



}
