using System;
namespace OOP_Day2_Homework
{
	public class CheckmateBoard2
	{
		public CheckmateBoard2()
		{
            PrintFirstLastRows();
            PrintRow();
            PrintFirstLastRows();
        }

       

        ConsoleColor lightSquareColor = ConsoleColor.White;
        ConsoleColor darkSquareColor = ConsoleColor.Black;



        public void PrintFirstLastRows()
		{
            Console.Write("  ");
            for (char letter = (char)97; letter <= 104; letter++ )
			{
				Console.Write(letter + " ");
			}
			Console.WriteLine();
		}

		public void PrintRow()
		{
           for(int i=1; i<=8; i++)
            {
                Console.Write(i);
                for (int j=i+1; j<=i+9; j++)
                {
                    if(j%2==0)
                    {
                        Console.BackgroundColor = darkSquareColor;
                        Console.Write("  ");
                    }
                    else
                    {
                        Console.BackgroundColor = lightSquareColor;
                        Console.Write("  ");
                    }
                }
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine(i);
            }
           
        }
    }
}

