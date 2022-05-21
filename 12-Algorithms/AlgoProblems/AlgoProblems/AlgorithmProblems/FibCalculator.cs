using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoProblems
{
    class FibCalculator
    {
        // Find fib number using recursive method
        public static int FindFibRecurs(int num)
        {
            if (num == 0 | num == 1)
                return num;
            else
                return (FindFibRecurs(num - 1) + FindFibRecurs(num - 2));
        }

        // Find fib using a simple loop
        public static int FindFibLoop(int num)
        {
            int currNum = 1, prevNum = 1, fib = 0;
            if (num <= 1)
                return num;
            else
            {
                // First two cases have already been handled
                for(int i = 2; i < num; i++)
                {
                    fib = prevNum + currNum;
                    prevNum = currNum;
                    currNum = fib;
                }
                return fib;
            }
        }
    }

    class FibCalculatorTest
    {
        public static void Test()
        {
            Console.WriteLine(FibCalculator.FindFibRecurs(7));
            Console.WriteLine(FibCalculator.FindFibLoop(7));
        }
    }

}
