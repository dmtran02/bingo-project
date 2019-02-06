using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo.Class
{
    public class SelectedNumbersListType
    {
        int[] usedNumList = new int[76];

        public void setUsedNumber(int rn)
        {
            usedNumList[rn] = rn;
        }

        public Boolean isNumberUsed(int rn)
        {
            Console.WriteLine("Number used: " + rn);
            if (usedNumList[rn] == rn)
            {
                return true;
            }
            return false;
        }

        public void reset()
        {
            for(int i = 0; i < usedNumList.Length; i++)
            {
                usedNumList[i] = 0;
            }
        }
    }
}
