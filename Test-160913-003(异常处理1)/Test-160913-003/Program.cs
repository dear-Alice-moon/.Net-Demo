using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160913_003
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  异常处理
            //try
            //{
            //    //可能发生异常的代码
            //}
            //catch
            //{

            //    throw;  //继续向上抛出异常。
            //}
            //finally 
            //{
            //    //不论是否发生异常，该部分为“必须要执行的代码”。
            //}

            #endregion

            Person p = new Person();

            p = null;
            try
            {
                //当try块中某行代码发生异常后，从该行代码开始，后面的代码都不会继续执行了，
                //程序直接跳转到catch块中进行执行。
                p.Name = "张三";
                Console.WriteLine("============================");
                Console.WriteLine(p.Name);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally 
            {

            }

            //Console.WriteLine(p.Name);

            Console.ReadKey();
        }
    }

    class Person 
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
