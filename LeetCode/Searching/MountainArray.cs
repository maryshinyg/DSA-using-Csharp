using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA45.Leetcode.Search
{
    internal class MountainArray
    {
        //https://leetcode.com/problems/peak-index-in-a-mountain-array/submissions/
        public static int PeakIndexInMountainArray(int[] arr)
        {
            int start = 0;
            int end = arr.Length - 1;
            while (start < end)
            {
                int mid = start + (end - start) / 2;
                if (arr[mid] > arr[mid + 1])
                //means we are in de part of the array,so the peak will be mid or in the left side of the mid
                {
                    //there's a possibility that this mid is the answer so end = mid, not mid -1;
                    end = mid;
                }
                else //id mid is smaller than mid+1, then we are in the increasing part of the array, so the peak will be in the right side of the mid
                {
                    //mid can't be the possible answer as the next ele in bigger so mid + 1
                    start = mid + 1;
                }
            }
            //once the loop ends, start and end will be at the same position(start == end), which is the peak
            return start;
        }
    }
}
