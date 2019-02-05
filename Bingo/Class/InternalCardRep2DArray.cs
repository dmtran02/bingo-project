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
        public bool[,] bingoBoard = { { false, false, false, false, false }, { false, false, false, false, false }, { false, false, false, false, false }, { false, false, false, false, false }, { false, false, false, false, false } };

        public static int isWinner(int row, int col)
        {
            int result = 0;

            return result;
        }

        public static void recordCalledNumber(int row, int col)
        {

        }
    }
}
