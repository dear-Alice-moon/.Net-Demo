using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_161018_007
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ubb = txtUBB.Text.Trim();
            string html = ConvertUBBToHtml(ubb);
            txtHtml.Text = html;
        }

        private string ConvertUBBToHtml(string ubb)
        {
            //[b]传智播客[/b]
            ubb = Regex.Replace(ubb, @"\[b\](.+?)\[/b\]", "<b>$1</b>", RegexOptions.IgnoreCase);
            return ubb;
        }
    }
}
