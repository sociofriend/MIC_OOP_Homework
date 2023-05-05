using System;
namespace OOP_Day1_Homework
{
	public class FibonacciWithRec
	{
        //List<int> fibSec = new List<int>() {0,1};

        //public int FibNumber(int n)
        //{
        //	for (int i=2; i<n; i++)
        //	{
        //		fibSec.Add(fibSec[i - 2] + fibSec[i - 1]);
        //	}

        //	return fibSec[n - 1];

        //}

        public int FibNumber(int n)
        {
            if (n <= 1)
                return n;
           
            else
            {       
                return FibNumber(n - 2) + FibNumber(n - 1);
            }
        }

    }
}

