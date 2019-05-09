using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160925_001
{
    class Program
    {
        static void Main(string[] args)
        {
            string date = "二零一零年十月二十日";  //二零一零年十月二十四日   二零零九年七月九日   二零一二年十二月二十一日
            date = ConvertDate(date);
            Console.WriteLine(date);

            Console.ReadKey();
        }

        private static string ConvertDate(string date)
        {
            #region  初始化一个键值对集合
            Dictionary<char, char> dict = new Dictionary<char, char>();
            string str = "零0 一1 二2 三3 四4 五5 六6 七7 八8 九9";
            string[] strNum = str.Split(' ');
            for (int i = 0; i < strNum.Length; i++)
            {
                dict.Add(strNum[i][0], strNum[i][1]);
            }

            #endregion

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < date.Length; i++)
            {
                //1、判断该字符是否为"十"
                if (date[i] == '十')
                {
                    if (!dict.ContainsKey(date[i -1]) && !dict.ContainsKey(date[i + 1]) )  //二零一二年十月一日
                    {
                        sb.Append("10");
                    }
                    else if (!dict.ContainsKey(date[i -1]) && dict.ContainsKey(date[i + 1]))  ////二零一二年十一月十一日
                    {
                        sb.Append("1");
                    }
                    else if (dict.ContainsKey(date[i - 1]) && !dict.ContainsKey(date[i + 1]))  ////二零一二年九月二十日
                    {
                        sb.Append("0");
                    }
                    else if (dict.ContainsKey(date[i - 1]) && dict.ContainsKey(date[i + 1]))  ////二零一二年九月二十二日
                    {
                        
                    }
                }
                else if (dict.ContainsKey(date[i]))
                {
                    sb.Append(dict[date[i]]);
                }
                else
                {
                    sb.Append("-");
                }

            }  //for (int i = 0; i < date.Length; i++)


            return sb.Remove(sb.Length -1, 1).ToString();

        }


    }

}
