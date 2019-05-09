using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Test_161030_001
{
    class Program
    {
        static void Main(string[] args)
        {
            //1、委托是一种数据类型，像类一样的一种数据类型。一般都是直接在命名空间中定义。

            //2、定义委托时，需要指明返回值类型、委托名与参数列表。这样就能确定该类型的委托存储什么样的方法。

            //3、使用委托：
            //（1）、声明委托变量；
            //（2）、委托是一个引用类型，就像类一样，所以当声明委托变量后，如果不赋值则该委托变量为null。所以在
            //使用委托变量前最好做非空校验(委托 != null)
            //（3）、委托类型的变量只能赋值一个委托类型的对象。

            //MyDelegate md = new MyDelegate(M1);  //等价于===>  MyDelegate md = M1;
            ////MyDelegate md = M1; 
            //md.Invoke();  // 等价于 =====> md();

            while (true)
            {
                Console.WriteLine("请输入一个邮箱：");
                string email = Console.ReadLine();
                email = Regex.Replace(email, @"(\w+)(@\w+\.\w+)", ReplaceMethod, RegexOptions.ECMAScript);
                Console.WriteLine(email);
            }

            Console.ReadKey();

        }

        static void M1() 
        {
            Console.WriteLine("M1函数。");
        }

        static string ReplaceMethod(Match match) 
        {
            string uid = match.Groups[1].Value;
            string others = match.Groups[2].Value;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < uid.Length; i++)
            {
                sb.Append("★");
            }

            return sb.ToString() + others;
        }

    }

    public delegate void MyDelegate();

    public class MyClass 
    {
        public void Say() 
        {
            //..........

            //............

            //..........

        }

    }


}
