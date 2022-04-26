using System;
using System.Collections.Generic;
using System.Text;

namespace SearchingSorting
{
    public static class Sort
    {
        private static void swapValues(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static void printArray(int[] arr)
        {
            Console.WriteLine("\n**Start of Print Array Function**");
            foreach (int x in arr)
                Console.WriteLine(x);

            Console.WriteLine("**End of Print Array Function**\n\n");
        }

        // Complexity of Selection Sort is O(n^2) since there is a nested loop of size n (where n is the size of array)
        public static void SelectionSort(ref int[] unsortedArray)
        {
            int arraySize = unsortedArray.Length;

            for(int i = 0; i < arraySize; i++)
            {
                for(int j = 0; j < arraySize; j++)
                {
                    if (unsortedArray[i] < unsortedArray[j])
                        swapValues(ref unsortedArray[i], ref unsortedArray[j]);
                }
            }
        }

        // Complexity of Bubble Sort is O(n^2) since there is a nested loop of size n (where n is the size of array)
        public static void BubbleSort(ref int[] unsortedArray)
        {
            int arraySize = unsortedArray.Length;
            bool swapFlag = false;
            for (int i = 0; i < arraySize-1; i++)
            {
                swapFlag = false;
                for (int j = 0; j < arraySize-i-1; j++)
                {
                    if (unsortedArray[j] > unsortedArray[j + 1])
                    {
                        swapValues(ref unsortedArray[j], ref unsortedArray[j + 1]);
                        swapFlag = true;
                    }
                }

                if (i==0 && !swapFlag) //swapFlag is false which means that array is already sorted
                {
                    //Console.WriteLine("Array is already sorted");
                    break;
                }
                    
            }
        }

    }
}
