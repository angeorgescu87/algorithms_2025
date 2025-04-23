using System;
using Examples.Fibonacci;

namespace Examples.Tests.Fibonacci
{
    [TestClass]
    public class FibonacciRecursiveMemoizationSolutionTests
    {
        private readonly FibonacciRecursiveMemoizationSolution _solution;

        public FibonacciRecursiveMemoizationSolutionTests()
        {
            _solution = new FibonacciRecursiveMemoizationSolution();
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
        [DataRow(20, 6765)]
        [DataRow(30, 832040)]
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
    }
}
