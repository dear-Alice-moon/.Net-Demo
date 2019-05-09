using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyNotepad.ExtInterface;


namespace Test_161110_002
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;
                File.WriteAllText(path, textBox1.Text.Trim());
            }

        }

        /// <summary>
        /// 主程序中的窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //1、加载addons目录下的所有的dll文件
            string addons = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "addons");

            //搜索addons下的所有的dll文件
            string[] dlls = Directory.GetFiles(addons, "*.dll");

            //2、循环将每个dll文件都加载起来
            foreach (string dllPath in dlls)
            {
                //动态加载当前循环的dll文件
                Assembly assembly = Assembly.LoadFile(dllPath);

                //获取dll文件中的类型
                //获取当前dll中的所有的public类型
                Type[] types = assembly.GetExportedTypes();
                //循环判断types中的所有类型，只要那些实现了IEditor接口的类型
                //获取IEditor接口的Type
                Type typeIEditor = typeof(IEditor);

                for (int i = 0; i < types.Length; i++)
                {
                    //验证当前的类型即实现了IEditor接口并且该类型还可以被实例化
                    if (typeIEditor.IsAssignableFrom(types[i]) && !types[i].IsAbstract)
                    {
                        //那么接下来就需要创建该类型的对象，在接口的开发文档中注明，需要开发
                        //插件的人员编写一个实现了IEditor接口的类，并且该类必须有一个无参数的构造函数。
                        IEditor editor = (IEditor)Activator.CreateInstance(types[i]);
                        //editor.Name;
                        //向菜单栏中动态添加一个菜单项
                        ToolStripItem toolItem = tsmiFormat.DropDownItems.Add(editor.Name);

                        //为刚刚增加的菜单项注册一个单击事件
                        toolItem.Click += new EventHandler(toolItem_Click);

                    }
                }

            }

        }

        void toolItem_Click(object sender, EventArgs e)
        {
            //在这里就要运行该插件了。
            MessageBox.Show("Run............");
        }
    }
}
