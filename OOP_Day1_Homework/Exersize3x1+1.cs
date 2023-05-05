using System;
namespace OOP_Day1_Homework
{
    /// <summary>
    /// <Description.Two main methods: one for number odd/even checker, one for inFormula putter></Description>
    /// </summary>
    public class Exersize3x1_1
    {
        public int RunExersizeCheck(int number)
        {
            if (number % 2 == 0)
            {
                return RunExersizeCheck(number / 2);
            }
            else

                return Excersize(number);
        }


        public int Excersize(int n)
        {
   
            if (n==1)
            {
                Console.WriteLine(1);
                return 1;
            }
            else
            {
                n = 3 * n + 1;
                Console.WriteLine(n);

                return RunExersizeCheck(n);

            }
        }
    }
}



