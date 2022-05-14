using System;
using System.Collections.Generic;
using System.Linq;
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
 * List is a datastructure that represents a list of objects
 * each of the objects can be accessed by an index,
 * It can also be dynamically increased or decreased.
 */
        public static void TestLists()
        {
            List<String> clothes = new List<String>();

            //Adding item to list can be done with Add
            clothes.Add("Shirts");
            clothes.Add("Chinos");
            clothes.Add("Bermudas");
            clothes.Add("Vests");
            clothes.Add("Caps");
            clothes.Add("Bermudas");

            //Individual item can be accessed with an index
            Console.WriteLine(clothes[0]);

            //for removing an object, remove method can be used.
            clothes.Remove("Shirts");
            Console.WriteLine(clothes[0]);

            // Lists allow for inserting at any specified index
            clothes.Insert(1,"Socks");

            // Total number of items in a list can be seen using count property
            Console.WriteLine(clothes.Count);

            // IndexOf method can be used to get the index of an item
            Console.WriteLine(clothes.IndexOf("Vests"));

            // If duplicates exist, the last index of an item can be found using lastindexof method
            Console.WriteLine(clothes.LastIndexOf("Bermudas"));

            // contains method can be used to see if an item exists in a list
            Console.WriteLine(clothes.Contains("Socks"));

            // sort and reverse can be used to sort lists
            clothes.Sort();
            clothes.Reverse();


            // List can be converted to array
            string[] clothingItems = clothes.ToArray();

            // Clear method is used to clear up all list
            clothes.Clear();

        }

/*
 * C# Strings are arrays of characters.
 * C# Strings are immutable (they cannot be altered). Any change to a C# string leads to creating a copy of string.
 * Individual characters in a C# string cannot be changed like str[0] = "i" is not possible.
*/
        public static void TestStrings()
        {
            string strMessage = "Hello World!";
            Console.WriteLine(strMessage);

            // String in C# is an array of characters
            for (int i = 0; i < strMessage.Length; i++)
            {
                Console.Write(strMessage[i]);
            }
            Console.WriteLine();

            // Individual characters cannot be changed in a C# string
            // strMessage[1] = 'X' is not a valid statement

            //Changing a string will create a new string
            strMessage = "This string has a number: 424";

            string numberSubStr = strMessage.Substring(strMessage.IndexOf(':') + 2);
            int.TryParse(numberSubStr, out var a);
            Console.WriteLine(a);


            // ReadOnlySpan class can be used as strings which do not create copies
            ReadOnlySpan<char> msgSpan = strMessage;
            ReadOnlySpan<char> numberSpan = msgSpan.Slice(msgSpan.IndexOf(":") + 2);
            int.TryParse(numberSpan, out var b);
            Console.WriteLine(b);


            // Creating two different string variables with the same content
            // basically creates two variables that refer to the same string

            string testStrOne = "I am a string";
            string testStrTwo = "I am a string";

            // This will return true if the objects are the same
            Console.WriteLine(object.ReferenceEquals(testStrOne, testStrTwo));


            // When a lot of concatenation is expected, it is always a better practice to use StringBuilder
            var sb = new StringBuilder();
            foreach (int i in Enumerable.Range(1,10))
            {
                sb.Append(i.ToString());
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
