using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoProblems
{
    class AnagramChecker
    {
        public static bool IsAnagramWithDict(string s1, string s2)
        {
            if (s1.Length != s2.Length)
                return false;

            int len = s1.Length;

            Dictionary<char, int> map = new Dictionary<char, int>();

            // Loop over the first string
            for (int i = 0; i < len; i++)
            {
                // Check if key already exists
                if(map.ContainsKey(s1[i]))
                {
                    map[s1[i]] = map[s1[i]] + 1;
                }
                // Add key if doesnt exist
                else
                {
                    map.Add(s1[i], 1);
                }
            }

            // Loop over the second string
            for (int i = 0; i < len; i++)
            {
                // check if key exists
                if(map.ContainsKey(s2[i]))
                {
                    // decrement to mark checked
                    map[s2[i]] = map[s2[i]] - 1;
                }
            }

            var keys = map.Keys;

            foreach (char k in keys)
            {
                if(map[k]!=0)
                {
                    return false;
                }
            }

            return true;

        }

        public static bool IsAnagramWithArray(string s1, string s2)
        {
            // If not equal in length, they are not anagrams
            if (s1.Length != s2.Length) return false;

            char[] Arr1 = s1.ToCharArray();
            char[] Arr2 = s2.ToCharArray();

            Array.Sort(Arr1);
            Array.Sort(Arr2);

            for(int i = 0; i < Arr1.Length; i++)
            {
                if (Arr1[i] != Arr2[i])
                    return false;
            }
            

            return true;
        }

        public static bool IsAnagramWithCount(string s1, string s2)
        {
            // If not equal in length, they are not anagrams
            if (s1.Length != s2.Length) return false;

            int[] CountStr1 = new int[256];
            int[] CountStr2 = new int[256];

            for (int i = 0; i < s1.Length; i++)
            {
                for (int j = 0; j < s1.Length; j++)
                {
                    if (s1[i] == s1[j])
                        CountStr1[i]++;
                   
                    if (s1[i] == s2[j])
                        CountStr2[i]++;
                }

            }

            for (int i = 0; i < s1.Length; i++)
            {
                if (CountStr1[i] != CountStr2[i])
                    return false;
            }

            return true;
        }
    }

    class AnagramCheckerTest
    {
        public static void Test()
        {
            Console.WriteLine(AnagramChecker.IsAnagramWithDict("xsaxads","dassasxx"));
            Console.WriteLine(AnagramChecker.IsAnagramWithCount("saad", "daas"));
            Console.WriteLine(AnagramChecker.IsAnagramWithArray("saadx", "daaxs"));
        }
    }
}
