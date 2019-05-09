using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160914_001
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  异常2
            //try
            //{
            //    Console.WriteLine("111111111111111111111111");
            //    int n = 10, m = 0;
            //    Console.WriteLine(n / m);
            //    Console.WriteLine("222222222222222222222222");
            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("333333333333333333333333");
            //}
            //finally 
            //{
            //    //如果希望代码无论如何都要执行，则一定要将代码放在finally快中。
            //    //1、当catch有无法捕获的异常时，程序崩溃，但在程序崩溃前会执行finally中的代码，
            //    //而finally块后的代码则由于程序崩溃了无法执行。
            //    //2、如果在catch块中又引发了异常，则finally块中的代码也会继续引发异常之前执行，
            //    //但是finally块后的代码则不会执行。
            //    //3、当catch块中有return语句时，finally块中的代码会在return之前执行，但是finally块后
            //    //的代码 不会执行。

            //    Console.WriteLine("444444444444444444444444");
            //}


            //Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");

            //Console.ReadKey();

            #endregion

            #region  异常3
            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine("请输入一个人名：");
            //        string name = Console.ReadLine();
            //        if (name == "黄林")
            //        {
            //            //手动抛出一个异常
            //            throw new Exception("姓名不合法！");
            //        }
            //        else
            //        {
            //            Console.WriteLine("姓名合法：{0}", name);
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine("发生异常了！！！");
            //        Console.WriteLine(ex.Message);
            //        Console.WriteLine(ex.StackTrace);
            //        //throw;
            //    }
            //}


            #endregion

            #region  异常4
            M2();

            Console.ReadKey();

            #endregion

        }

        static void M2()
        {
            Console.WriteLine("=======================");
            Console.WriteLine("=======================");
            try
            {
                M1();
            }
            catch (Exception)
            {
                Console.WriteLine("M1中发生异常！！！");
                throw;
            }
            
            Console.WriteLine("=======================");
            Console.WriteLine("=======================");

        }

        static void M1() 
        {
            try
            {
                int n = 10, m = 0;
                int r = n / m;
                Console.WriteLine("结果是：{0}", r);
            }
            catch 
            {
                Console.WriteLine("捕获了该异常并且已经做了相关处理！！！");

                //这种写法只能在catch块中写、
                //"throw；"表示：当前异常继续向上抛出。
                throw;
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

    public class MyException : Exception 
    {



    }


}
