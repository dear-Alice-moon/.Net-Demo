using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160915_001
{
    class Program
    {
        static void Main(string[] args)
        {
            //int r = GetNumber();
            //Console.WriteLine(r);

            //int r = M1();
            //Console.WriteLine(r);

            Person p = GetPerson();
            Console.WriteLine(p.Age);


            Console.ReadKey();
        }

        static Person GetPerson() 
        {
            Person p = new Person();
            p.Age = 100;
            try
            {
                p.Age = p.Age + 1;
                //========引发异常的代码=======
                //int n = 10, m = 0;
                //Console.WriteLine(n / m);
                //========引发异常的代码=======
                return p;
            }
            catch (Exception)
            {
                Console.WriteLine("catch中的代码块被执行啦啦啦！！！");
                p.Age = p.Age + 1;
                return p;
                //throw;
            }
            finally 
            {
                Console.WriteLine("finally中的代码块被执行啦啦啦！！！");
                p.Age = p.Age + 1;
            }
        }


        static int M1() 
        {
            int result = 100;
            try
            {
                result = result + 1;
                //=========引发异常的代码========
                int n = 10, m = 0;
                Console.WriteLine(n / m);
                //=========引发异常的代码========
                return result;
            }
            catch
            {
                Console.WriteLine("catch块中的代码被执行了！！！");
                result = result + 1;
                return result;
                //throw;
            }
            finally 
            {
                Console.WriteLine("finally块中的代码被执行了！！！");
                result = result + 1;
            }
        }

        static int GetNumber() 
        {
            try
            {
                int n = 10, m = 0;
                //===============发生异常代码块
                //Console.WriteLine(n / m);
                //=============================
                return 100;
            }
            catch (Exception)
            {
                Console.WriteLine("=====catch代码块中发生异常了！！！=====");
                return 1000;
                //throw;
            }
            finally 
            {
                Console.WriteLine("finally块中的代码执行了！！！");
            }

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

    }


}
