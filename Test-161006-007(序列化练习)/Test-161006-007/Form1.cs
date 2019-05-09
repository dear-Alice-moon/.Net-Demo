using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Test_161006_007
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Dictionary<string, string> dic = new Dictionary<string, string>();

        private void Form1_Load(object sender, EventArgs e)
        {
            //窗体加载时，反序列化，并获取集合，然后将集合中的内容显示到
            //ListBox控件中(只显示标题)。
            //个人猜测使用Dictionary<TKey, TValue>字典集合。

            //将信息进行反序列化
            BinaryFormatter bff = new BinaryFormatter();
            using (FileStream fsRead = new FileStream("Test.txt", FileMode.Open))
            {
                Object obj = bff.Deserialize(fsRead);
                Dictionary<string, string> dicc = obj as Dictionary<string, string>;
                listBox1.Text = dicc.Keys.ToString();
            }
            


        }

        private void button2_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string strKey = txtNum1.Text.Trim();
            string strValue = txtNum2.Text.Trim();

            dic.Add(strKey, strValue);

            //将信息进行序列化
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fsWriter = new FileStream("Test.txt", FileMode.Create))
            {
                bf.Serialize(fsWriter, dic);
            }

            //清楚txtNuml.Text、txtNum2.Text文本框中内容！！！
            txtNum1.Clear();
            txtNum2.Clear();

        }
    }
}
