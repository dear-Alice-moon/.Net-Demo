using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160911_002
{
    class Program
    {
        static void Main(string[] args)
        {
            IFlyable bird = new Parrot();  //Sparrow();
            bird.Fly();



            Console.ReadKey();
        }
    }

    public class Bird 
    {
        public void Bark() 
        {
            Console.WriteLine("叫.............");
        }
    }

    public interface IFlyable 
    {
        void Fly();
    }

    //麻雀
    //当一个类同时继承父类，并且实现了多个接口的时候，必须将继承类，写在第一个。
    public class Sparrow : Bird, IFlyable
    {
        #region  IFlyable 成员

        public void Fly() 
        {
            Console.WriteLine("麻雀飞上青天！！");
        }


        #endregion
    }

    //鸵鸟
    public class Ostrich: Bird
    {

    }

    /// <summary>
    /// 企鹅
    /// </summary>
    public class Penguin : Bird
    {

    }

    /// <summary>
    /// 鹦鹉
    /// </summary>
    public class Parrot : Bird, IFlyable
    {
        #region
        public void Fly() 
        {
            Console.WriteLine("鹦鹉在家里转来转去！！");
        }

        #endregion


    }

}


