using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_161130_001
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person p = new Person();
            var p = new { Name = "黄林", Age = 18, Email = "zhangsan@163.com"  };
            Console.WriteLine(p.Name);
            Console.WriteLine(p.Age);
            Console.WriteLine(p.Email);

            Console.WriteLine("Ok");
            Console.ReadKey();
        }
    }

    //public class Person 
    //{
    //    public string Name  //自动属性
    //    {
    //        get;
    //        set;
    //    }

    //    public int Age 
    //    { 
    //        get; 
    //        set; 
    //    }

    //    public string Email
    //    {
    //        get;
    //        set;
    //    }

    //}


}
