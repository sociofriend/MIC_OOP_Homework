using System;
namespace ChessVersion3LibLilitAvdalyan20230511004
{
    public class Rook
    {
        public static void BoardPrinterWithLegalSteps(string figure, int[,] coordinates)
        {
            //variables

            int row = 0;
            int coloumn = 0;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (coordinates[i, j] == 1)
                    {
                        row = i;
                        coloumn = j;
                    }
                }
            }

            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("  A B C D E F G H  ");
            for (int i = 0; i < 8; i++)
            {
                Console.Write(" " + (i + 1));
                for (int j = 0; j < 8; j++)
                {
                    if (coordinates[i, j] == 1)
                        ChessLib.BackgroundSetter((figure + " "), i, j);
                    else if ((coordinates[i, j] != 1) && ((i == row) || (j == coloumn)))
                        ChessLib.BackgroundSetter("**", i, j);
                    else
                        ChessLib.BackgroundSetter("  ", i, j);
                }

                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine(i + 1);
            }
            Console.WriteLine("  A B C D E F G H  ");
        }
    }
}

