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
        public static int[,] bingoBoard = new int[5, 5] {
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0 },
            { 0, 0, 1, 0, 0 },
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0 } };
        public static int count = 0;
        public static int bingoCount = 0;

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
            
            Console.WriteLine("Bingo Board 2D Entry: " + bingoBoard[row, col]);
            //Console.WriteLine("Count: " + count);
            //Console.WriteLine("Result = " + result);
            //result = checkColumns();

            return result;
        }

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

        public static Boolean CheckLToRDiagonal()
        {
            int count = 0;
            bool result = false;
            int i = 0;
            int j = 0;
            while (true)
            {
                Console.WriteLine("Row: " + i + ", Col: " + j);
                if (bingoBoard[i, j] == 1)
                {
                    count++;
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

        public static Boolean CheckRToLDiagonal()
        {
            int count = 0;
            bool result = false;
            int i = 0;
            int j = 4;
            while (true)
            {
                Console.WriteLine("Row: " + i + ", Col: " + j);
                if (bingoBoard[i, j] == 1)
                {
                    count++;
                    i++;
                    j--;
                }
                else
                {
                    i++;
                    j--;
                }
                if (j == 0)
                {
                    break;
                }
            }
            return result;
        }
    }
}
