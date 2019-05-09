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

namespace Test_161006_002
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            #region  不完善的加载目录和目录中的文件(加载一级目录)

            //string path = @"D:\Youku Files\youkudisk";
            ////1、把指定目录下的所有子目录加载到TreeView上。
            //string[] dirs = Directory.GetDirectories(path);
            //foreach (string dir in dirs)
            //{
            //    //treeView1.Nodes.Add(dir);
            //    treeView1.Nodes.Add(Path.GetFileName(dir));
            //}

            ////2、把指定目录下的所有子文件加载到TreeView上。
            //string[] files = Directory.GetFiles(path);
            //foreach (var item in files)
            //{
            //    //treeView1.Nodes.Add(item);
            //    treeView1.Nodes.Add(Path.GetFileName(item));
            //}

            #endregion

            #region  递归加载
            string path = @"D:\Youku Files\youkudisk";

            LoadData(path, treeView1.Nodes);


            #endregion

        }

        private void LoadData(string path, TreeNodeCollection treeNodeCollection)
        {
            //1、获取子目录并加载
            string[] dirs = Directory.GetDirectories(path);
            foreach (string item in dirs)
            {
                //TreeNode node = treeView1.Nodes.Add(Path.GetFileName(dir));  //该行代码有误！

                TreeNode node = treeNodeCollection.Add(Path.GetFileName(item));
                //LoadNodes(path, node.Nodes);  //该行代码错误！
                LoadData(item, node.Nodes);

            }

            //2、获取子文件并加载
            string[] files = Directory.GetFiles(path);
            foreach (string item in files)
            {
                //TreeNode file = treeView1.Nodes.Add(Path.GetFileName(item));
                treeNodeCollection.Add(Path.GetFileName(item));
            }


        }




    }



}
