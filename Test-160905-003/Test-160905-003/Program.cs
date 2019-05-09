using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160905_003
{
    class Program
    {
        static void Main(string[] args)
        {
            Father f1 = new Son();
            Son s1 = (Son)f1;

            Father f2 = new Father();
            //Son s2 = (Son)f2;  //备注：不可将父类对象强制转换成子类对象，因为父类对象不具备子类对象中的一些成员。


        }
    }

    public class Father 
    {
        private char _lastName;
        private double _property;
        private string bloodTye;

        public char LastName
        {
            get;
            set;
        }

        public double Property
        {
            get;
            set;
        }

        public string BloodType
        {
            get;
            set;
        }

        public Father() { }

        public Father(char lastName, double property, string bloodType) 
        {
            this.LastName = lastName;
            this.Property = property;
            this.BloodType = bloodTye;
        }

        public void Eat() 
        {
            Console.WriteLine("父亲喜欢吃饭。");
        }

    }


    public class Son : Father 
    {
        public Son() { }
        public Son(char lastName, double property, string bloodType) : base(lastName, property, bloodType) 
        {

        }

        public void PlayGame() 
        {
            Console.WriteLine("男生喜欢玩游戏！");
        }

    }

    public class Daughter : Father 
    {
        public Daughter() { }

        public Daughter(char lastName, double property, string bloodType) : base(lastName, property, bloodType) 
        {

        }

        public void Dance() 
        {
            Console.WriteLine("女孩喜欢跳舞。");
        }

    }


}
