using Examples.Fibonacci;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Examples.Tests.Fibonacci
{
    [TestClass]
    public class FibonacciRecursiveSolutionTests
    {
        private readonly FibonacciRecursiveSolution _solution;

        public FibonacciRecursiveSolutionTests()
        {
            _solution = new FibonacciRecursiveSolution();
        }

        [DataTestMethod]
        [DataRow(0, 0)]
        [DataRow(1, 1)]
        [DataRow(2, 1)]
        [DataRow(3, 2)]
        [DataRow(4, 3)]
        [DataRow(5, 5)]
        [DataRow(6, 8)]
        [DataRow(7, 13)]
        [DataRow(8, 21)]
        [DataRow(9, 34)]
        [DataRow(10, 55)]
        public void Calculate_WithValidInputs_ReturnsCorrectFibonacciNumber(int n, int expected)
        {
            // Act
            var result = _solution.Calculate(n);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Calculate_WithNegativeInput_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
            int n = -1;

            // Act & Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _solution.Calculate(n));
        }

        [TestMethod]
        [Ignore("This test demonstrates performance limitations of recursive implementation without memoization")]
        public void Calculate_WithLargeInput_TakesSignificantTime()
        {
            // Note: This test is ignored by default as it will take a very long time to complete
            // due to the exponential time complexity of the non-memoized recursive solution
            
            // Arrange
            int n = 40; // Even this relatively small value will take a significant amount of time
            
            // Act
            var result = _solution.Calculate(n);
            
            // Assert
            Assert.AreEqual(102334155, result);
        }
    }
}
