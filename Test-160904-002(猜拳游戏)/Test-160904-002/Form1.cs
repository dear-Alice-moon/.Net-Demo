using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_160904_002
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //点击石头
        private void btn1_Click(object sender, EventArgs e)  //sender表示触发的事件(事件源)，e表示与当前事件的相关信息。
        {
            //users.Text = btn1.Text;

            //把sender显示类型转换为button
            Button btn = (Button)sender;
            if (btn != null)
            {
                UserPlayer us = new UserPlayer();
                int n1 = us.ShowFist(btn.Text);
                users.Text = us.FistName;

                ComputerPlayer com = new ComputerPlayer();
                int n2 = com.ShowFist();
                computer.Text = com.FistName;

                CaiPanYuan cpy = new CaiPanYuan();
                //computer.Text = com.FistName;
                lblResult.Text = cpy.IsUserWin(n1, n2);

            }

            
        }

        //代码出现“重复”，

        //点击剪刀
        //private void btn2_Click(object sender, EventArgs e)
        //{
        //    //users.Text = btn2.Text;

        //    UserPlayer us = new UserPlayer();
        //    ComputerPlayer com = new ComputerPlayer();
        //    CaiPanYuan cpy = new CaiPanYuan();

        //    //computer.Text = com.FistName;
        //    int n1 = us.ShowFist(btn2.Text);
        //    int n2 = com.ShowFist();
        //    lblResult.Text = cpy.IsUserWin(n1, n2);
        //    users.Text = us.FistName;
        //    computer.Text = com.FistName;

        //}

        //点击布
        //private void btn3_Click(object sender, EventArgs e)
        //{
        //    //users.Text = btn3.Text;

        //    UserPlayer us = new UserPlayer();
        //    ComputerPlayer com = new ComputerPlayer();
        //    CaiPanYuan cpy = new CaiPanYuan();

        //    //computer.Text = com.FistName;
        //    int n1 = us.ShowFist(btn3.Text);
        //    int n2 = com.ShowFist();
        //    lblResult.Text = cpy.IsUserWin(n1, n2);
        //    users.Text = us.FistName;
        //    computer.Text = com.FistName;

        //}

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
