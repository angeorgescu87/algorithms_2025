using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.TwoSum
{
    /// <summary>
    /// Provides an optimal solution to the TwoSum problem using the two-pointer technique.
    /// </summary>
    public class TwoSumTwoPointerSolution
    {
        /// <summary>
        /// Given an array of integers numbers that is already sorted in non-decreasing order, find two numbers such that they add up to a specific target number.
        /// Let these two numbers be numbers[index1] and numbers[index2] where 1<= index1 <= index2 <= numbers.length.
        /// Return the indices of the two numbers, index1 and index2, added by one as an integer array[index1, index2] of length 2.
        /// You may assume that each input would have exactly one solution and you may not use the same element twice.
        /// Time complexity: O(n) as we traverse the array only once with two pointers
        /// Space complexity: O(1) as we use constant extra space
        /// </summary>
        /// <param name="nums">Array of integers (sorted in non-decreasing order)</param>
        /// <param name="target">Target sum</param>
        /// <returns>Indices of the two numbers that add up to the target, or [-1, -1] if no solution exists</returns>
        public int[] FindTwoSum(int[] nums, int target)
        {
            // Check invalid input
            if (nums == null || nums.Length < 2)
                return new int[] { -1, -1 };

            int left = 0;
            int right = nums.Length - 1;

            while (left < right)
            {
                int sum = nums[left] + nums[right];

                if (sum == target)
                {
                    // Found the pair
                    return new int[] { left, right };
                }
                else if (sum < target)
                {
                    // If sum is less than target, move left pointer to increase the sum
                    left++;
                }
                else
                {
                    // If sum is greater than target, move right pointer to decrease the sum
                    right--;
                }
            }

            // No solution found
            return new int[] { -1, -1 };
        }
    }
}
