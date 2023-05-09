using System;
namespace OOP_Day3_Homework
{
	public class FigurePreview
	{		

        void PrintFirstLastRow()
        {
            Console.Write("  ");
            for (char a = (char)97; a <= (char)104; a++)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();
        }

        void PrintLight()
        {
            ConsoleColor lightCell = ConsoleColor.White;
            Console.BackgroundColor = lightCell;
            Console.Write("  ");
        }
        void PrintDark()
        {
            ConsoleColor darkCell = ConsoleColor.Black;
            Console.BackgroundColor = darkCell;
            Console.Write("  ");
        }

        void PrintBoardBody(string figure, int columnCommand, int rowCommand)
        {
            int countRow = 1;
            

            for (int i = 0; i < 8; i++)
            {
                int countColumn = 1;
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write(i + 1);

                if (countColumn == columnCommand && countRow == rowCommand)
                    Console.Write(figure);
                
                for (int j = 0; j < 8; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        if (countColumn == columnCommand && countRow == rowCommand)
                            Console.Write(figure+" ");
                        else
                        {
                            PrintDark();
                            countColumn++;
                        }
                            
                    }
                    else
                    {
                        if (countColumn == columnCommand && countRow == rowCommand)
                            Console.Write(figure + " ");
                        else
                        {
                            PrintLight();
                            countColumn++;
                        }
                    }           
                }
                    countRow++;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.WriteLine(i + 1);
                    countColumn++;
                }
            }
        


        public void PrintCheckmatBoard2d(string figure, int columnCommand, int rowCommand)
        {
            PrintFirstLastRow();
            PrintBoardBody(figure, columnCommand, rowCommand);
            PrintFirstLastRow();
            Console.ReadKey();
        }

        public void GetFigure()
        {
            Console.WriteLine("Choose a figure: press R for rook, N " +
                "for knight, B for bishop, K for king and Q for queen.");

            string letters = "RNBKQ";
            string figure = Console.ReadLine().ToUpper();

            if (letters.Contains(figure))
            {
                GetCoordinates(figure);
            }
            else
                GetFigure();
        }

        void GetCoordinates(string letter)
        {
            string figure = letter;

            Console.WriteLine("Input command, where first symbol is a letter " +
                "from a to h and second command is a number from 1 to 8 (ex.a8)");
            string coordinates = Console.ReadLine();
            string letters = "abcdefgh";
            string numbers = "12345678";

            if (letters.Contains(coordinates[0]) && numbers.Contains(coordinates[1]))
            {
                PrintFigureOnBoard(figure, coordinates);
            }
            else
            {
                GetCoordinates(letter);
            }
        }

        void PrintFigureOnBoard(string fig, string cord)
        {
            string figure = fig;
            string commands = "abcdefgh";
            int columnCommand=0;
            int count = 0;
            foreach (char letter in commands)
            {
                count++;
                if (cord[0].Equals(letter))
                {
                    columnCommand = count;
                    break;
                }
                else
                {
                    GetCoordinates(fig);
                }
            }

            int rowCommand = (int)cord[1] - 48;
            PrintCheckmatBoard2d(fig, columnCommand, rowCommand);
        }
    }
}

