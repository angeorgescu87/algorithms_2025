using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Fibonacci
{
    /// <summary>
    /// Provides a recursive solution for calculating Fibonacci numbers.
    /// </summary>
    public class FibonacciRecursiveSolution
    {
        /// <summary>
        /// Calculates the nth Fibonacci number using pure recursion.
        /// The Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, ...
        /// Where F(0) = 0, F(1) = 1, and F(n) = F(n-1) + F(n-2) for n > 1
        /// 
        /// Time complexity: O(2^n) - exponential due to repeated calculations
        /// Space complexity: O(n) - due to the recursion stack depth
        /// 
        /// Note: This implementation is inefficient for large values of n due to the exponential time complexity.
        /// </summary>
        /// <param name="n">The position in the Fibonacci sequence (zero-based)</param>
        /// <returns>The nth Fibonacci number</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when n is negative</exception>
        public int Calculate(int n)
        {
            // Check for invalid input
            if (n < 0)
                throw new ArgumentOutOfRangeException(nameof(n), "Input must be a non-negative integer.");

            // Base cases
            if (n <= 1) return n;

            // Recursive case: F(n) = F(n-1) + F(n-2)
            return Calculate(n - 1) + Calculate(n - 2);
        }
    }
}
