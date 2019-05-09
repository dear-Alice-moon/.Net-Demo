using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160917_002
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("你好呀，我叫{0}，今年{1}岁啦。现在时间是{2:d}， 这个月工资发了：{3}。", "黄林", 18, System.DateTime.Now, 800);


            //字符串格式化
            //{0, 80:h}
            //{1, 50:d}
            //{0[, number] [:格式]}
            //[, number]表示：宽度+对齐， 正整数表示右对齐，负整数表示左对齐。
            Console.WriteLine("======我叫：{0,-10}========", "黄林");

            Console.WriteLine("工资是{0:f3}",  123.7415);


            Console.ReadKey();
        }
    }



}
