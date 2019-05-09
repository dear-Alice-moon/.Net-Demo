using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08Test
{
    public class TestClass
    {
        public void DoSomething(WriteTimeDelegate writeTime) 
        {
            Console.WriteLine("============================");
            Console.WriteLine("============================");
            //执行完第二句代码时，输出一下系统时间。
            //Console.WriteLine(System.DateTime.Now.ToString());
            //writeTime();
            if (writeTime != null)
            {
                writeTime();  
            }
            Console.WriteLine("============================");
            Console.WriteLine("============================");
        }

        public void ChangeStrings(string[] strs) 
        {
            for (int i = 0; i < strs.Length; i++)
            {
                strs[i] = "★" + strs[i] + "★";
            }
        }

        public void ChangeStringsToUpper(string[] strs, ChangeStringDelegate change)
        {
            for (int i = 0; i < strs.Length; i++)
            {
                strs[i] = change(strs[i]);
            }
        }

    }

    public delegate string ChangeStringDelegate(string str);

    //定义一个委托，一个用来存储没有返回值、没有参数的委托。
    public delegate void WriteTimeDelegate();


}
