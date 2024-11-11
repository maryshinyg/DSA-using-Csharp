using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA45.Leetcode.Search
{
    //https://leetcode.com/problems/search-in-rotated-sorted-array/description/
    internal class SearchInRotatatedArr
    {
        public static int Search(int[] nums, int target)
        {
            int start = 0;
            int end = nums.Length - 1;

            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (nums[mid + 1] < nums[mid] && target < nums[mid])
                {
                    start = mid + 1;
                }
                else if (target < nums[mid])
                {
                    end = mid - 1;
                }
                else if (target > nums[mid])
                {
                    start = mid + 1;
                }
                else
                {
                    return mid;
                }
            }
            return -1;

        }
    }
}
