using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA45.Search_Sort
{
    //https://www.geeksforgeeks.org/problems/value-equal-to-index-value1330/1
    internal class ValEqualToIndex
    {
        public static List<int> valEqualToIndex(List<int> nums)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] == i + 1)
                {
                    result.Add(i + 1);
                }
            }
            return result;
        }
    }
}
