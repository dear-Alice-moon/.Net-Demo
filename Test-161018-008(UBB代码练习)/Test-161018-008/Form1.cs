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

namespace Test_161018_008
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
            //多次Replace，每次处理一个替换。
            //string msg = "【你好，我发现一个[b]新网站[/b]，[b]大家[/b]来看呀[url=http://www.qq.com]秋秋[/url]，另外一个有时间也可以看看[url=http://www.rupeng.com]如鹏[/url]，还有[url=http://www.itcast.cn]传智播客[/url]】。吼吼！<b></b>";
            //1、替换【】
            ubb = Regex.Replace(ubb, @"\【(.+)\】", "$1");
            //Console.WriteLine(msg);
            //2、替换[b][/b]
            ubb = Regex.Replace(ubb, @"\[b\](.+?)\[/b\]", "<b>$1</b>");
            //3、替换[url][/url]
            ubb = Regex.Replace(ubb, @"\[url(.+?)\](.+?)\[/url\]", "<url$1>$2</url>");

            return ubb;
        }
    }
}
