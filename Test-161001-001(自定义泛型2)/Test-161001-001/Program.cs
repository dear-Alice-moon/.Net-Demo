using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_161001_001
{
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


    class Program
    {
        static void Main(string[] args)
        {
            #region  泛型1
            ////MyClass mc = new MyClass();
            //MyClass<string> mc = new MyClass<string>();
            //mc[0] = "黄林";
            //mc[1] = "杨硕";

            //MyClass<int> mc = new MyClass<int>();
            //mc[0] = 1000;
            //mc[1] = 2000;

            //Console.WriteLine(mc[0]);
            //Console.WriteLine(mc[1]);

            #endregion

            #region  泛型2
            //MyClass<int> mm = new MyClass<int>();
            //MyClass<string> mm = new MyClass<string>();
            //mm[0] = 1;
            //mm[0] = "1";

            MyClass<int, Stream, int, FileStream, Person, int, int> mm = new MyClass<int, Stream, int, FileStream, Person, int, int>();
            mm[0] = 100;



            #endregion


            Console.ReadKey();

        }
    }

    //泛型类
    //使用泛型可以使“算法”重用。只是数据类型发生了改变。
    public class MyClass<T, K, V, W, X, Y, Z> 
        where T :struct  //约束T必须是值类型
        where K : class  //约束K必须是引用类型
        where V : IComparable
        where W : K  //要求W必须是K类型那个或者K类型的子类
        where X : class,new()  //对于一个类型有多个约束，必须使用“逗号”隔开
    {
        private T[] _data = new T[5]; 

        public T this[int index] 
        {
            get 
            {
                return _data[index];
            }
            set 
            {
                _data[index] = value;
            }

        }

    }


    //普通类
    public class MyClass 
    {
        private string[] _data = new string[5];
        public string this[int index] 
        {
            get 
            {
                return _data[index];
            }
            set 
            {
                _data[index] = value;
            }

        }

    }




}
