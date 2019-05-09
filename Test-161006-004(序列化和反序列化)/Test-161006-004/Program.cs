using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Xml.Serialization;
using System.IO;

namespace Test_161006_004
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Name = "杨中科";
            p1.Age = 19;
            p1.Email = "yzk@itcast.cn";
            p1.BenChi = new Car();


            #region  Json序列化
            //Json序列化
            //JavaScriptSerializer jsSer = new JavaScriptSerializer();
            //string msg = jsSer.Serialize(p1);

            //Console.WriteLine(msg);
            //Console.ReadKey();

            #endregion


            #region  xml序列化
            //xml序列化
            XmlSerializer xml = new XmlSerializer(typeof(Person)); 
            //xml



            #endregion


            #region  二进制序列化
            //序列化只序列化数据，如字段、属性的值。
            //将Person对象序列化后保存到磁盘上，要操作磁盘文件所以
            //需要使用文件流(FileStream)

            //二进制序列化注意点
            //1、被序列化的对象的类型必须标记为“可序列化”。
            //2、被序列化的类的所有父类也必须标记为“可序列化”。
            //3、要求被序列化的对象的类型中的所有字段(属性)的类型也必须标记为“可序列化”。
            //


            //1、二进制序列化步骤：
            //1、创建序列化器
            BinaryFormatter bf = new BinaryFormatter();
            //1.1、创建一个写入文件流
            using (FileStream fsWrite = new FileStream("person.txt", FileMode.Create) )
            {
                //2、开始执行序列化
                bf.Serialize(fsWrite, p1);
            }
            Console.WriteLine("序列化完毕！！！");
            Console.ReadKey();

            #endregion



        }
    }


    [Serializable]
    public class Animal 
    {
        public void Eat() 
        {
            Console.WriteLine("吃东西");
        }

    }



    [Serializable]
    public class Person : Animal
    {

        public Car BenChi
        {
            get;
            set;
        }

        [NonSerialized]
        private string _name;
        public string Name
        {
            get 
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public int Age
        {
            get;
            set;
        }

        public string Email
        {
            get;
            set;
        }

        public void Say() 
        {
            Console.WriteLine("你好！！！");
        }

        public MyClass SayHello(MyClass mc) 
        {
            return new MyClass();
        }


    }

    public class MyClass   //可不用序列化
    {

    }


    [Serializable]
    public class Car 
    {

    }

}
