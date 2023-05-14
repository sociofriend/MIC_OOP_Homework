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
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write(cellValue);
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write(cellValue);
        }
    }


    /// <summary>
    /// Prints the board with 10x10 size, given figure on given coordinates i,j.
    /// </summary>
    /// <param name="figure"></param>
    /// <param name="coordinates"></param>
    public static void BoardPrinterWithFigure(string figure, int[,] coordinates)
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

    /// <summary>
    /// Prints the board with 10x10 size with given figure on given coordinates i,j 
    /// and legal steps of the figure from the given coordinates.
    /// </summary>
    /// <param name="figure"></param>
    /// <param name="coordinates"></param>
    public static void BoardPrinterWithLegalSteps(string figure, int[,] coordinates)
    {
        //will be added if option for fistruibutions by figures
        //bishop
        int figureCoordinatesSum = 0;
        int figureCoordinatesDiff = 0;
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                if (coordinates[i, j] == 1)
                {
                    figureCoordinatesSum = i + j;
                    figureCoordinatesDiff = i - j;
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
                    BackgroundSetter((figure + " "), i, j);

                else if ((coordinates[i, j] != 1) && (i + j == figureCoordinatesSum))
                    BackgroundSetter("**", i, j);

                else if ((coordinates[i, j] != 1) && (i - j == figureCoordinatesDiff))
                    BackgroundSetter("**", i, j);
                else
                    BackgroundSetter("  ", i, j);
            }

            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(i + 1);
        }
        Console.WriteLine("  A B C D E F G H  ");
    }
}

