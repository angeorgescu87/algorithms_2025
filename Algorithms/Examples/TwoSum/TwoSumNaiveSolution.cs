using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.TwoSum
{
    /// <summary>
    /// Provides a naive solution to the TwoSum problem.
    /// </summary>
    public class TwoSumNaiveSolution
    {
        /// <summary>
        /// Given an array of integers numbers that is already sorted in non-decreasing order, find two numbers such that they add up to a specific target number.Let these two numbers be numbers[index1] and numbers[index2] where 1<= index1 <= index2 <= numbers.length.
        /// Return the indices of the two numbers, index1 and index2, added by one as an integer array[index1, index2] of length 2.
        /// You may assume that each input would have exactly one solution and you may not use the same element twice.
        /// Time complexity: O(n²) as it uses two nested loops to check for every possible combination
        /// Space complexity: O(1) as it does not use any additional data structures.
        /// </summary>
        /// <param name="nums">Array of integers</param>
        /// <param name="target">Target sum</param>
        /// <returns>Indices of the two numbers that add up to the target, or null if no solution exists</returns>
        public int[] FindTwoSum(int[] nums, int target)
        {
            // Check invalid input
            if (nums == null || nums.Length < 2)
                return new int[] { -1, -1 };

            // Naive approach: check every combination of two values and see if the sum equals our target​
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            // No solution found
            return new int[] {-1, -1};
        }
    }
}
