using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160916_001
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  交换两个变量
            //int m = 10, x = 20;
            //Swap(ref m, ref x);
            //Console.WriteLine(m);
            //Console.WriteLine(x);

            Console.ReadKey();
            #endregion

            #region  用户登录练习
            while (true)
            {
                Console.WriteLine("请输入用户名：");
                string name = Console.ReadLine();
                Console.WriteLine("请输入密码：");
                string pwd = Console.ReadLine();
                string msg;
                bool isOk = ValidUserLogin(name, pwd, out msg);
                if (isOk == true)
                {
                    Console.WriteLine("用户登录成功====》{0}", msg);
                }
                else
                {
                    Console.WriteLine("用户登录失败====》{0}", msg);
                }

            }  //while(true)


            #endregion

        }

        private static bool ValidUserLogin(string name, string pwd, out string msg)
        {
            bool isOk = false;
            if (name != "admin")
            {
                msg = "用户名输入错误！";
                
            }
            else if (pwd != "888888")
            {
                msg = "密码输入错误！！！";
            }
            else 
            {
                isOk = true;
                msg = "欢迎用户：" + name;
            }
            return isOk;
        }




        static void Swap(ref int n1, ref int n2) 
        {
            int temp = n1;
            n1 = n2;
            n2 = temp;
        }

    }


}
