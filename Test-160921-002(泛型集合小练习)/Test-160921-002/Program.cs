using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160921_002
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  练习1，实验成功。
            //int[] num1 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //int[] num2 = new int[num1.Length];

            //GetOdd(ref num2, num1);

            //for (int i = 0; i < num2.Length; i++)
            //{
            //    if (num2[i] != 0)
            //    {
            //        Console.WriteLine(num2[i]);
            //    }
            //}

            //Console.ReadKey();

            #endregion

            #region  练习1.1，视频中老师所讲代码。使用List泛型集合
            //string str = "2 7 8 3 22 9 5 11";
            //string[] numbers = str.Split();
            //List<string> listOdd = new List<string>();
            //List<string> listEven = new List<string>();
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (int.Parse(numbers[i]) % 2 == 0)  //if (int.Parse(numbers[i]) % 2 == 0)
            //    {                                          //if (Convert.ToInt32(numbers[i]) % 2 == 0)
            //        listEven.Add(numbers[i]);
            //    }
            //    else
            //    {
            //        listOdd.Add(numbers[i]);
            //    }
            //}

            //listOdd.AddRange(listEven);

            ////方法一
            ////StringBuilder sb = new StringBuilder();
            ////for (int i = 0; i < listOdd.Count; i++)
            ////{
            ////    sb.Append(listOdd[i] + " ");
            ////}
            ////Console.WriteLine(sb);

            ////方法二
            //string[] nums = listOdd.ToArray();
            //Console.WriteLine(string.Join(" ", nums));


            //Console.ReadKey();

            #endregion

            #region  练习1.2，视频中老师所讲代码。使用List泛型集合

            //int[] arrInt = { 1, 2, 3, 4, 5, 6, 7 };
            //List<int> listOdd = new List<int>();

            //for (int i = 0; i < arrInt.Length; i++)
            //{
            //    if (arrInt[i] % 2 != 0)
            //    {
            //        listOdd.Add(arrInt[i]);
            //    }
            //}

            //int[] newArray = listOdd.ToArray();

            //for (int i = 0; i < newArray.Length; i++)
            //{
            //    Console.WriteLine(newArray[i]);
            //}

            //Console.ReadKey();

            #endregion


            #region  练习2，实验成功
            //创建ArrayList集合
            //ArrayList al = new ArrayList();
            //al.AddRange( new int[] {0, 1, 2, 3});

            ////创建List集合
            //List<int> li = new List<int>();
            //li.AddRange(new int[] { 4, 1, 2, 3, 9, 6});
            //int n = li[0];

            //for (int i = 0; i < li.Count; i++)
            //{
            //    if (n < li[i])
            //    {
            //        n = li[i];
            //    }
            //}

            ////int n = li.Max();

            //Console.WriteLine("最大值为：{0}", n);

            //Console.ReadKey();

            #endregion

            #region  练习2，视频中老师所讲代码。使用Dictionary字典集合
            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 77, 88, 9, 11 };
            //int max = GetMax(list);  //list.Max();
            //Console.WriteLine(max);

            //Console.ReadKey();

            #endregion


            #region  练习3，实验成功完成，Happy。(^__^)
            //Hashtable ht = new Hashtable();

            //Dictionary<char, char> dic = new Dictionary<char, char>();

            //dic.Add('0', '零');
            //dic.Add('1', '壹');
            //dic.Add('2', '贰');
            //dic.Add('3', '叁');
            //dic.Add('4', '肆');
            //dic.Add('5', '伍');
            //dic.Add('6', '陆');
            //dic.Add('7', '柒');
            //dic.Add('8', '捌');
            //dic.Add('9', '玖');

            //Console.WriteLine("请输入任意数字串！！!");
            //string str = Console.ReadLine();

            //for (int i = 0; i < str.Length; i++)
            //{
            //    Console.Write(dic[ str[i] ]);
            //}

            //Console.ReadKey();

            #endregion

            #region  练习3，视频中老师所讲代码
            //string str = "1壹 2贰 3叁 4肆 5伍 6陆 7柒 8捌 9玖 0零";
            //string[] str2 = str.Split(' ');
            //Dictionary<char, char> dict = new Dictionary<char, char>();

            //for (int i = 0; i < str2.Length; i++)
            //{
            //    dict.Add(str2[i][0], str2[i][1]);
            //}

            //Console.WriteLine("请输入任意一组数字！！！");
            //string strNums = Console.ReadLine();
            //StringBuilder sb = new StringBuilder();

            //for (int i = 0; i < strNums.Length; i++)
            //{
            //    sb.Append(dict[strNums[i]]);
            //}

            //Console.WriteLine(sb);
            ////Console.WriteLine(sb.ToString());  //为何sb还需要ToString() ???

            //Console.ReadKey();


            #endregion


            #region  练习4，实验未能顺利完成！
            //string str = "Welcome , to China world.";
            //Dictionary<char, int> dic = new Dictionary<char, int>();

            //for (int i = 0; i < str.Length; i++)
            //{
            //    char s = str[i];
            //    for (int j = 0; j < str.Length; j++)
            //    {
            //        if (dic[s] == str[j])  //出现：给定的关键字不在字典里的错误！！！
            //        {
            //            dic[s]++;
            //        }
            //        else
            //        {
            //            dic[s] = 1;
            //        }
            //    }  //for(int j = 0; j < str.Length; j++)

            //}  //for(int i = 0; i < str.Length; i++)

            //for (int i = 0; i < str.Length; i++)
            //{
            //    Console.WriteLine(str[i] + " " + dic[ str[i] ]);
            //}


            //Console.ReadKey();

            #endregion

            
            #region  练习4，视频中老师所讲代码
            //string str = "Welcome , to China!! world! dsjfdsl.jfdsf";
            //str = str.ToLower();
            //Dictionary<char, int> dict = new Dictionary<char, int>();

            //for (int i = 0; i < str.Length; i++)
            //{
                
            //    if (char.IsLetter(str[i]))
            //    {
                    #region  一种情况

                    //if (dict.ContainsKey(str[i]))
                    //{
                    //    dict[str[i]]++;
                    //}
                    //else
                    //{
                    //    //dict[str[i]] = 1;
                    //    dict.Add(str[i], 1);
                    //}

                    #endregion


                    #region  另一种情况
                    //if (dict.ContainsKey(char.ToLower(str[i])))
                    //{
                    //    dict[char.ToLower(str[i])]++;
                    //}
                    //else if (dict.ContainsKey(char.ToUpper(str[i])))
                    //{
                    //    dict[char.ToUpper(str[i])]++;
                    //}
                    //else
                    //{
                    //    dict.Add(str[i], 1);
                    //}

                    #endregion

            //    }

            //}  //for(int i = 0; i < str.Length; i++)

            //foreach (KeyValuePair<char, int> item in dict)
            //{
            //    Console.WriteLine("字母：{0}出现了：{1}次", item.Key, item.Value);
            //}

            //Console.ReadKey();

            //char.IsDigit

            #endregion


            #region  Dictionary<TKey, TValue>的语法糖写法
            //Dictionary<string, int> dict = new Dictionary<string, int>() { { "张三", 18 }, { "李四", 19 }, { "王五", 17 } };

            //foreach (KeyValuePair<string, int> item in dict)
            //{
            //    Console.WriteLine("键为：{0}， 值为：{1}", item.Key, item.Value);
            //}

            //Console.ReadKey();

            #endregion

            #region  List<T>的语法糖写法
            //List<T>
            //List<int> list = new List<int>() { 1, 2, 3, 4 };

            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}

            //Console.ReadKey();

            #endregion


        }

        private static int GetMax(List<int> list)
        {
            int max = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (max < list[i])
                {
                    max = list[i];
                }
            }
            return max;
        }

        private static void GetOdd(ref int[] num2, int[] num1)
        {
            int count = 0;
            for (int i = 0; i < num1.Length; i++)
            {
                if ( (num1[i] % 2) != 0)
                {
                    num2[count] = num1[i];
                    count++;
                }
            }  //for(int i = 0; i < num1.Length; i++)
        }


    }


}
