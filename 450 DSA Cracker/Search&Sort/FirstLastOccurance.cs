using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA45.Leetcode.Search
{
    //https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/description/
    internal class FirstLastOccurance
    {
        public int[] SearchRange(int[] nums, int target)
        {
            int[] ans = { -1, -1 };
            int start = search(nums, target, true);
            int end = search(nums, target, false);
            ans[0] = start;
            ans[1] = end;
            return ans;
        }

        int search(int[] nums, int target, bool findStartIndex) //findStartIndex is to find if we are checking the right side or left side of the current == elemnt.
        {
            int ans = -1;
            int start = 0;
            int end = nums.Length - 1;

            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (target < nums[mid])
                {
                    end = mid - 1;
                }
                else if (target > nums[mid])
                {
                    start = mid + 1;
                }
                else
                {
                    ans = mid; //can be potential answer
                    if (findStartIndex) //checking the left side of the current potential 
                    {
                        end = mid - 1;
                    }
                    else //checking the right side of the current potential 
                    {
                        start = mid + 1;
                    }
                }
            }
            return ans;
        }
    }

}
