using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160909_004_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer dell = new Computer();

            UDisk sandisk = new UDisk();
            //dell.Dev = sandisk;

            MobileDisk westData = new MobileDisk();
            dell.Dev = westData;

            dell.PC_ReadData();
            dell.PC_WriteData();

            Console.ReadKey();
        }
    }

    class Computer 
    {
        public MobileStore Dev
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
            //Console.WriteLine("电脑在读取数据(^__^)");
        }

    }

    abstract class MobileStore 
    {
        public abstract void Read();

        public abstract void Write();
    }

    class UDisk : MobileStore 
    {
        public override void Read()
        {
            Console.WriteLine("这是U盘在读数据......");
        }

        public override void Write()
        {
            Console.WriteLine("这是U盘在写数据......");
        }
    }

    class MobileDisk : MobileStore 
    {
        public override void Read()
        {
            Console.WriteLine("这是移动硬盘在读数据......");
        }

        public override void Write()
        {
            Console.WriteLine("这是移动硬盘在写读数据......");
        }

    }

    class Mp3 : MobileStore 
    {
        public override void Read()
        {
            Console.WriteLine("这是Mp3在读数据......");
        }

        public override void Write()
        {
            Console.WriteLine("这是Mp3在写读数据......");
        }

        public void PlayMusic() 
        {
            Console.WriteLine("这是Mp3在唱歌......");
        }

    }


}
