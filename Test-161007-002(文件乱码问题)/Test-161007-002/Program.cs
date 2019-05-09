using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_161007_002
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  测试1
            //string msg = File.ReadAllText("2.txt", Encoding.Default);  //File.ReadAllText("1.txt");
            //Console.WriteLine(msg);

            //Console.ReadKey();

            #endregion

            #region  测试2

            ////Encoding encoding = Encoding.GetEncoding("GB2312");
            //EncodingInfo[] infos = Encoding.GetEncodings();

            //foreach (var item in infos)
            //{
            //    //File.ReadAllLines()
            //    File.AppendAllText("encoding.txt", string.Format("{0}, {1}, {2} \t\n", item.CodePage, item.DisplayName, item.Name));
            //}

            //Console.WriteLine("Ok");
            //Console.ReadKey();

            #endregion

            #region  测试3
            FileInfo file = new FileInfo(@"encoding.txt");

            DirectoryInfo dirInfo = new DirectoryInfo(@"E:\C# Workstation");

            #region  冗余不完善代码

            //string[] names = Directory.GetLogicalDrives();
            //foreach (var item in names)
            //{
            //    //DriveInfo dirveInfo = new DriveInfo();
            //    //dirveInfo.DriveType = DriveType.

            //    //DriveInfo.GetDrives();

            //}

            #endregion

            DriveInfo[] drivInfo = DriveInfo.GetDrives();

            foreach (var item in drivInfo)
            {
                Console.WriteLine("盘符名称为：{0}", item);
            }

            Console.ReadKey();

            #endregion

        }
    }


}
