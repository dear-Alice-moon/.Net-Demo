using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160904_002
{
    public class ComputerPlayer
    {
        //public ComputerPlayer(string fistName) 
        //{
        //    this.FistName = fistName;
        //}

        //用来保存计算机出拳结果的属性
        public string FistName
        {
            get;
            set;
        }

        //计算机的出拳方法
        public int ShowFist() 
        {
            Random random = new Random();
            int r = random.Next(1, 4);

            #region  自写程序，程序不完美。
            //if (r == 1)
            //{
            //    //fistName = "剪刀";
            //    return r;
            //}
            //else if (r == 2) 
            //{
            //    //fistName = "石头";
            //    return 2;
            //}
            //else
            //{
            //    //fistName = "布";
            //    return 3;
            //}

            #endregion


            //1 石头
            //2 剪刀
            //3 布
            #region  视频中老师所讲代码
            switch (r) 
            {
                case 1: this.FistName = "石头";
                    break;
                case 2: this.FistName = "剪刀";
                    break;
                case 3: this.FistName = "布";
                    break;
                default: break;
            }

            return r;

            #endregion


        }  //ShowFist尾括号


    }
}
