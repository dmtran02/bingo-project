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
     * Class that helps track and notify user of BINGO by using a 2D array of integers
     * with supporting methods to ensure each possible way of BINGO is tracked.
     */

    class InternalCardRep2DArray
    {
        public const int BINGOSIZE = 5;
        public static int[,] bingoBoard = new int[5, 5] {
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0 },
            { 0, 0, 1, 0, 0 },
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0 } };
        public static int count = 0;
        public static int bingoCount = 0;

        /*
         * Uses checkRows, checkColumns, CheckLToRDiagonal and CheckRToLDiagonal
         * to check for any possible BINGO.
         * 
         * Tracks user's gameplay by recording every valid marking of '1' onto a 
         * 2D array of integers.
         * 
         *  -Returns the result of integer value '0 or 1' depending if
         *   a BINGO was present and detected by the supporting methods
         *   that handle this situation.
         */

        public static int isWinner(int row, int col)
        {
            int result = 0;
            RecordCalledNumber(row, col);
            count++;
            if (checkRows())
            {
                result = 1;
            }
            else if (checkColumns())
            {
                result = 1;
            }
            else if (CheckLToRDiagonal())
            {
                result = 1;
            }
            else if (CheckRToLDiagonal())
            {
                result = 1;
            }
            
            //Console.WriteLine("Bingo Board 2D Entry: " + bingoBoard[row, col]);
            //Console.WriteLine("Count: " + count);
            //Console.WriteLine("Result = " + result);
            //result = checkColumns();

            return result;
        }

        /*
         * Records the button clicked in a 2D array to keep track of possible BINGO
         * 
         *  -If number called is clicked, the button corresponding to the number is
         *   tracked and marked as '1' in the Integer 2D array.
         *  -Other indices are left as '0' if not tracked.
         *  -Also prints out the array into the console for the developer's use 
         *   of tracking the buttons clicked in the game.
         */

        public static void RecordCalledNumber(int row, int col)
        {
            bingoBoard[row, col] = 1;
            int j = 0;
            //Console.Write(j);
            for(int i = 0; i < bingoBoard.Length; i++)
            {
                Console.Write(bingoBoard[j, i]);
                //Console.Write(i);
                

                if(i == 4)
                {
                    i = -1;
                    j = j+1;
                    Console.WriteLine("\n");
                }
                if(j == 5)
                {
                    break;
                }
                
            }
        }

        /*
         * Checks rows (0-4) for BINGO
         *  -If row 0 does not contain BINGO, loop moves on to row 2 and so on.
         *  -If no BINGO is present, the method returns false.
         *  -Otherwise, the method will return true for BINGO is present.
         */

        public static Boolean checkRows()
        {
            int count = 0;
            bool result = false;
            int i = 0;
            for(int j = 0; j <= 5; j++)
            {
                //Console.WriteLine("Row: " + i + ", Col: " + j);
                if(bingoBoard[i, j] == 1)
                {
                    count++;
                    if(count == 5)
                    {
                        result = true;
                        break;
                    }
                }
                if(j == 4)
                {
                    j = -1;
                    i++;
                    if(i == 5)
                    {
                        break;
                    }
                    count = 0;
                }
            }
            return result;
        }

        /*
         * Checks columns (0-4) for BINGO
         *  -If column 0 does not contain BINGO, loop moves on to column 1 and so on.
         *  -If no BINGO is present, the method returns false.
         *  -Otherwise, the method will return true for BINGO is present.
         */

        public static Boolean checkColumns()
        {
            int count = 0;
            bool result = false;
            int j = 0;
            for (int i = 0; i <= 5; i++)
            {
                //Console.WriteLine("Row: " + i + ", Col: " + j);
                if (bingoBoard[i, j] == 1)
                {
                    count++;
                    if (count == 5)
                    {
                        result = true;
                        break;
                    }
                }
                if (i == 4)
                {
                    i = -1;
                    j++;
                    if (j == 5)
                    {
                        break;
                    }
                    count = 0;
                }
            }
            return result;
        }

        /*
         * Checks top left to bottom right diagonally for BINGO
         *  -If no BINGO is present, the method will return false.
         *  -Otherwise, the method will return true for BINGO is present.
         */

        public static Boolean CheckLToRDiagonal()
        {
            int count = 0;
            bool result = false;
            int i = 0;
            int j = 0;
            while (true)
            {
                //Console.WriteLine("Row: " + i + ", Col: " + j);
                if (bingoBoard[i, j] == 1)
                {
                    count++;
                    if (count == 5)
                    {
                        result = true;
                        break;
                    }
                    i++;
                    j++;
                }
                else
                {
                    i++;
                    j++;
                }
                if(i == 5)
                {
                    break;
                }
            }

            return result;
        }
        
        /*
         * Checks from top right to bottom left diagonally for BINGO
         *  -If no BINGO is present, the method returns false.
         *  -Otherwise, the method will return true for BINGO is present.
         */

        public static Boolean CheckRToLDiagonal()
        {
            int count = 0;
            bool result = false;
            int i = 0;
            int j = 4;
            while (true)
            {
                //Console.WriteLine("Row: " + i + ", Col: " + j);
                if (bingoBoard[i, j] == 1)
                {
                    count++;
                    if(count == 5)
                    {
                        result = true;
                        break;
                    }
                    i++;
                    j--;
                }
                else
                {
                    i++;
                    j--;
                }
                if (i == 5)
                {
                    break;
                }
            }
            return result;
        }
    }
}
