using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Test_002
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            #region  通过编程方式实现xml写入

            ////1、在内存中构建一个Dom对象
            //XmlDocument xmlDoc = new XmlDocument();
            ////增加了一个文档说明
            //XmlDeclaration xmlDeclaration = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", "yes");
            //xmlDoc.AppendChild(xmlDeclaration);

            ////为文档增加一个根元素
            ////2.1、创建一个根元素
            //XmlElement rootElement = xmlDoc.CreateElement("school");
            //xmlDoc.AppendChild(rootElement);

            ////3、为根元素里面增加子元素，接下来增加元素都要将子元素增加到rootElement元素下。
            //XmlElement xmlClassElement = xmlDoc.CreateElement("Class");

            //XmlAttribute attr = xmlDoc.CreateAttribute("id");
            //attr.Value = "c01";
            ////为class元素增加一个名字叫id的属性
            //xmlClassElement.Attributes.Append(attr);

            //rootElement.AppendChild(xmlClassElement);


            ////4、为class元素下创建一个student节点
            //XmlElement xmlStudentElement = xmlDoc.CreateElement("student");
            //XmlAttribute attrSid = xmlDoc.CreateAttribute("sid");
            //attrSid.Value = "s011";
            //xmlStudentElement.Attributes.Append(attrSid);

            //xmlClassElement.AppendChild(xmlStudentElement);


            //XmlElement xmlNameElement = xmlDoc.CreateElement("name");
            //xmlNameElement.InnerText = "黄林";
            ////5、向student节点下增加一个name节点和一个age节点
            //xmlStudentElement.AppendChild(xmlNameElement);

            //XmlElement xmlAgeElement = xmlDoc.CreateElement("age");
            //xmlAgeElement.InnerText = "18";
            //xmlStudentElement.AppendChild(xmlAgeElement);

            ////2、将该Dom对象写入到xml文件。
            //xmlDoc.Save("school.xml");


            #endregion


            #region  把List集合中的内容写入到一个xml文件中，通过XmlDocument方式写入Xml文件   
            //List<Person> list = new List<Person>();
            //list.Add(new Person() { Name = "黄林", Age = 19, Email= "huanglin@qq.com"});
            //list.Add(new Person() { Name = "许正龙", Age = 18, Email = "xzl@qq.com" });
            //list.Add(new Person() { Name = "张三", Age = 20, Email = "zhangsan@yahoo.com" });
            //list.Add(new Person() { Name = "李四", Age = 22, Email = "LZ@qq.com" });

            ////1、创建一个Dom对象
            //XmlDocument xDoc = new XmlDocument();
            ////2、编写文档定义
            //XmlDeclaration xmlDec = xDoc.CreateXmlDeclaration("1.0", "UTF-8", null);
            //xDoc.AppendChild(xmlDec);

            ////3、编写一个根节点
            //XmlElement xmlRoot = xDoc.CreateElement("List");
            //xDoc.AppendChild(xmlRoot);

            //#region  循环增加子元素Person
            ////4、循环创建Person节点
            //for (int i = 0; i < list.Count; i++)
            //{
            //    //4.1、循环创建Person元素
            //    XmlElement xmlPerson = xDoc.CreateElement("Person");
            //    XmlAttribute xmlAttrId = xDoc.CreateAttribute("id");
            //    xmlAttrId.Value = (i + 1).ToString();
            //    //将属性增加到Person节点中
            //    xmlPerson.Attributes.Append(xmlAttrId);


            //    //4.2、在这里向Person节点下增加子节点
            //    //创建Name
            //    XmlElement xmlName = xDoc.CreateElement("Name");
            //    xmlName.InnerText = list[i].Name;
            //    xmlPerson.AppendChild(xmlName);

            //    //创建Age节点
            //    XmlElement xmlAge = xDoc.CreateElement("Age");
            //    xmlAge.InnerText = list[i].Age.ToString();
            //    xmlPerson.AppendChild(xmlAge);

            //    //创建Email节点
            //    XmlElement xmlEmail = xDoc.CreateElement("Email");
            //    xmlEmail.InnerText = list[i].Email;
            //    xmlPerson.AppendChild(xmlEmail);

            //    //最后把Person加到根节点
            //    xmlRoot.AppendChild(xmlPerson);

            //}

            //#endregion

            ////5、将xmlDocument对象写入到文件中
            //xDoc.Save("List.xml");


            #endregion


            #region  通过XDocument方式写入xml文件

            List<Person> list = new List<Person>();
            list.Add(new Person() { Name = "黄林", Age = 19, Email = "huanglin@qq.com" });
            list.Add(new Person() { Name = "许正龙", Age = 18, Email = "xzl@qq.com" });
            list.Add(new Person() { Name = "张三", Age = 20, Email = "zhangsan@yahoo.com" });
            list.Add(new Person() { Name = "李四", Age = 22, Email = "LZ@qq.com" });

            //1、创建一个Dom对象
            XDocument xDoc = new XDocument();
            XDeclaration xDec = new XDeclaration("1.0", "UTF-8", null);
            //xDoc.Add(xDec);
            xDoc.Declaration = xDec;

            //2、创建节点
            XElement rootElement = new XElement("List");
            xDoc.Add(rootElement);


            //3、循环List集合创建Person节点
            for (int i = 0; i < list.Count; i++)
            {
                //为每个Person对象创建一个Person元素
                XElement xElementPerson = new XElement("Person");
                xElementPerson.SetElementValue("id", (i + 1).ToString());

                xElementPerson.SetElementValue("Name", list[i].Name);
                xElementPerson.SetElementValue("Age", list[i].Age);
                xElementPerson.SetElementValue("Email", list[i].Email);
                rootElement.Add(xElementPerson);
            }

            //4、保存到文件
            xDoc.Save("ListNew.xml");


            #endregion

            MessageBox.Show("Ok");

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


        public void SayHi() 
        {
            Console.WriteLine("Hi~~~`，你好！");
        }


    }


}
