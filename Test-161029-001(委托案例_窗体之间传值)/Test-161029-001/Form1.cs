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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //textBox1.Text.Trim();
            //将Form1中TextBox中的内容传递给Form2中TextBox中的内容。
            Form2 f2 = new Form2(textBox1.Text.Trim(), UpdateTextBox);
            f2.Show();

        }

        private void UpdateTextBox(string val) 
        {
            this.textBox1.Text = val;
        }


    }

    public delegate void UpdateTextDelegate(string val);

}
