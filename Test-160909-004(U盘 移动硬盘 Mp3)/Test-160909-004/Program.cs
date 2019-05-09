using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160909_004
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer dell = new Computer();

            UDisk sandisk = new UDisk();
            //dell.Dev = sandisk;

            MobileDisk westData = new MobileDisk();
            //dell.Dev = westData;

            Mp3 mp3 = new Mp3();
            dell.Dev = mp3;

            
            dell.PC_ReadData();
            dell.PC_WriteData();

            Console.ReadKey();

        }
    }

    class Computer 
    {
        public MobileStorage Dev
        {
            get;
            set;
        }

        public void PC_WriteData() 
        {
            Dev.Write();
        }

        public void PC_ReadData() 
        {
            Dev.Read();
            //Console.WriteLine("电脑在读数据(^__^)");

        }


    }


    /// <summary>
    /// 可移动设备
    /// </summary>
    abstract class MobileStorage 
    {
        public abstract void Read();

        public abstract void Write();

    }

    /// <summary>
    /// U盘
    /// </summary>
    class UDisk : MobileStorage 
    {
        public override void Read()
        {
            Console.WriteLine("U盘在读取数据......");
        }

        public override void Write()
        {
            Console.WriteLine("U盘在写入数据......");
        }

    }

    /// <summary>
    /// 移动硬盘
    /// </summary>
    class MobileDisk : MobileStorage 
    {
        public override void Read()
        {
            Console.WriteLine("移动硬盘在读取数据......");
        }

        public override void Write()
        {
            Console.WriteLine("移动硬盘在写入数据......");
        }
    }

    /// <summary>
    /// Mp3
    /// </summary>
    class Mp3 : MobileStorage 
    {
        public override void Read()
        {
            Console.WriteLine("Mp3在读取数据......");
        }

        public override void Write()
        {
            Console.WriteLine("Mp3在写入数据......");
        }

        public void PlayMusic() 
        {
            Console.WriteLine("Mp3在放音乐！");
        }

    }


}
