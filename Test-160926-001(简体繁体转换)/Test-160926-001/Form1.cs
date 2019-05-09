using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_160926_001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Dictionary<char, char> dict = new Dictionary<char, char>();

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadZiFu();
        }

        private void LoadZiFu()
        {
            //1、读取本文文件
            string[] strNum = File.ReadAllLines("简体-繁体.txt", Encoding.Default);
            for (int i = 0; i < strNum.Length; i++)
            {
                string[] parts = strNum[i].Split('=');
                dict.Add(parts[0][0], parts[1][0]);

            }

        }

        private void btn_Click(object sender, EventArgs e)
        {
            string jianTi = txtJianTi.Text.Trim();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < jianTi.Length; i++)
            {
                if (dict.ContainsKey(dict[jianTi[i] ]))
                {
                    sb.Append(dict[jianTi[i]]);
                }
                else
                {
                    sb.Append(dict[jianTi[i]]);
                }
            }

            txtFanTi.Text = sb.ToString();

        }


    }
}
