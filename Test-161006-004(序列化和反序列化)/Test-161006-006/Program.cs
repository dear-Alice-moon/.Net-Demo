using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Test_161006_004;  //记得添加序列化的引用

namespace Test_161006_006
{
    class Program
    {
        static void Main(string[] args)
        {
            //二进制反序列化的时候注意：
            //1、必须获取被序列化的对象的类型所在的程序集，因为：反序列化要
            //根据序列化文件，重新还原该对象，而序列化文件中包含哪些数据信息，
            //并不包含该对象的类型相关的信息，例如：该对象是继承自那个父类，实现了
            //哪些接口，类型中包含哪些方法等。这些信息在对象序列化文件中都不
            //包含，要获取这些信息必须通过该类型的程序集来获取。


            //1、创建序列化器
            BinaryFormatter bf = new BinaryFormatter();
            //1.1、创建读取文件的文件流
            using (FileStream fsRead = new FileStream("person.txt", FileMode.Open) )
            {
                //2、执行反序列化
                object obj = bf.Deserialize(fsRead);
                Person person = obj as Person;
                Console.WriteLine(person.Name);
                Console.WriteLine(person.Age);
                Console.WriteLine(person.Email);

            }

            Console.WriteLine("Ok");
            Console.ReadKey();


        }
    }
}
