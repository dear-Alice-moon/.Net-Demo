using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_161029_001
{
    public partial class Form2 : Form
    {
        private string p;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string p, UpdateTextDelegate updateText) : this()
        {
            this.textBox1.Text = p;
            this._update = updateText;
        }

        private UpdateTextDelegate _update;

        private void button1_Click(object sender, EventArgs e)
        {
            //1、将当前窗体中的文本框中的值，赋值给"窗体1"中的文本框
            //
            this._update(textBox1.Text.Trim());

            //关闭窗体2
            this.Close();
            
        }
    }

    //无论UpdateTextDelegate委托放在Form1中还是Form2中均可
    //public delegate void UpdateTextDelegate(string val);

}
