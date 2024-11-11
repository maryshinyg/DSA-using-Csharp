using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA45.SearchAlgo
{
    internal class LinearSearch
    {
        public static void LSearch(int[] arr, int x) //TC: O(N) SC: O(1)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    Console.WriteLine($"Found elemnt at {i}");
                }
            }

        }
    }
}
