using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA45.Arrays
{
    internal class ReverseArray
    {
        public static int[] reverseArray(int[] arr) //TC: O(N), SC : O(N)
        {
            int[] op = new int[arr.Length];
            for(int i=0; i< arr.Length; i++)
            {
                op[i] = arr[arr.Length-i-1];
            }
            return op;
        }

        public static void reverseArrayInPlace(int[] arr) //TC: O(N), SC : O(1)
        {
            int start = 0;
            int end = arr.Length-1;
            int temp = 0;
            while (start < end) {
                temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }

            foreach (int i in arr)
            {
                Console.Write(i + ",");
            }
        }
    }
}
