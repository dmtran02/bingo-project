﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo.Class
{
    public class SelectedNumbersListType
    {
        Boolean[] usedNumList = new Boolean[75];

        public void setUsedNumber(int rn)
        {
            usedNumList[rn] = true;
        }

        public Boolean isNumberUsed(int rn)
        {
            if (usedNumList[rn] == true)
            {
                rn++;
                if(rn >= 76)
                {
                    isNumberUsed(rn);
                }
                usedNumList[rn] = true;
                return true;
            }
            return false;
        }
    }
}
