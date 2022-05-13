using System;
using System.Collections.Generic;
using System.Text;
/*
 * Access complexity is O(1) - every member has an address
 * Search complexity is O(n) - searching requires traversing the entire list / array in worst case
 * Insert / Delete complexity is O(n) - because in worst case an element will need to be found and then the rest of array 
 *                                      elements will be moved
 *                                      
 * Drawback of array is that it occupies a continuous space in memory
*/
namespace DataStructures
{
    class ArrayList
    {
        public static void TestArrays()
        {
            Console.WriteLine("Linear Array");
            int[] linearArray = new int[10];
            //prints type of array
            Console.WriteLine(linearArray);
            //printing contents of array
            for (int i = 0; i < linearArray.Length; i++)
                Console.WriteLine(linearArray[i]);

            Console.WriteLine("-------------\n\n");

            Console.WriteLine("Two Dimensional Array");
            int[,] twoDimArray = new int[5,6];
            //prints type of array
            Console.WriteLine(twoDimArray);
            //printing contents of array
            for (int i = 0; i < twoDimArray.GetLength(0); i++)
                for(int j = 0; j < twoDimArray.GetLength(1); j++)
                Console.WriteLine(twoDimArray[i,j]);

            Console.WriteLine("-------------\n\n");

            //Jagged Arrays are arrays of arrays
            Console.WriteLine("Jagged Arrays");
            int[][] jaggedArray = new int[2][];
            jaggedArray[0] = new int[2] { 1, 2 };
            jaggedArray[1] = new int[3] { 0, 0, 0, };
            //prints type of array
            Console.WriteLine(jaggedArray);
            //printing contents of array
            for (int i = 0; i < jaggedArray.GetLength(0); i++)
                for (int j = 0; j < jaggedArray[i].GetLength(0); j++)
                    Console.WriteLine(jaggedArray[i][j]);
        }
/*
 * C# Strings are arrays of characters.
 * C# Strings are immutable (they cannot be altered). Any change to a C# string leads to creating a copy of string.
 * Individual characters in a C# string cannot be changed like str[0] = "i" is not possible.
*/
        public static void TestStrings()
        {

        }
    }
}
