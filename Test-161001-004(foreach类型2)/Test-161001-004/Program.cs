using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_161001_004
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person p = new Person();

            //IEnumerator etor = p.GetEnumerator();
            //while (etor.MoveNext())
            //{
            //    Console.WriteLine(etor.Current.ToString());
            //}
            ////etor.Reset();
            ////while (etor.MoveNext())
            ////{
            ////    Console.WriteLine(etor.Current.ToString());
            ////}

            //Console.WriteLine("Ok");

            //=========================
            Person p = new Person();
            foreach (string item in p)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Ok");

            Console.ReadKey();

        }
    }


    //1.需要让该类型实现一个名字叫IEnumerable的接口,实现该接口的主要目的是
    //为了让当前类型中增加一个名字叫GetEnumerator()的方法
    public class Person : IEnumerable
    {
        private string[] Friends = new string[] { "黄林", "许正龙", "张三", "杨硕" };

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


        #region  IEnumerable 成员

        //这个方法的作用就是返回一个"枚举器"
        public IEnumerator GetEnumerator()
        {
            //1、在这个方法中该写什么代码？？？
            return new PersonEnumerable(this.Friends);
        }

        #endregion  

    }

    //这个类型就是一个枚举器
    //希望一个类型被“枚举”、“遍历”，就要实现了类，该类就是一个“枚举器”。
    public class PersonEnumerable : IEnumerator
    {
        private string[] _friends;
        public PersonEnumerable(string[] fs) 
        {
            _friends = fs;
        }

        //一般下标都是一开始指向第一条的前一条
        private int index = -1;

        #region  IEnumerable成员
        public object Current 
        {
            get 
            {
                if (index >= 0 && index < _friends.Length)
                {
                    return _friends[index];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

        public bool MoveNext() 
        {
            if (index + 1 < _friends.Length)
            {
                index++;
                return true;
            }
            return false;
        }

        public void Reset() 
        {
            index = -1;
        }

        #endregion


    } 



}
