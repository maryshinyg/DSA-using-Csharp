using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA45.Leetcode.Search
{
    internal class FloorofNum
    {
        /*ceiling = greatest ele in array which is <= target;
         * if arr = [2, 4, 5, 10, 11], target = 4 => ceiling(arr, target) = 4;
         * if arr = [2, 4, 5, 10, 11], target = 9 => ceiling(arr, target) = 10;
         */

        public static int floorofNumber(int[] arr, int target)  //TC: O(logn)
        {
            if (target < arr[arr.Length - 1])
            {
                return -1;
            } //if target is less than the smallest ele in array then return -1 (as there is no floor of target in array

            int start = 0;
            int end = arr.Length - 1;

            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (target > arr[mid])
                {
                    start = mid + 1;
                }
                else if (target < arr[mid])
                {
                    end = mid - 1;
                }
                else
                {
                    return mid; //found ans
                }
            }
            return start;
        }
    }
}
