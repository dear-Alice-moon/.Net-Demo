using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_161102_001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ucLogin1.UserLoginValidating += new Action<object, UserLoginEventArgs>(ucLogin1_UserLoginValidating);

            
        }

        void ucLogin1_UserLoginValidating(object arg1, UserLoginEventArgs arg2)
        {
            if (arg2.LoginId == "admin" && arg2.LoginPassword == "8888")
            {
                arg2.IsOk = true;    //在这个地方不知道为什么"LoginId == "admin"、LoginPassword == "888888""而跳过本行代码，导致结果运行错误！
            }
            else
            {
                arg2.IsOk = false;
            }
        }

        ////事件的校验方法
        //void ucLogin1_UserLoginValidating() 
        //{
        //    //获取用户输入的内容，然后校验。
        //}

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void buttonExt1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("你好！！！");
        }

        

    }
}
