using System;
using System.Collections.Generic;
using System.Text;

namespace SearchingSorting
{
    public static class Search
    {
        // Linear Search iterates through each item of an array and therefore its complexity is O(n)
        public static int LinearSearch(int[] searchList, int searchItem)
        {
            int listLength = searchList.Length;

            for (int i = 0; i < listLength; i++)
            {
                if (searchList[i] == searchItem) return i;
            }

            return -1;
        }

        // Complexity of Binary search is O(log(n)) but it needs a sorted array
        public static int BinarySearch(int[] searchList, int searchItem)
        {
            Sort.BubbleSort(ref searchList);

            int listLength = searchList.Length;

            int mid = 0, leftEnd = 0, rightEnd = listLength;


            while (leftEnd <= rightEnd)
            {
                mid = leftEnd + (rightEnd - leftEnd) / 2;

                //found and return index
                if (searchList[mid] == searchItem)
                {
                    return mid;
                }

                //Look above - search value is higher than current
                else if (searchList[mid] < searchItem)
                {
                    leftEnd = mid + 1;
                }

                //Look below - search value is lower than current
                else
                {
                    rightEnd = mid - 1;
                }
            }
            return -1;
        }

    }
}
