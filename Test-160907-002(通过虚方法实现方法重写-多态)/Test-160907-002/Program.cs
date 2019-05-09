using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160907_002
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person p1 = new American();

            //Person p = new Person();
            //Person p = new American();
            //p.SayNation();


            Person[] pers = new Person[6];

            pers[0] = new American();
            pers[1] = new Chinese();
            pers[2] = new Janpanese();
            pers[3] = new Chinese();
            pers[4] = new American();
            pers[5] = new British();

            //遍历pers数组
            for (int i = 0; i < pers.Length; i++)
            {
                pers[i].SayNation();  //这句话就体现了多态


                #region  不能忍的代码
                //pers[i].Say
                //if (pers[i] is American)
                //{
                //    ((American)pers[i]).SayNation();
                //}
                //else if (pers[i] is Chinese)
                //{
                //    ((Chinese)pers[i]).SayNation();
                //}
                //else 
                //{
                //    ((Janpanese)pers[i]).SayNation();
                //}

                #endregion

                //希望这里只写一句话
                //pers[i]

            }  //for(int i =0; i < pers.Length; i++)

                
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

        //第一步：将父类中的对应方法前加virtual关键字。即：将对应的方法变为“虚方法”。
        public virtual void SayNation() 
        {
            Console.WriteLine("地球人！");
        }


    }

    public class American : Person 
    {
        //通过使用override关键字将父类Person中的虚方法"SayNationality"重写为子类自己想要的。
        //说出自己的国籍
        public override void SayNation() 
        {
            Console.WriteLine("USA");
        }
        
    }

    public class Janpanese : Person
    {
        public override void SayNation()
        {
            Console.WriteLine("日本");
        }

    }

    public class Chinese : Person
    {
        public override void SayNation()
        {
            Console.WriteLine("中国");
        }

    }

    public class British : Person
    {
        public override void SayNation()
        {
            Console.WriteLine("英国");
        }

    }


}
