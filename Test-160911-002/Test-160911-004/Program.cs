using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160911_004
{
    class Program
    {
        static void Main(string[] args)
        {
            Chinese cn = new Chinese();
            American am = new American();
            //DengJi(cn);
            //DengJi(am);

            Car ca = new Car();

            DengJi(am);
            DengJi(ca);

            Console.ReadKey();

        }

        //public static void DengJi(Person person) //(Chinese cn) 
        //{
        //   person.Show();
        //}

        public static void DengJi(IShowInfo lbjn) 
        {
           lbjn.Show();
        }


    }

    public interface IShowInfo 
    {
        void Show();
    }

    public abstract class Person : IShowInfo
    {
        public string Name
        {
            get;
            set;
        }
        public abstract void Show();
    }

    class Chinese : Person
    {
        public override void Show() 
        {
            Console.WriteLine("中国，18岁，......");
        }

    }

    class American : Person
    {
        public override void Show()
        {
            Console.WriteLine("美国，19岁，......");
        }

    }

    class German : Person
    {
        public override void Show()
        {
            Console.WriteLine("德国，23岁，......");
        }


    }

    class Car : IShowInfo  //Person
    {
        //public override void Show()
        //{
        //    Console.WriteLine("兰博基尼， 6.0, ..........");
        //}
        public void Show()
        {
            Console.WriteLine("兰博基尼， 6.0, ..........");
        }
    }



}
