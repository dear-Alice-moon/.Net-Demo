using CalculatorDll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiSuanQiCeShi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入第一个数字：");
            double d1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入一个操作符：");
            string caozuofu = Console.ReadLine();
            Console.WriteLine("请输入第二个数字：");
            double d2 = Convert.ToDouble(Console.ReadLine());
            //Calculator cal = null;
            Calculator cal = GetComputerObject(caozuofu, d1, d2);

            #region  需优化代码
            //switch (caozuofu)
            //{
            //    case "+" : cal = new JiaFaClass(d1, d2);
            //        break;
            //    case "-": cal = new JianFaClass(d1, d2);
            //        break;
            //    case "*": cal = new ChengFa(d1, d2);
            //        break;
            //    default:
            //        break;
            //}

            #endregion

            if (cal != null)
            {
                Console.WriteLine("计算结果是：{0}", cal.JiSuan());
            }
            else 
            {
                Console.WriteLine("没有该功能！");
            }

            Console.ReadKey();

        }

        //简单工厂设计模式
        private static Calculator GetComputerObject(string caozuofu, double d1, double d2)
        {
            Calculator result = null;
            switch (caozuofu)
            {
                case "+": result = new JiaFaClass(d1, d2);
                    break;
                case "-": result = new JianFaClass(d1, d2);
                    break;
                case "*": result = new ChengFa(d1, d2);
                    break;
                default:
                    break;
            }

            return result;

        }
    }
}
