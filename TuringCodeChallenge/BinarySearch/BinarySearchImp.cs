using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuringCodeChallenge.BinarySearch
{
    public static class BinarySearchImp
    {
        public static int BinarySearchRecursive(int[] arr, int start, int end, int target)
        {
            if (start > end) return -1; // Base case

            int mid = start + (end - start) / 2; // Find the midpoint

            if (arr[mid] == target) return mid; // Target found

            if (arr[mid] > target) 
                return BinarySearchRecursive(arr, start, mid - 1, target); 

            return BinarySearchRecursive(arr, mid + 1, end, target); 
        }

        public static int BinarySearchIterative(int[] arr, int target)
        {
            int start = 0;
            int end = arr.Length - 1;

            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (arr[mid] == target) return mid;

                if (arr[mid] < target)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }
            return -1;
        }
    }
}
