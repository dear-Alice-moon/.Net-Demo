using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160912_001
{
    class Program
    {
        static void Main(string[] args)
        {
            //IFace1 face1 = new Student();
            //face1.Fly();

            //IFace2 face1 = new Student();
            //face1.Fly(); 

            //Teacher teacher = new Teacher();
            //teacher.Fly(); //正常实现接口的Fly方法，显示实现的调不到，因为其实private的。

            //IFace1 face1 = new Teacher();
            //face1.Fly();

            //IFace2 face2 = new Teacher();
            //face2.Fly();

            //MyClass face1 = new MyClass();
            //face1.  //此调不到Fly()方法

            IFace1 face1 = new MyClass();
            face1.Fly();

            IFace2 face2 = new MyClass();
            face2.Fly();

            Console.ReadKey();
        }

    }

    public interface IFace1 
    {
        void Fly();
    }

    public interface IFace2
    {
        void Fly();
    }

    class Student : IFace1, IFace2
    {
        #region IFace1 成员
        public void Fly()
        {
            Console.WriteLine("实现了IFace1接口中的fly方法。");
        }

        #endregion
    }

    class Teacher : IFace1, IFace2
    {
        #region IFace1 成员
        public void Fly()
        {
            Console.WriteLine("实现了IFace1接口中的fly方法。");
        }

        #endregion

        #region  IFace2 成员
        void IFace2.Fly() 
        {
            Console.WriteLine("实现了IFace2接口中的fly方法。");
        }

        #endregion

    }

    class MyClass : IFace1, IFace2
    {

        void IFace1.Fly()
        {
            Console.WriteLine("显示实现IFace1中的Fly方法");
        }

        void IFace2.Fly()
        {
            Console.WriteLine("显示实现IFace2中的Fly方法");
        }

    }



}
