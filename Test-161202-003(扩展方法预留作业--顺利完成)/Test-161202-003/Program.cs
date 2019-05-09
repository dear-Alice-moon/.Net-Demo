using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Test_161202_003
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("请输入任意一个Email！");
                string msg = Console.ReadLine();
                bool b = msg.IsEmail();
                Console.WriteLine(b);
                Console.ReadKey();
            }
        }
    }

    public static class Email 
    {
        public static bool IsEmail(this string msg) 
        {
           // bool b;
           // b = Regex.IsMatch(msg, @"[0-9a-zA-Z]*@[a-z]*\.[a-z]*?");
           //     //([0-9a-zA-Z]*@[a-z]*\.[a-z]*?)
           //return b;
            if (Regex.IsMatch(msg, @"[0-9a-zA-Z]*@[a-z]*\.[a-z]*?") || Regex.IsMatch(msg, @"[0-9a-zA-Z]*@([a-z]*\.){1,2}[a-z]*?"))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    } 


}
