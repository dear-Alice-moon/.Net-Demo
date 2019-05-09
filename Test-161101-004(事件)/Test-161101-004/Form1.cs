using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_161101_004
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //int count = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("按钮被单击了！");  //第一次写
            

        }

        private void uControlButtonExt1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("NumberOne");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            uControlButtonExt1.TripleClick = () =>
            {
                MessageBox.Show("在窗体1中被点击了3次！");
            };

            //用事件实现的3连击
            //事件不能用=赋值，只能用+=或-=来赋值。
            uControlButtonExt21.TripleClick += () =>
            {
                MessageBox.Show("第二个控件被点击了3次！");
            };


        }
    }
}
