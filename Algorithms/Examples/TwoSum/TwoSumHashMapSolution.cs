using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.TwoSum
{
    /// <summary>
    /// Provides an optimized solution to the TwoSum problem using a HashMap.
    /// </summary>
    public class TwoSumHashMapSolution
    {
        /// <summary>
        /// Given an array of integers numbers that is already sorted in non-decreasing order, find two numbers such that they add up to a specific target number.
        /// Let these two numbers be numbers[index1] and numbers[index2] where 1<= index1 <= index2 <= numbers.length.
        /// Return the indices of the two numbers, index1 and index2, added by one as an integer array[index1, index2] of length 2.
        /// You may assume that each input would have exactly one solution and you may not use the same element twice.
        /// Time complexity: O(n) as it uses a single pass with HashMap lookup which has O(1) time complexity
        /// Space complexity: O(n) as it uses a HashMap to store numbers and their indices
        /// </summary>
        /// <param name="nums">Array of integers</param>
        /// <param name="target">Target sum</param>
        /// <returns>Indices of the two numbers that add up to the target, or [-1, -1] if no solution exists</returns>
        public int[] FindTwoSum(int[] nums, int target)
        {
            // Check invalid input
            if (nums == null || nums.Length < 2)
                return new int[] { -1, -1 };

            // Dictionary to store complementary values and their indices
            Dictionary<int, int> numMap = new Dictionary<int, int>();

            // Single pass approach
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                
                // If we've seen the complement before, we found our pair
                if (numMap.ContainsKey(complement))
                {
                    return new int[] { numMap[complement], i };
                }
                
                // Store current number and its index if not already in the dictionary
                if (!numMap.ContainsKey(nums[i]))
                {
                    numMap.Add(nums[i], i);
                }
            }

            // No solution found
            return new int[] { -1, -1 };
        }
    }
}
