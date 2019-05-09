using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160904_002
{
    public class UserPlayer
    {
        //public UserPlayer(string fistName) 
        //{
        //    this.FistName = fistName;
        //} 

        //用来保存玩家的出拳结果
        public string FistName
        {
            get;
            set;
        }

        //玩家的出拳方法
        public int ShowFist(string fist)
        {
            #region  自写程序，程序不完美！
            //if (fistName == "剪刀") 
            //{
            //    return 1;
            //}
            //else if (fistName == "石头")
            //{
            //    return 2;
            //}
            //else 
            //{
            //    return 3;
            //}

            #endregion

            #region  视频中老师所讲代码
            this.FistName = fist;
            int result = -1;

            switch (fist)
            {
                case "石头": result = 1;
                    break;
                case "剪刀": result = 2;
                    break;
                case "布": result = 3;
                    break;
                default:
                    break;
            }

            return result;

            #endregion


        }  //ShowFist尾括号


    }
}
