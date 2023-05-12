using System;
namespace ChessVersion2LilitAvdalyan20230510003
{
    // use indexOf
    public class FigurePreview
	{		
        // add all descriptions for methods
        /// <summary>
        /// Prints first and last rows of the board( A B C D .. H)
        /// </summary>
        void PrintFirstLastRow()
        {
            Console.Write("  ");
            for (char a = (char)97; a <= (char)104; a++)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();
        }

        void PrintBackground(string cellValue, int i, int j)
        {
            if ((i + j) % 2 == 0)
            {
                ConsoleColor darkCell = ConsoleColor.Black;
                Console.BackgroundColor = darkCell;
                Console.Write(cellValue);
            }
            else
            {
                ConsoleColor lightCell = ConsoleColor.White;
                Console.BackgroundColor = lightCell;
                Console.Write(cellValue);
            }
        }

        void PrintBoardBody(string figure, int columnCommand, int rowCommand)
        {
            int countRow = 1;
            

            for (int i = 0; i < 8; i++)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write(i + 1);
                int countColumn = 1;

                
                for (int j = 0; j < 8; j++)
                {
                    if (countColumn == columnCommand && countRow == rowCommand)
                    {
                        PrintBackground(figure + " ", i, j);
                        j++;
                    }

                    PrintBackground("  ", i, j);
                    countColumn++;
       
                }
                    countRow++;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.WriteLine(i + 1);
                    countColumn++;
                }
            }

        void PrintCheckmatBoard2d(string figure, int columnCommand, int rowCommand)
        {
            PrintFirstLastRow();
            PrintBoardBody(figure, columnCommand, rowCommand);
            PrintFirstLastRow();
            Console.WriteLine();
            GetFigure();
        }

        // wrong input -> new message
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

        // F5 upper F does not work. add "wrong command" new message . add {||) in if body
        void GetCoordinates(string figure)
        {
            Console.WriteLine("Input command, where first symbol is a letter " +
                "from ՛a՛ to ՛h՛ and second command is a number from ՛1՛ to ՛8՛ (ex.a8 or H1)");
            string coordinates = Console.ReadLine().ToLower();

            if ((coordinates[0] >= 97 && coordinates[0] <= 104) && 
                (coordinates[1] >= 49 && coordinates[1] <= 56))
            {
                PrintFigureOnBoard(figure, coordinates[0], coordinates[1]);
            }
            else
            {
                GetCoordinates(figure);
            }
        }

        // փոխել i, j-ով, երկու փոփոխական պետք չի. անունները վերանայել, ijն է դուրս բերում, երկչափ զանգված
        void PrintFigureOnBoard(string fig, char letter, char number)
        {
            int columnCommand=0;
            int count = 0;
            for (char i = (char)97; i<= (char)104; i++ )
            {
                count++;
                if (i.Equals(letter))
                {
                    columnCommand = count;
                    break;
                }
            }

            int rowCommand = (int)number - 48;
            PrintCheckmatBoard2d(fig, columnCommand, rowCommand);
        }
    }
}

