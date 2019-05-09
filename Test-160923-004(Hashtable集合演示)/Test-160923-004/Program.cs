using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160923_004
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hash = new Hashtable();

            hash.Add("h1", "黄林");

            hash.Add("xzl", new Person() { Name = "许正龙" });

            //键值对集合的“键”一定不能重复（唯一）
            hash.Add("hh", "huanglei");

            //判断一个集合中是否存在某个键
            if (! hash.ContainsKey("h1"))
            {
                
            }

            //判断键值对中是否存在某个值
            bool b1 = hash.ContainsValue("黄林");
            Console.WriteLine(b1);

            //通过键获取值
            Console.WriteLine(hash["h1"]);   //这两行代码均可正确运行
            // Console.WriteLine(hash["h1"].ToString());

            Person pp = hash["xzl"] as Person;
            Console.WriteLine(pp.Name);


            //=======================================
            //遍历Hashtable
            //1、遍历键
            foreach (object item in hash.Keys)
            {
                Console.WriteLine("键：{0} → 值：{1}", item, hash[item]);
            }
            Console.WriteLine("============直接遍历值============");
            foreach (object item in hash.Values)
            {
                Console.WriteLine("值为：{0}", item);
            }
            Console.WriteLine("=========直接遍历“键值对”=======");
            foreach (DictionaryEntry kv in hash)
            {
                Console.WriteLine("键：{0}， 值：{1}", kv.Key, kv.Value);
            }

            //foreach (var item in collection)
            //{
                
            //}




            Console.ReadKey();

        }
    }

    public class Person 
    {
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
