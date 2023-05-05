using System;
namespace OOP_Day1_Homework
{
	public class FactorialWithRec
	{
        public uint GetUserInput()
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

