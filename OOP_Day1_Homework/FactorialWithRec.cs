using System;
namespace OOP_Day1_Homework
{
	public class FactorialWithRec
	{
        public uint GetUserInput() //rename RunCalcFactorial
        {
            do // the code block put into do while for gettin infinite cycle. we will not need to repeat the code from main.
            {
                Console.WriteLine("Please inptut an integer: ");
                if (UInt32.TryParse(Console.ReadLine(), out uint number))
                {
                    switch (number)
                    {
                        case 1:
                            return 1;
                        case 2:
                            return 2;
                        default:
                            return FactorialCalc(number);
                    }
                }
                else
                {
                    GetUserInput();
                    return 0;
                }
            } while (true);
        }
       

        public uint FactorialCalc(uint x) 
        {
            if (x == 1)
                return 1;
            else
                return x * FactorialCalc(x - 1);
        }
    }
}

