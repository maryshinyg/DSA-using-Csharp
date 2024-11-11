using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA45.Strings
{
    internal class PalindromeString
    {
        public static bool IsPalindrome(string S) //TC: O(N), SC : O(1)
        {
            int start = 0;
            int end = S.Length - 1;
            while (start < end)
            {
                if (char.ToLower(S[start]) != char.ToLower(S[end])) //(S[start] != S[end])
                {
                    return false;
                }
                start++;
                end--;
            }
            return true;
        }
    }
}
