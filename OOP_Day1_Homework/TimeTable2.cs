using System;
namespace OOP_Day1_Homework
{
	public class TimeTable2
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
            for(int i=1; i<=12; i++)
            {
                Console.WriteLine($"{i} * {x} = {i * x}");
            }
        }
    }



}

