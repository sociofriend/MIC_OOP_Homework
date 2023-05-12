using System;

namespace ChessVersion3LibLilitAvdalyan20230511004;
public class ChessLib

{

    /// <summary>
    /// Sets background colorwith given coordinates i, j set in two-dimensional array
    /// </summary>
    /// <param name="cellValue"></param>
    /// <param name="i"></param>
    /// <param name="j"></param>
    public static void BackgroundSetter(string cellValue, int i, int j)
    {
        if ((i + j) % 2 == 0)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(cellValue);
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(cellValue);
        }
    }

    /// <summary>
    /// "BoardPrinter" method prints the board with 10x10 size.
    /// </summary>
    /// <param name="figure"></param>
    /// <param name="coordinates"></param>
    public static void BoardPrinter(string figure, int[,] coordinates)
        {
        Console.BackgroundColor = ConsoleColor.White;
        Console.WriteLine("  A B C D E F G H  ");
        for (int i = 0; i < 8; i++)
        {
            Console.Write(" " + (i + 1));
            for (int j = 0; j < 8; j++)
            {
                if (coordinates[i, j] == 0)
                    BackgroundSetter("  ", i, j);

                else
                    BackgroundSetter((figure + " "), i, j);
            }

            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(i + 1);
        }
        Console.WriteLine("  A B C D E F G H  ");
    }
    
}

