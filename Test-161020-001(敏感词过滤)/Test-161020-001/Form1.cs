using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_161020_001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //点击发帖验证帖子是否合法
        private void button1_Click(object sender, EventArgs e)
        {
            //用来存储需要审核的关键词
            StringBuilder sbMode = new StringBuilder();
            //用来存储绝对禁止的关键词
            StringBuilder sbBanned = new StringBuilder();
            string[] lines = File.ReadAllLines("1.txt", Encoding.Default);

            for (int i = 0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split('=');
                if (parts[1] == "{MOD}")
                {
                    sbMode.AppendFormat("{0}|", parts[0]);
                }
                else if (parts[1] == "{BANNED}")
                {
                    sbBanned.AppendFormat("{0}|", parts[0]);
                }
            }

            sbMode.Remove(sbMode.Length - 1, 1);
            sbBanned.Remove(sbBanned.Length - 1, 1);

            string userInput = textBox1.Text.Trim();

            //验证是否有禁止发帖的关键词
            //"fdsafdsafdsacb"   "a|b|c"
            
            if (Regex.IsMatch(userInput, sbMode.ToString()))
            {
                MessageBox.Show("需要审核！");
            }
            else if (Regex.IsMatch(userInput, sbBanned.ToString()))
	        {
		        MessageBox.Show("禁止发帖！");
	        }
            else
	        {
                MessageBox.Show("可以发帖！");
	        }


        }
    }
}
