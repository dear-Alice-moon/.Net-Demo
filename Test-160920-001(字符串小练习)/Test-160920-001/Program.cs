using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160920_001
{
    class Program
    {
        static void Main(string[] args)
        {

            #region  验证空数组的长度 是否为零！
            //double[] num = { };

            //Console.WriteLine("数组长度为：{0}", num.Length);

            //Console.ReadKey();

            #endregion

            #region  寻找“传智播客”出现的次数！！！
            //"北京传智播客软件培训，传智播客.net培训，传智播客Java培训。传智播客官网：
            //http://www.itcast.cn。北京传智播客欢迎您。"。

            string msg = "北京传智播客软件培训，传智播客.net培训，传智播客Java培训。传智播客官网：http://www.itcast.cn。北京传智播客欢迎您。";

            int count = 0;  //统计“传智播客”出现的次数
            int index = 0;  //作为“传智播客”出现位置的索引

            while ((index = msg.IndexOf("传智播客", index) ) != -1 )
            {
                count++;
                index = index + "传智播客".Length;
            }

            Console.WriteLine("传智播客出现的次数为：{0}", count);

            Console.ReadKey();

            #endregion

        }
    }
}
