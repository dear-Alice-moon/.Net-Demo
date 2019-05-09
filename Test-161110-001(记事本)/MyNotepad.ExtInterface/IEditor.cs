using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNotepad.ExtInterface
{
    public interface IEditor
    {
        /// <summary>
        /// 这个属性表示当前插件的名称。
        /// </summary>
        string Name
        {
            get;
            //set;
        }

        /// <summary>
        /// 运行给插件的功能。
        /// </summary>
        /// <param name="txtBox"></param>
        void Run(TextBox txtBox);



    }
}
