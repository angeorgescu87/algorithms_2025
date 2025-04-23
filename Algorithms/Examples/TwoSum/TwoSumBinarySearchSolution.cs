using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.TwoSum
{
    /// <summary>
    /// Provides a solution to the TwoSum problem using binary search.
    /// </summary>
    public class TwoSumBinarySearchSolution
    {
        /// <summary>
        /// Given an array of integers numbers that is already sorted in non-decreasing order, find two numbers such that they add up to a specific target number.
        /// Let these two numbers be numbers[index1] and numbers[index2] where 1<= index1 <= index2 <= numbers.length.
        /// Return the indices of the two numbers, index1 and index2, added by one as an integer array[index1, index2] of length 2.
        /// You may assume that each input would have exactly one solution and you may not use the same element twice.
        /// Time complexity: O(n log n) as it performs binary search for each element in the array
        /// Space complexity: O(1) as it uses constant extra space
        /// </summary>
        /// <param name="nums">Array of integers (sorted in non-decreasing order)</param>
        /// <param name="target">Target sum</param>
        /// <returns>Indices of the two numbers that add up to the target, or [-1, -1] if no solution exists</returns>
        public int[] FindTwoSum(int[] nums, int target)
        {
            // Check invalid input
            if (nums == null || nums.Length < 2)
                return new int[] { -1, -1 };

            // For each element, perform binary search for its complement
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                
                // Binary search for the complement, starting from i+1 to avoid using the same element
                int j = BinarySearch(nums, complement, i + 1, nums.Length - 1);
                
                if (j != -1)
                {
                    return new int[] { i, j };
                }
            }

            // No solution found
            return new int[] { -1, -1 };
        }

        /// <summary>
        /// Performs binary search for a target value in a sorted array within a specified range.
        /// </summary>
        /// <param name="nums">The sorted array to search in</param>
        /// <param name="target">The value to search for</param>
        /// <param name="left">The left boundary (inclusive)</param>
        /// <param name="right">The right boundary (inclusive)</param>
        /// <returns>Index of the target if found, otherwise -1</returns>
        private int BinarySearch(int[] nums, int target, int left, int right)
        {
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                
                if (nums[mid] == target)
                {
                    return mid;
                }
                
                if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            
            return -1;
        }
    }
}
