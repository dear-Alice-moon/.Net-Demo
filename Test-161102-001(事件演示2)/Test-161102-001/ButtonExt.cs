using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_161102_001
{
    public class ButtonExt : Button
    {
        public ButtonExt() 
        {
            this.Text = "我的按钮";
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
        } 


    }
}
