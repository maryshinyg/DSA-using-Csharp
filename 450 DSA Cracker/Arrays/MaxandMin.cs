using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA45.Arrays
{
    internal class MaxandMin
    {
        public static void MaxMin(int[] arr)
        {
            int min = int.MaxValue;
            int max = int.MinValue;

            for(int i=0; i<arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine($"Min{min} and Max{max}");
        }
    }
}
