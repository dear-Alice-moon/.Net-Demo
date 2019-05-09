using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Test002
{
    class Program
    {
        static void Main(string[] args)
        {

            #region  Type类型的介绍及简单运用
            //对Type类型的介绍

            ////1、怎么获取一个类型的Type(该类型的类型元数据)
            //MyClass m = new MyClass();
            //Type type1 = m.GetType();  //获得了类型的MyClass对应的Type

            ////通过typeof关键字，无需获取MyClass类型的对象就可以拿到MyClass的Type
            //Type type2 = typeof(MyClass);

            //拿到这个Type能干啥？
            //Type typeMyClass = typeof(MyClass);

            //1、可以获取当前类型的父类是谁？
            //Console.WriteLine(typeMyClass.BaseType.ToString());
            //Console.WriteLine(typeMyClass.BaseType.BaseType.ToString());
            //Console.WriteLine(typeMyClass.BaseType.BaseType.BaseType.ToString());

            //2、获取当前类中的所有的字段信息
            //这里只能获取非私有字段，如果要想获取私有字段则需要采取其他方法。
            //FieldInfo[] fields = typeMyClass.GetFields();
            //for (int i = 0; i < fields.Length; i++)
            //{
            //    Console.WriteLine(fields[i].Name);
            //}

            //3、获取当前类中的属性
            //PropertyInfo[] infos = typeMyClass.GetProperties();
            //for (int i = 0; i < infos.Length; i++)
            //{
            //    Console.WriteLine(infos[i].Name);
            //}

            //Console.ReadKey();

            #endregion


            #region  动态加载程序集并且调用类型的成员

            //动态加载程序集
            //根据程序的路径，动态加载一个程序集
            Assembly asm = Assembly.LoadFile(@"E:\C# Workstation\Test-161103-001(反射)\Test-161103-001\bin\Debug\Test-161103-001.exe");

            //1.1、获取该程序集中的所有类型
            //Type[] types = asm.GetTypes();
            //for (int i = 0; i < types.Length; i++)
            //{
            //    Console.WriteLine(types[i].FullName);
            //}


            //1.2、获取所有的public的类型
            //Type[] types = asm.GetExportedTypes();
            //for (int i = 0; i < types.Length; i++)
            //{
            //    Console.WriteLine(types[i].FullName);
            //}

            //1.3、获取指定的类型
            //获取Person类型的Type
            Type typePerson = asm.GetType("Test_161103_001.Person");



            //2、获取某个类型中的成员，调用
            //2.1、调用Person类中的方法:
            //2.2、调用SayHi方法
            //2.2.1、获取SayHi方法
            //MethodInfo method = typePerson.GetMethod("SayHi");

            ////创建一个Person类型的对象
            ////根据指定的Type，创建一个该类型的对象。
            //object obj = Activator.CreateInstance(typePerson);
            ////调用该方法
            //method.Invoke(obj, null);

            //=========调用SayHello的无参数的重载==========
            //MethodInfo method = typePerson.GetMethod("SayHello", new Type[] { typeof(string) });

            ////调用该重载方法
            //method.Invoke(Activator.CreateInstance(typePerson), new object[] { "大家好。。。" });

            ////如果方法有返回值的话，直接接受Invoke()方法的返回值就可以。

            //==========通过Type来创建对象=========
            //1、根据Person的Type创建一个Person类型
            //typePerson.GetMethod().GetParameters()[0].ParameterType
            //object obj = Activator.CreateInstance(typePerson);
            //Console.WriteLine(obj);

            //通过调用指定的构造函数来创建对象。
            ConstructorInfo info = typePerson.GetConstructor(new Type[] { typeof(string), typeof(int), typeof(string) });

            //调用构造函数来创建对象
            object obj = info.Invoke(new object[] { "张三", 18, "zhangsan@yahoo.com" });
            
            //通过反射获取指定对象的属性的值
            PropertyInfo pinfo = typePerson.GetProperty("Name");
            string name = pinfo.GetValue(obj, null).ToString();
            Console.WriteLine(name);
            
            Console.WriteLine(obj);


            Console.ReadKey();

            #endregion



        }
    }

    public class MyClass 
    {
        public string[] _bfs;
        private string[] _gfs;

        public string Name
        {
            get;
            set;
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
            Console.WriteLine("不要给自己的懒惰找借口，努力才是硬道理。");
        }

        private void SayHello() 
        {
            Console.WriteLine("最近你还好么？？？");
        }


    }

}
