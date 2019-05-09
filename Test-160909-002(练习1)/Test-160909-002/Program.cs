using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160909_002
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal d = new Dog();
            Cat c = new Cat();

            d.Bark();
            d.Eat();
            c.Bark();
            c.Eat();

            Console.ReadKey();


        }
    }

    abstract class Animal 
    {
        public abstract void Bark();
        public abstract void Eat();
    }

    class Dog : Animal
    {
        public override void Bark()
        {
            Console.WriteLine("小狗汪汪叫！");
        }

        public override void Eat()
        {
            Console.WriteLine("小狗喜欢吃骨头！");
        }
    }

    class Cat : Animal 
    {
        public override void Bark()
        {
            Console.WriteLine("小猫喵喵叫！");
        }

        public override void Eat()
        {
            Console.WriteLine("小猫喜欢吃鱼！");
        }
    }




}
