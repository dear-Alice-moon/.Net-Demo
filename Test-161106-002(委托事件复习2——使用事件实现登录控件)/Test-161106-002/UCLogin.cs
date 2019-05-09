using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_161106_002
{
    public partial class UCLogin : UserControl
    {
        public UCLogin()
        {
            InitializeComponent();
        }

        public event ValidateEventDelegate LoginValidating;
        //public delegate void ValidateEventDelegate(object sender, UserValidatingEventArgs e);
        //public class UserValidatingEventArgs : EventArgs

        private void button1_Click(object sender, EventArgs e)
        {
            if (LoginValidating != null)
            {
                UserValidatingEventArgs eventobject = new UserValidatingEventArgs(txtUid.Text.Trim(), txtPwd.Text.Trim(), false);
                LoginValidating(this, eventobject);
                if (eventobject.IsOk)
                {
                    this.BackColor = Color.Green;
                }
                else
                {
                    this.BackColor = Color.Red;
                }

            }
        }
    }
}
