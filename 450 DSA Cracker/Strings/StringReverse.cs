using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA45.Strings
{
    internal class StringReverse
    {
        public static void ReverseString(char[] s)  //TC: O(N), SC : O(1)
        {
            int start = 0;
            int end = s.Length - 1;
            char temp;
            while (start < end)
            {
                temp = s[start];
                s[start] = s[end];
                s[end] = temp;
                start++;
                end--;
            }
            Console.Write("[");
            for (int i=0; i<s.Length-1; i++)
            {
                Console.Write($"\"{(char)s[i]}\",");//(i + ",");
            }
            Console.Write($"\"{(char)s[s.Length-1]}\"");
            Console.Write("]");
        }
    }
}
