using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA45.SearchAlgo
{
    internal class BinarySearch
    {
        public static int binarySearchAsc(int[] arr, int x) //TC: O(logn) SC: O(1)
        {
            int start = 0;
            int end = arr.Length - 1;

            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (x > arr[mid])
                {
                    start = mid + 1;
                }
                else if(x < arr[mid])
                {
                    end = mid - 1;
                }
                else
                {
                    return mid; //founf ans
                }
            }
            return -1;
        }
        public static int binarySearchDesc(int[] arr, int x) //TC: O(logn) SC: O(1)
        {
            int start = 0;
            int end = arr.Length - 1;

            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (x > arr[mid])
                {
                    end = mid - 1; ;
                }
                else if (x < arr[mid])
                {
                    start = mid + 1;
                }
                else
                {
                    return mid; //founf ans
                }
            }
            return -1;
        }
    }
}
