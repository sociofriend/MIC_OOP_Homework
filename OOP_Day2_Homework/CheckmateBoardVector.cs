using System;
using System.Numerics;

namespace ChessVersion1LilitAvdalyan20230508002
{
    /// <summary>
    /// Produced by Open AI - ChatGPT
    /// </summary>

    public class CheckmateBoardVector
	{
		public CheckmateBoardVector()
		{
            PrintBoard();
        }

        private void PrintBoard()
        {
            int size = 8;
            Vector2 movement = new Vector2(1, 1);
            Vector2 start = new Vector2(1, 1);

            Console.Write("  ");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"{(char)(i + 97)} ");
            }
            Console.WriteLine();

            for (int i = 0; i < size; i++)
            {
                Console.Write($"{i + 1} ");
                for (int j = 0; j < size; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                    }
                    Console.Write("  ");
                }
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine($"{i + 1}");
            }

            Console.Write("  ");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"{(char)(i + 97)} ");
            }
            Console.WriteLine();
        }
    }
}
