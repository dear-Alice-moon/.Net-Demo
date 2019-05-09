using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160911_001
{
    class Program
    {
        static void Main(string[] args)
        {
            IFlyable fly = new Myclass();

            fly.SayHi();

        }
    }

    //定义一个接口，建议：一定要以大写I开头
    public interface IFlyable 
    {
        //接口里面可以包含：属性、方法、索引器、事件。其实则均为“方法”。

        void SayHi();

        void M1(string msg);

        //在接口中这样写表示是一个未实现的属性
        string Name
        {
            get;
            set;
        }

        //索引器
        string this[int index]
        {
            get;
            set;
        }





    }

    //接口中的成员，子类必须实现。
    public class Myclass : IFlyable
    {
        public void SayHi()
        {
            throw new NotImplementedException();
        }

        public void M1(string msg)
        {
            throw new NotImplementedException();
        }

        public string Name
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string this[int index]
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }  //public string this[int index]



    }


}
