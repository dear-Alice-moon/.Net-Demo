using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_160904_001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJiSuan_Click(object sender, EventArgs e)
        {
            //采集用户的输入
            int n1 = Convert.ToInt32(txtNum1.Text.Trim());
            int n2 = int.Parse(txtNum2.Text.Trim());
            Calculate cal = new Calculate(n1, n2);

            switch (cboCaoZuoFu.Text.Trim())
            {
                case "+": lblResult.Text = cal.Add().ToString();
                    break;
                case "-": lblResult.Text = cal.Sub().ToString();
                    break;
                case "*": lblResult.Text = cal.Mul().ToString();
                    break;
                case "/": lblResult.Text = cal.Div().ToString();
                    break;
                default: lblResult.Text = "运算结果未知！";
                    break;
            }


        }

        private void cboCaoZuoFu_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cboCaoZuoFu.Text = "+";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboCaoZuoFu.SelectedIndex = 0;
        }
    }
}
