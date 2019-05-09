using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160904_002
{
    public class CaiPanYuan
    {
        public string IsUserWin(int user, int computer) 
        {
            if (user == computer)
            {
                return "平手";
            }
            else if ((user - computer == -1) || (user - computer == 2))
            {
                return "玩家赢(^__^)";
            }
            else
            {
                return "玩家输！";
            }
        }



    }
}
