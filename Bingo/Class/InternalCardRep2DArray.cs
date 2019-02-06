using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo.Class
{
    class InternalCardRep2DArray
    {
        public const int BINGOSIZE = 5;
        public static int[,] bingoBoard = { };
        public static int count = 0;

        public static int isWinner(int row, int col)
        {
            int result = 0;
            bingoBoard[row, col] = 1;
            count++;

            return result;
        }

        public static void recordCalledNumber(int row, int col)
        {

        }

        public static void checkRows()
        {

        }
    }
}
