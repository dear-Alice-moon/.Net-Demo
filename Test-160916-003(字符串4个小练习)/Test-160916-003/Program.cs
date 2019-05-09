using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160916_003
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  练习5，实验成功。
            //string str1 = "123-456---7--89----123--2";
            //string[] strNum = str1.Split(new char[] { '-' }, System.StringSplitOptions.RemoveEmptyEntries);

            #region  冗余代码
            //for (int i = 0; i < strNum.Length - 1; i++)
            //{
            //    strNum[i] = strNum[i] + "-";
            //}

            //for (int i = 0; i < strNum.Length; i++)
            //{
            //    Console.Write(strNum[i]);
            //}
            //Console.ReadKey();

            #endregion

            //str1 = string.Join("-", strNum);
            //Console.WriteLine(str1);

            //Console.ReadKey();

            #endregion

            #region  练习6，路径中包含非法字符，实验未成功。
            //string path = @"D:\a\b.txt";   //使用“@”符号取消转义！！！
            //string name = Path.GetFileName(path);
            ////也可使用下一行代码取代：string name = Path.GetFileName(path);
            //path = path.Substring(path.LastIndexOf('\\') + 1);

            //Console.WriteLine(name);

            //Console.ReadKey();

            #endregion

            #region  练习7，练习未完成！
            //string str = "192.168.10.5[port = 21, type = ftp]";
            //string[] strNum = str.Split(new char[] { '[', ']', ','}, System.StringSplitOptions.RemoveEmptyEntries);

            //================视频中老师所讲授代码
            //"192.168.10.5[port = 21]" http
            ////string message = "192.168.10.5[port = 21]";
            //string message = "192.168.10.5[port = 21, type = ftp]";

            //string[] parts = message.Split(new string[] { "[port = ", ", type = ", "]" }, StringSplitOptions.RemoveEmptyEntries);
            //Console.WriteLine("ip : {0}", parts[0]);
            //Console.WriteLine("port : {0}", parts[1]);
            //Console.WriteLine("service:{0}", parts.Length > 2 ? parts[2] : "http");

            #region  冗余代码
            //if (parts.Length == 3)
            //{
            //    Console.WriteLine("service: {0}", parts[2]);
            //}
            //else
            //{
            //    Console.WriteLine("service: http");
            //}

            #endregion

            //Console.ReadKey();

            #endregion

            #region  练习8，练习中的平均值未求出！
            //int[] perMoney = { 1800, 5000, 3000, 2500, 4000 };
            //int maxMoney = perMoney[0], minMoney = perMoney[0];
            //double sumMoney = 0;
            //for (int i = 0; i < perMoney.Length ; i++)
            //{
            //    //int temp;
            //    if (maxMoney <= perMoney[i])
            //    {
            //        int temp = maxMoney;
            //        maxMoney = perMoney[i];
            //        perMoney[i] = temp;
            //    }
            //    else if (minMoney >= perMoney[i])
            //    {
            //        int temp = minMoney;
            //        minMoney = perMoney[i];
            //        perMoney[i] = temp;
            //    }

            //    sumMoney += perMoney[i];

            //}

            ////for (int i = 0; i < perMoney.Length; i++)
            ////{
            ////    sumMoney = sumMoney + perMoney[i];
            ////}


            //Console.WriteLine("员工中最高工资为：{0}", maxMoney);
            //Console.WriteLine("员工中最低工资为：{0}", minMoney);
            //Console.WriteLine("员工们的平均工资为：{0}", (sumMoney / perMoney.Length));
            //Console.WriteLine(sumMoney);

            //Console.ReadKey();

            #endregion

            #region  练习8，视频中老师所讲代码
            string[] lines = File.ReadAllLines("salary.txt", Encoding.Default);

            //假设第一个人的工资即为最高工资，也为最低工资。
            //double max = double.Parse( lines[0].Split('=')[1] );
            //double min = double.Parse(lines[0].Split('=')[1]);

            //double max = double.Parse(lines[0].Split(new char[] { '=', ' ', ';' })[1]);
            //double min = double.Parse(lines[0].Split(new char[] { '=', ' ', ';' })[1]);

            double max = double.Parse(lines[0].Split(new char[] { '=', ';' })[1]);
            double min = double.Parse(lines[0].Split(new char[] { '=', ';' })[1]);


            double sum = 0;
            double count = 0;

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Length != 0)
                {
                    count++;
                    //double money = double.Parse(lines[i].Split('=')[1]);
                    //double money = double.Parse(lines[i].Split(new char[] { '=', ' ', ';' })[1]);
                    double money = double.Parse(lines[i].Split(new char[] { '=', ';' })[1]);
                    sum += money;   
                    if (max < money)
                    {
                        max = money;
                    }
                    if (min > money)
                    {
                        min = money;
                    }

                }  //if(lines[i].Length != 0)
                
            }

            Console.WriteLine("最高工资为{0}", max);
            Console.WriteLine("最低工资为{0}", min);
            Console.WriteLine("平均工资为{0}", (sum / count) );

            Console.ReadKey();

            #endregion


        }
    }


}
