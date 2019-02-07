using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Duc Tran
 * Professor Frank Friedman
 * CIS 3309 - Final Submission Bingo Project
 * Last Updated: 2/06/2019
 */

namespace Bingo.Class
{

    /*
     * Code given by the professor to ensure tracking of which numbers were used 
     * in the creation of the cards for the board and playing the game.
     */

    /*
     * Uses an integer array of size '76' for the sample space of possible integers and methods
     * to set a number as used, check if the number is used and reset the array back to its default
     * values for gameplay.
     */

    public class SelectedNumbersListType
    {
        int[] usedNumList = new int[76];

        /*
         * Sets the RNG number as used in the array to ensure
         * there are no duplicates in the creation of the cards.
         */

        public void setUsedNumber(int rn)
        {
            usedNumList[rn] = rn;
        }

        /*
         * Tracks if the RNG number is used to eliminate the possibility of
         * duplicates in the creation of cards.
         *  -Returns true if RNG number is used.
         *  -Returns false if RNG number is not used.
         */

        public Boolean isNumberUsed(int rn)
        {
            //Console.WriteLine("Number used: " + rn);
            if (usedNumList[rn] == rn)
            {
                return true;
            }
            return false;
        }

        /*
         * Resets the array of integers of size '76' to default and newly-made array
         * by setting the element of each index to '0'.
         */

        public void reset()
        {
            for(int i = 0; i < usedNumList.Length; i++)
            {
                usedNumList[i] = 0;
            }
        }
    }
}
