using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160903_002_19
{
    public class ItcastClass
    {
        public int Count 
        {
            get 
            {
                return _name.Length;
            }
        }

        private string[] _name = { "苏坤", "蒋坤", "杨中科", "马伦", "赵剑宇"};

        public string this[int index]   //建立的一个索引器
        {
            get 
            {
                if (index < 0 || index >= _name.Length)
                {
                    throw new ArgumentException();
                }
                return _name[index];
            }
            set 
            {
                _name[index] = value; 
            }
        }

        public string this[string username]   //建立的一个索引器
        {
            get
            {
                return "";
            }
            set
            {
                
            }
        }

        //public string Item
        //{
        //    get;
        //    set;
        //}


    }
}
