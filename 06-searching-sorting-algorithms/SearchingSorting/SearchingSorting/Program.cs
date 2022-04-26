using System;

namespace SearchingSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test Linear Search
            int[] numList = {11, 2, 3, 4, 56, 7, 8, 9, 0, 6, 99 };
            int findTerm = 0;
            Console.WriteLine("Using Linear Search, the term {0} has been found at {1}", findTerm, Search.LinearSearch(numList, findTerm));

            //Test Binary Search
            int[] numList2 = { 4, 7, 10, 23, 29, 31, 48, 41, 53, 61, 75, 90, 111, 130, 159, 178, 189, 191, 192, 199, 201, 209 };
            findTerm = 201;
            Console.WriteLine("Using Binary Search, the term {0} has been found at {1}", findTerm, Search.BinarySearch(numList2, findTerm));

            //Test Selection Sort
            Sort.printArray(numList);
            Sort.SelectionSort(ref numList);
            Console.WriteLine("Sorted Array (SelectionSort):");
            Sort.printArray(numList);

            //Test Bubble Sort
            Sort.printArray(numList);
            Sort.BubbleSort(ref numList);
            Console.WriteLine("Sorted Array (BubbleSort):");
            Sort.printArray(numList);




        }
    }
}
