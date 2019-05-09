using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160923_005
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  练习1， 自写程序，实验未成功！！！
            //ArrayList list1 = new ArrayList(new string[] { "a", "b", "c", "d", "e" });
            //ArrayList list2 = new ArrayList(new string[] { "d", "e", "f", "g", "h" });

            //for (int i = 0; i < list1.Count; i++)
            //{
            //    for (int j = 0; j < list2.Count; j++)
            //    {
            //        if (list1[i] == list2[j])
            //        {
            //            list2.Remove(list2[j]);
            //        }
            //    }

            //    //list1.AddRange(list2);

            //    for (int k = 0; k < list2.Count; k++)
            //    {
            //        list1.Add(list2[k]);
            //    }


            //}  //for(int i = 0; i < list1.Count; i++)

            //for (int i = 0; i < list1.Count; i++)
            //{
            //    Console.WriteLine(list1[i]);
            //}

            //Console.ReadKey();

            #endregion

            #region  练习1，视频中老师所讲代码
            //ArrayList arrList = new ArrayList(new string[] { "a", "b", "c", "d", "e" });
            //ArrayList arrList2 = new ArrayList(new string[] { "d", "e", "f", "g", "h" });

            //for (int i = 0; i < arrList2.Count; i++)
            //{
            //    if (!arrList.Contains(arrList2[i]) )
            //    {
            //        arrList.Add(arrList2[i]);
            //    }
            //}

            //Console.WriteLine("arrList的数量为：{0}", arrList.Count);
            //for (int i = 0; i < arrList.Count; i++)
            //{
            //    Console.WriteLine(arrList[i]);
            //}

            //Console.ReadKey();

            #endregion


            #region  练习2
            //ArrayList list = new ArrayList();
            //Random r = new Random();
            
            //======================================
            //视频中老师所讲代码

            //ArrayList arrList = new ArrayList();
            //Random random = new Random();
            //int count = 0;
            //while (arrList.Count < 10)
            //{
            //    //Random random = new Random();

            //    int n = random.Next(1, 101);
            //    if (( n % 2 == 0 ) && ( !arrList.Contains(n) ))
            //    {
            //        arrList.Add(n);
            //    }
            //    count++;
            //}

            //Console.WriteLine("arrList的数量为：{0}", arrList.Count);
            //for (int i = 0; i < arrList.Count; i++)
            //{
            //    Console.WriteLine(arrList[i]);
            //}

            //Console.WriteLine("======={0}======", count);

            //Console.ReadKey();

            ////Environment.TickCount
            //Random random = new Random(88);
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(random.Next(1, 101));
            //}

            //Console.ReadKey();

            #endregion


            #region  练习3，实验成功。(^__^)
            //string str = "2 7 8 3 22 9 5 11";
            //ArrayList list = new ArrayList();
            //ArrayList list2 = new ArrayList();
            //list.AddRange(str.Split(' '));
            //list2.AddRange(str.Split(' '));

            #region  实验代码1(冗余代码)
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}
            #endregion

            //int count = 0;
            //for (int i = 0; i < list.Count; i++)
            //{
            //    if ( ( Convert.ToInt32(list[i]) % 2) !=0)   //( ( Convert.ToInt32(list[i]) % 2 ) != 0) 
            //    {
            //        list[count] = list[i] + " ";
            //        count++;
            //    }
            //}

            #region  实验代码2  (冗余代码)
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}

            //Console.WriteLine("=================");
            //Console.WriteLine(count);  //count = 5

            #endregion

            //for (int i = 0; i < list2.Count; i++)
            //{
            //    if ((Convert.ToInt32(list2[i]) % 2) == 0)   
            //    {
            //        list[count] = list2[i] + " ";
            //        count++;
            //    }
            //}

            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.Write(list[i]);
            //}


            Console.ReadKey();

            #endregion


            #region  练习3 视频中老师所讲代码
            ArrayList arrayListOdd = new ArrayList();
            ArrayList arrayListEven = new ArrayList();
            string str = "2 7 8 3 22 9 5 11";
            string[] strNum = str.Split(' ');

            for (int i = 0; i < strNum.Length; i++)
            {
                if (int.Parse(strNum[i]) % 2 != 0)
                {
                    arrayListOdd.Add(strNum[i]);
                }
                else
                {
                    arrayListEven.Add(strNum[i]);
                }
            }

            arrayListOdd.AddRange(arrayListEven);
            //下列for循环可实现预期目标。
            //for (int i = 0; i < arrayListOdd.Count; i++)
            //{
            //    Console.Write(arrayListOdd[i] + " ");
            //}

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < arrayListOdd.Count; i++)
            {
                sb.Append(arrayListOdd[i] + " ");
            }

            //Console.WriteLine(sb);  //该语句可实现预期目标
            Console.WriteLine(sb.ToString().Trim());

            Console.ReadKey();

            #endregion

        }
    }

}
