using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoProblems
{
    class Palindrome
    {
        public static bool IsPalindromeWithLoop(string s)
        {
            StringBuilder invertedStr = new StringBuilder();

            for (int i = s.Length - 1; i >= 0; i--)
            {
                invertedStr.Append(s[i]);
            }

                if (s == invertedStr.ToString()) return true;

            return false;
        }

        public static bool IsPalindromeWithPtr(string s)
        {
            int ptr1 = 0;
            int ptr2 = s.Length - 1;

            while (ptr1 < ptr2)
            {
                if (s[ptr1] != s[ptr2])
                    return false;

                    ptr1++;
                    ptr2--;
            }

            return true;
        }

        public static int MinDeletionsToMakePalindrome(string s)
        {
            int LongestPalindromeSubstringLength = LongestPalindromeSubsequence(s, 0, s.Length - 1);

            return s.Length - LongestPalindromeSubstringLength;
        }

        private static int LongestPalindromeSubsequence(string s, int first, int last)
        {
            // The first index needs to be lesser than last index
            if (first > last)
                return 0;
            else if (first == last)
                return 1;

            // If chars on first and last index match, return 2 + further recursive result
            if (s[first] == s[last])
            {
                return (2 + LongestPalindromeSubsequence(s, first + 1, last - 1));
            }

            // Return maximum of all subsets
            return Math.Max(LongestPalindromeSubsequence(s, first + 1, last), LongestPalindromeSubsequence(s, first, last - 1));
        }

        public static int MinSwapsToMakePalindrome(string s)
        {
            char[] reversedStr = s.ToCharArray();
            Array.Reverse(reversedStr);
            // Return 0 if already palindrome
            if (IsPalindromeWithPtr(s)) return 0;

            // Return -1 if it cannot be made a palindrome
            if (!CanBeMadePalindromeWithSwap(s)) return -1;

            return Math.Min(MinSwapCalculator(s.ToCharArray()), MinSwapCalculator(reversedStr));
        }

        private static int MinSwapCalculator(char[] s)
        {
            int count = 0, firstSwapIndex = 0, lastSwapIndex = 0;

            for (int i = 0; i < s.Length / 2; i++)
            {
                firstSwapIndex = i;
                lastSwapIndex = s.Length - firstSwapIndex - 1;

                while(firstSwapIndex < lastSwapIndex)
                {
                    if (s[firstSwapIndex] == s[lastSwapIndex])
                        break;
                    else
                        lastSwapIndex--;
                }

                if (firstSwapIndex == lastSwapIndex)
                {
                    SwapValuesAtIndex(ref s, firstSwapIndex, firstSwapIndex + 1);
                    count++;
                }
                else
                {
                    for (int j = lastSwapIndex; j < s.Length - firstSwapIndex - 1; j++)
                    {
                        SwapValuesAtIndex(ref s, j, j + 1);
                        count++;
                    }
                }
            }

            return count;
        }

        private static void SwapValuesAtIndex(ref char[] cArr, int ind1, int ind2)
        {
            char temp = ' ';

            temp = cArr[ind1];
            cArr[ind1] = cArr[ind2];
            cArr[ind2] = temp;
        }

        public static bool CanBeMadePalindromeWithSwap(string s)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            bool keyOneAllowed = true;

            for (int i = 0; i < s.Length; i++)
            {
                if (map.ContainsKey(s[i]))
                    map[s[i]] = map[s[i]] + 1;
                else
                    map[s[i]] = 1;
            }

            foreach (char k in map.Keys)
            {
                // Check if there is a count of one for one key only
                if (map[k] == 1 && keyOneAllowed)
                    keyOneAllowed = false;
                // Check if count of each key is even
                else if (map[k] % 2 == 0)
                    continue;
                else
                    return false;
            }
            
            return true;
        }
    }

    class PalindromeTest
    {
        public static void Test()
        {
            string s1 = "saadaas";
            string s2 = "adaa";
            //string s3 = "mamad";
            //string s3 = "asflkj";
            //string s3 = "aabb";
            string s3 = "ntiin";

            Console.WriteLine(Palindrome.IsPalindromeWithLoop(s1));
            Console.WriteLine(Palindrome.IsPalindromeWithPtr(s1));

            Console.WriteLine(Palindrome.MinDeletionsToMakePalindrome(s2));

            Console.WriteLine(Palindrome.CanBeMadePalindromeWithSwap(s3));

            Console.WriteLine(Palindrome.MinSwapsToMakePalindrome(s3));
        }

    }
}
