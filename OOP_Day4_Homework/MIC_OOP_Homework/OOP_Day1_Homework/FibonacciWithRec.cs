using System;
namespace SixTasksLilitAvdalyan20230510001
{
	public class FibonacciWithRec
	{
        #region Method 1, without 
        //List<int> fibSec = new List<int>() {0,1};

        //public int FibNumber(int n)
        //{
        //	for (int i=2; i<n; i++)
        //	{
        //		fibSec.Add(fibSec[i - 2] + fibSec[i - 1]);
        //	}

        //	return fibSec[n - 1];

        //}
        #endregion


        #region Method 2, with recursion, return the n-th number
        //public int FibNumber(int n)
        //{
        //    if (n <= 1)
        //        return n;

        //    else
        //    {       
        //        return FibNumber(n - 2) + FibNumber(n - 1);
        //    }
        //}
        #endregion

        
        #region Method 3, with recursion, print the secuence for  0 to n-th number of the secuences

        public void FibNumber()
        {
            Console.Write("Please enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            Fibonacci(0, 1, 1, number);
        }

        public void Fibonacci(int a, int b, int counter, int number)
        {
            Console.Write(a + " ");
            if (counter < number)
                Fibonacci(b, a + b, counter + 1, number);
        }
        #endregion

    }
}

