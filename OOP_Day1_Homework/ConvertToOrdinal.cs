using System;
namespace OOP_Day1_Homework
{
	public class ConvertToOrdinal
	{
        public void GetUserInput()
        {
            Console.WriteLine("Please input a cardinal number: ");
            string input = Console.ReadLine();
            CheckInput(input);
        }

        public void CheckInput(string input)
        {
            if (int.TryParse(input, out int number))
            {
                CardinalToOrdinal(number);
            }

            else
            {
                GetUserInput();
            }

        }

        public string CardinalToOrdinal(int number)
        {


        }

    }
}

