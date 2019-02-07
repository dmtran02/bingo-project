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
     * Aids in the conversion of characters to integers by taking a character
     * 
     *  -Specifically the button rowID and colID for 
     *   the creation of each button's name
     */

    class InternalBoard
    {
        public static int convertCharToInt(char character)
        {
            int result = 0;
            string holder = character.ToString();
            result = int.Parse(holder);
            //Console.WriteLine("InternalBoard: " + result);

            return result;
        }
    }
}
