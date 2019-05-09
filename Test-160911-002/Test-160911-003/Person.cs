using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160911_003
{
    public interface ICollectHomework 
    {
        void Collect();


    }

    public class Person
    {

    }

    public class Student : Person, ICollectHomework 
    {

        public void Collect()
        {
            Console.WriteLine("学生可以收作业！！！");
        }
    }

    public class Teacher : Person, ICollectHomework  
    {

        public void Collect()
        {
            Console.WriteLine("老师可以收作业！！！");
        }
    }

    public class SchoolMater : Person 
    {

    }

}
