using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_161101_004
{
    public partial class UControlButtonExt : UserControl
    {
        public UControlButtonExt()
        {
            InitializeComponent();
        }

        int count = 0;
        public Action TripleClick;

        private void button1_Click(object sender, EventArgs e)
        {
            #region  方法一，写死的一种方法。

            //count++;
            //if (count >= 3)
            //{
            //    MessageBox.Show("Number Three!");  //第二次写
            //    count = 0;
            //}

            #endregion

            #region  用委托实现

            count++;
            if (count >= 3)
            {
                //MessageBox.Show("1!");
                if (TripleClick != null)
                {
                    TripleClick();
                }
                count = 0;
            }
            

            #endregion




        }

        private void UControlButtonExt_Load(object sender, EventArgs e)
        {

        }
    }
}
