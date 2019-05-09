using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160922_001
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList arrayList = new ArrayList();

            ////arraylist.AddRange()

            ////向集合中增加元素
            //arrayList.Add(10);
            //Console.WriteLine("集合中元素的个数为：{0}", arrayList.Count);
            //Console.WriteLine("集合现在的容量是：{0}", arrayList.Capacity);

            //arrayList.Add("10");
            //Console.WriteLine("集合中元素的个数为：{0}", arrayList.Count);
            //Console.WriteLine("集合现在的容量是：{0}", arrayList.Capacity);

            //arrayList.Add("黄林");
            //Console.WriteLine("集合中元素的个数为：{0}", arrayList.Count);
            //Console.WriteLine("集合现在的容量是：{0}", arrayList.Capacity);

            //arrayList.Add('李');
            //Console.WriteLine("集合中元素的个数为：{0}", arrayList.Count);
            //Console.WriteLine("集合现在的容量是：{0}", arrayList.Capacity);

            //Person xzl = new Person();
            //xzl.Name = "许正龙";
            //arrayList.Add(xzl);
            //Console.WriteLine("集合中元素的个数为：{0}", arrayList.Count);
            //Console.WriteLine("集合现在的容量是：{0}", arrayList.Capacity);

            //arrayList.Add(true);
            //Console.WriteLine("集合中元素的个数为：{0}", arrayList.Count);
            //Console.WriteLine("集合现在的容量是：{0}", arrayList.Capacity);

            ////通过下标获取集合中的元素
            //Console.WriteLine(arrayList[0]);
            //Console.WriteLine(arrayList[5]);

            //Console.WriteLine("====================");
            ////for (int i = 0; i < arrayList.Count; i++)
            ////{
            ////    Console.WriteLine(arrayList[i]);
            ////}

            ////向指定的位置插入一个元素
            //arrayList.Insert(0, "张三");
            //arrayList.Insert(4, "Test");
            //Console.WriteLine("======================");

            //arrayList.InsertRange(5, new string[] {"a", "b", "c", "d"});
            ////for (int i = 0; i < arrayList.Count; i++)
            ////{
            ////    Console.WriteLine(arrayList[i]);
            ////}


            ArrayList arrayList = new ArrayList();
            //arrayList.Add('李');
            arrayList.AddRange(new int[] { 1, 3, 4, 5, 6, 7, 8, 9 });
            //arrayList.Add("张三");

            Console.WriteLine("==================删除结果是：=======================");
            //删除元素,这样不能将ArrayList中的元素都删除掉。
            //arrayList.RemoveAt();

            //for (int i = 0; i < arrayList.Count; i++)
            //{
            //    //arrayList.Remove(arrayList[i]);   //该行语句无误。
            //    arrayList.RemoveAt(i);
            //}

            //for (int i = 0; i < arrayList.Count; i++)
            //{
            //    Console.WriteLine(arrayList[i]);
            //}

            //使用Clear()函数可将集合清空
            //arrayList.Clear();


            Console.WriteLine(arrayList.Count);

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
