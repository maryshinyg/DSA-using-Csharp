using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA45.SearchAlgo
{
    internal class OrderAgnosticBS
    {
        //to check if the array is ordered in desc or asc then apply search accordingly
        public static int orderAgnosticBS(int[] arr, int x) //TC: O(logn) SC: O(1)
        {
            int start = 0;
            int end = arr.Length - 1;
            bool isAsc = arr[start] < arr[end];
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (arr[mid] == x)
                {
                    return mid;
                }
                if (isAsc)
                {
                    if (x > arr[mid])
                    {
                        start = mid + 1;
                    }
                    else
                    {
                        end = mid - 1;
                    }
                }
                else
                {
                    if (x > arr[mid])
                    {
                        end = mid - 1;
                    }
                    else
                    {
                        start = mid + 1;
                    }
                }
            }
            return -1;
        }
    }
}
