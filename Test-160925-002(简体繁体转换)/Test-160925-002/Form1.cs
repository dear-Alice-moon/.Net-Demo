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

namespace Test_160925_002
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
            //加载简繁体字库到Dictionary集合中
            LoadZiFu();
        }

        private void LoadZiFu()
        {
            //1、读取文本文件
            string[] line = File.ReadAllLines("简体-繁体.txt", Encoding.Default);
            for (int i = 0; i < line.Length; i++)
            {
                string[] parts = line[i].Split('=');
                dict.Add(parts[0][0], parts[1][0]);
            }

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            //1、获取用户输入的简体
            string str = txtJianTi.Text.Trim();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                if (dict.ContainsKey(str[i]))
                {
                    sb.Append(dict[str[i]]);
                }
                else
                {
                    sb.Append(str[i]);
                }
            }

            txtFanTi.Text = sb.ToString();
        }


    }
}
