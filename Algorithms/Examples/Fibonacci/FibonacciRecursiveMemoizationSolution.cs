using System;
using System.Collections.Generic;

namespace Examples.Fibonacci
{
    /// <summary>
    /// Provides a recursive solution for calculating Fibonacci numbers with memoization.
    /// </summary>
    public class FibonacciRecursiveMemoizationSolution
    {
        private readonly Dictionary<int, int> _memo = new();

        /// <summary>
        /// Calculates the nth Fibonacci number using recursion and memoization.
        /// The Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, ...
        /// Where F(0) = 0, F(1) = 1, and F(n) = F(n-1) + F(n-2) for n > 1
        /// 
        /// Time complexity: O(n) - due to memoization
        /// Space complexity: O(n) - for the memoization dictionary and recursion stack depth
        /// </summary>
        /// <param name="n">The position in the Fibonacci sequence (zero-based)</param>
        /// <returns>The nth Fibonacci number</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when n is negative</exception>
        public int Calculate(int n)
        {
            // Check for invalid input
            if (n < 0)
                throw new ArgumentOutOfRangeException(nameof(n), "Input must be a non-negative integer.");

            // Check if the result is already memoized
            if (_memo.ContainsKey(n))
                return _memo[n];

            // Base cases
            if (n <= 1)
                return n;

            // Recursive case with memoization
            int result = Calculate(n - 1) + Calculate(n - 2);
            _memo[n] = result; // Store the result in the memo dictionary
            return result;
        }
    }
}
