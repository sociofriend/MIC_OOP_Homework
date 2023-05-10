using System;
namespace SixTasksLilitAvdalyan20230510001
{
	public class TimeTable1
    {

        public void GetUserInput()
        {
            Console.WriteLine("Please input a number in 0 to 255 range: ");
            string input = Console.ReadLine();
            CheckInput(input);
        }

        public void CheckInput(string input)
        {
            if(byte.TryParse(input, out byte number))
            {
                Console.WriteLine("TimeTable:");
                PrintTimeTable(number);
            }

            else
            {
                GetUserInput();
            }
        }

        public void PrintTimeTable(byte x)
        {
            Console.WriteLine(x + " * " + "12 = " + 12 * x);
        }
    }



}

