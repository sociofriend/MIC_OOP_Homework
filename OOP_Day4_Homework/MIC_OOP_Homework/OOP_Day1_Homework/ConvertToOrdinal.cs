using System;
namespace SixTasksLilitAvdalyan20230510001
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

        public void CardinalToOrdinal(int number)
        {

            if (number == 11)
            {
                Console.WriteLine("11th");
            }

            else if (number == 12)
            {
                Console.WriteLine("12th");
            }

            else if (number == 13)
            {
                Console.WriteLine("13th");
            }
            /*
             * write exceptions for ex.113th also.
             * 
             */
            else
            {
                string num = number.ToString();
                char lastNum = num[num.Length - 1];

                if (lastNum.Equals('1'))
                {
                    Console.WriteLine(num + "st");
                }

                else if (lastNum.Equals('2'))
                {
                    Console.WriteLine(num + "nd");
                }

                else if (lastNum.Equals('3'))
                {
                    Console.WriteLine(num + "rd");
                }

                else 
                {
                    Console.WriteLine(num + "th");
                }
            }
                
        }

    }
}

