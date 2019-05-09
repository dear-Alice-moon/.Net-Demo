using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_161108_001
{
    class Program
    {
        static void Main(string[] args)
        {
            Type typePerson = typeof(Person);
            Type typeStudent = typeof(Student);
            Type typeTeacher = typeof(Teacher);


            #region  IsAssignableFrom()方法

            //表示要检查，能否将typeStudent的类型的对象赋值给typePerson的类型。
            //bool b = typePerson.IsAssignableFrom(typeStudent);
            //Console.WriteLine(b);  //true  

            //bool b1 = typePerson.IsAssignableFrom(typeTeacher);
            //Console.WriteLine(b1);  //true  

            //bool b2 = typeStudent.IsAssignableFrom(typeTeacher);
            //Console.WriteLine(b2);

            //Console.ReadKey();

            #endregion


            #region  IsInstanceofType，检查某个对象是否是某个类型。

            //object objPerson = Activator.CreateInstance(typePerson);
            //object objStudent = Activator.CreateInstance(typeStudent);
            //object objTeacher = Activator.CreateInstance(typeTeacher);

            ////检查某个对象是否是某个类型的实例。
            //Console.WriteLine(typePerson.IsInstanceOfType(objPerson));
            //Console.WriteLine(typePerson.IsInstanceOfType(objStudent));
            //Console.WriteLine(typePerson.IsInstanceOfType(objTeacher));

            //Console.WriteLine(typeTeacher.IsInstanceOfType(objStudent));  //False
            //Console.ReadKey();

            #endregion


            #region  bool IsSubclassOf(type c):

            //Console.WriteLine(typePerson.IsSubclassOf(typeStudent));  //false
            //Console.WriteLine(typePerson.IsSubclassOf(typeTeacher));  //false

            //Console.WriteLine(typeStudent.IsSubclassOf(typePerson));
            //Console.WriteLine(typeTeacher.IsSubclassOf(typePerson));

            //Type typeInterface = typeof(Iinterface);

            //验证是否是父子类关键，和接口无关。
            //Console.WriteLine(typeStudent.IsSubclassOf(typeInterface));
            //Console.WriteLine(typeTeacher.IsSubclassOf(typeInterface));

            //Console.ReadKey();

            #endregion


            #region  IsAbstraot

            Type typeInterface = typeof(Iinterface);  //接口类型
            Type typeMyClass1 = typeof(MyClass1);  //抽象类型
            Type typeMyClass2 = typeof(MyClass2);  //静态类型

            Console.WriteLine(typePerson.IsAbstract);  //false
            Console.WriteLine(typeStudent.IsAbstract);  //false 
            Console.WriteLine(typeTeacher.IsAbstract);  //false
            Console.WriteLine(typeInterface.IsAbstract);  //true
            Console.WriteLine(typeMyClass1.IsAbstract);  //true
            Console.WriteLine(typeMyClass2.IsAbstract);  //true/false ?
            

            Console.ReadKey();

            #endregion


        }
    }

    public class Person 
    {
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


    }

    public class Student : Person, Iinterface 
    {

    }

    public class Teacher : Person, Iinterface 
    {

    }

    public interface Iinterface 
    {

    }

    public abstract class MyClass1 
    {

    }

    public static class MyClass2 
    {

    }



}
