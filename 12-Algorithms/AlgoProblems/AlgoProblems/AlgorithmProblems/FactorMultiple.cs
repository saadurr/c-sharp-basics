using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoProblems
{
    class FactorMultiple
    {
        public static int CalculateGCF(int a, int b)
        {
            // a number that divides both a and b
            
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
            
        }

        public static int CalculateLCM(int a, int b)
        {
            return (a / CalculateGCF(a, b)) * b;
        }
    }

    class FactorMultipleTest
    {
        public static void Test()
        {
            Console.WriteLine($"GCF of 120 and 18 is: {FactorMultiple.CalculateGCF(120, 18)}");
            Console.WriteLine($"LCM of 120 and 18 is: {FactorMultiple.CalculateLCM(120, 18)}");
        }
    }

}
