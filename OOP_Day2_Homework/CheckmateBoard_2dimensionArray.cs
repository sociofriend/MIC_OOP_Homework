using System;
using System.Linq;

namespace OOP_Day2_Homework
{
    public class CheckmateBoard_2dimensionArray
    {
        ConsoleColor lightCell = ConsoleColor.White;
        ConsoleColor darkCell = ConsoleColor.Black;

        void PrintFirstLastRow()
        {
            Console.Write("  ");
            for (char a = (char)97; a <= (char)104; a++)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();
        }
        void PrintBoardBody()
        {
            for (int i = 0; i < 8; i++)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write(i + 1);
                for (int j = 0; j < 8; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        PrintDark();
                    }
                    else
                    {
                        PrintLight();
                    }
                }
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine(i + 1);
            }
        }

        void PrintLight()
        {
            Console.BackgroundColor = lightCell;
            Console.Write("  ");
        }
        void PrintDark()
        {
            Console.BackgroundColor = darkCell;
            Console.Write("  ");
        }

        public void PrintCheckmatBoard2d()
        {
            PrintFirstLastRow();
            PrintBoardBody();
            PrintFirstLastRow();
            Console.ReadKey();
        }

    }
}

