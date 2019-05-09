using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_161005_001
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  方法一
            //Person p = new Person();
            //foreach (var item in p.GetEachObj())
            //{
            //    Console.WriteLine(item);
            //}

            //Console.ReadKey();

            #endregion

            #region  方法二
            //Person p1 = new Person();
            //foreach (var item in p1)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.ReadKey();

            #endregion

            string[] ss = { "a", "b", "c", "d" };
            IEnumerable ie = ss;
            foreach (var item in ie)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

        }
    }

    #region  方法二
    public class Person : IEnumerable
    {
        //public IEnumerable GetEachObj()
        //{
        //    for (int i = 0; i < Friends.Length; i++)
        //    {
        //        yield return Friends[i];
        //    }
        //}

        private string[] Friends = new string[] { "黄林", "许正龙", "张三年", "杨硕", "李四狗" };

        //当返回值类型是IEnumerator时，编译器帮我们生成了一个枚举器"类"，
        //即：一个实现了IEnumerator接口的类型。
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Friends.Length; i++)
            {
                yield return Friends[i];
            }
        }

    }


    #endregion


    #region  方法一
    //public class Person 
    //{
    //    public IEnumerable GetEachObj() 
    //    {
    //        for (int i = 0; i < Friends.Length; i++)
    //        {
    //            yield return Friends[i];
    //        }
    //    }

    //    private string[] Friends = new string[] { "黄林", "许正龙", "张三年", "杨硕" };

    //    public string Name
    //    {
    //        get;
    //        set;
    //    }

    //    public int Age
    //    {
    //        get;
    //        set;
    //    }

    //    public string Email
    //    {
    //        get;
    //        set;
    //    }

    //}

    #endregion


}
