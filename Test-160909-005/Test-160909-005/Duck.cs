using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160909_005
{
    abstract class Duck
    {
        public void Swim() 
        {
            Console.WriteLine("鸭子会游泳......");
        }

        public abstract void Bark();

    }

    class RubberDuck : Duck 
    {
        public override void Bark()
        {
            Console.WriteLine("橡皮鸭子唧唧叫！");
        }
    }

    class RealDuck : Duck 
    {
        public override void Bark()
        {
            Console.WriteLine("真的鸭子嘎嘎叫(^__^)");
        }
    }


}
