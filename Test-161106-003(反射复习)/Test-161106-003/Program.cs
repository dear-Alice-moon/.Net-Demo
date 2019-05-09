using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Test_161106_003
{
    class Program
    {
        static void Main(string[] args)
        {
            //反射
            //1、动态加载程序集
            Assembly ams = Assembly.LoadFile(@"E:\C# Workstation\Test-161106-003(反射复习)\Test-161106-003\bin\Debug\Test-161106-003.exe");


            //2、获取类型
            //获取所有类型
            //ams.GetTypes();
            //ams.GetExportedTypes();  //获取所有public类型
            //获取Person的Type
            Type typePerson = ams.GetType("Test_161106_003.Person");



            //3、获取类型中的成员
            //获取所有方法
            //typePerson.GetMethods();
            //typePerson.GetProperties();   //获取所有公共属性
            //typePerson.GetFields();  //获取所有公共字段
            //typePerson.GetEvents();  //获取所有事件
            //typePerson.GetMembers();  //获取所有成员

            //MethodInfo[] methods = typePerson.GetMethods();  //返回当前Type类型中所有公共的方法 
            //for (int i = 0; i < methods.Length; i++)
            //{
            //    Console.WriteLine(methods[i].Name);
            //}

            //调用SayHi方法
            MethodInfo methodSayHi = typePerson.GetMethod("SayHello");
           
            //创建对象
            object obj = Activator.CreateInstance(typePerson);
            

            //4、调用成员
            methodSayHi.Invoke(obj, null);  //未将对象引用设置到对象的实例


            Console.ReadKey();
        }
    }
}
