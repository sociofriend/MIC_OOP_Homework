using System;
namespace OOP_Day1_Homework
{
	public class Exersize3x1_1
	{
       public int Formula(int x)
        {
            if (x == 1)
                return x;

            else
            {
                x = 3*x + 1;
                Console.WriteLine(x);

                if (x != 1)
                    Secuence(x);
                else
                    Formula(x);
            }
            return 00;

        }


       public int Secuence(int n)
        {
            if (n % 2 != 0)
            {
                n /= 2;
                Formula(n);
            }


            else
                Formula(n);
            return 00;
        }


    }
}

