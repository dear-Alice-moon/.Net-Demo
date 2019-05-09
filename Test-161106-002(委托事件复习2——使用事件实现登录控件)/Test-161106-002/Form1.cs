using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_161106_002
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //public delegate void ValidateEventDelegate(object sender, UserValidatingEventArgs e);
            ucLogin1.LoginValidating += new ValidateEventDelegate(ucLogin1_LoginValidating);  //ucLogin1_LoginValidating

        }

        void ucLogin1_LoginValidating(object sender, UserValidatingEventArgs e) 
        {
            if (e.Uid == "admin" && e.Password == "8888")
            {
                e.IsOk = true;
            }
            else
            {
                e.IsOk = false;
            }
        }

    }
}
