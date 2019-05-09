using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Test_161009_003
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region  自写代码，程序无误，但没能实现预期目标。  ——  2016年10月9日
            ////1、创建一个读取源文件的文件流
            //using (FileStream fsRead = new FileStream(txtSource.Text.Trim(), FileMode.Open, FileAccess.Read))
            //{
            //    //2、创建一个写入源文件的文件流
            //    using (FileStream fsWrite = new FileStream(txtTarget.Text.Trim(), FileMode.Create, FileAccess.Write ) )
            //    {
            //        //创建一个中间缓冲区
            //        byte[] bytes = new byte[1024 * 1024 * 5];
            //        int r = fsRead.Read(bytes, 0, bytes.Length);
            //        int x = 0;
            //        if (x <= 255)
            //        {
            //            fsWrite.Write(bytes, 0, x);
            //        }
            //        else
            //        {
            //            while (r > 0)
            //            {
            //                x = 255 - r;
            //                fsWrite.Write(bytes, 0, x);
            //                r = fsRead.Read(bytes, 0, bytes.Length);
            //            }
            //        }
            //        if (fsWrite.Position == fsRead.Length)
            //        {
            //            MessageBox.Show("加密成功！");
            //        }

            //    }

            //}

            #endregion

            JiaMi(txtSource.Text.Trim(), txtTarget.Text.Trim());

        }

        private void JiaMi(string p1, string p2)
        {
            //创建一个读取源文件的文件流
            using (FileStream fsRead = new FileStream(p1, FileMode.Open, FileAccess.Read) )
            {
                //创建一个写入文件的文件流
                using (FileStream fsWrite = new FileStream(p2, FileMode.Create, FileAccess.Write) )
                {
                    byte[] bytes = new byte[1024 * 5];
                    int count = 0;
                    while ((count = fsRead.Read(bytes, 0, bytes.Length)) > 0)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            bytes[i] = Convert.ToByte(byte.MaxValue - bytes[i]);
                        }
                        fsWrite.Write(bytes, 0, count);
                        //byte byt = Convert.ToByte(byte.MaxValue - count);

                        //拷贝，直接写拷贝代码
                        //fsWrite.Write(bytes, 0, count);

                    }  //while ((count = fsRead.Read(bytes, 0, bytes.Length)) > 0)

                }  //using (FileStream fsWrite = new FileStream(p2, FileMode.Create, FileAccess.Write) )
                
            }

            MessageBox.Show("文件加密完成！！！");
        }

        private void txtTarget_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
