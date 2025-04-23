using Examples.TwoSum;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Examples.Tests.TwoSum
{
    [TestClass]
    public class TwoSumBinarySearchSolutionTests
    {
        private readonly TwoSumBinarySearchSolution _solution;

        public TwoSumBinarySearchSolutionTests()
        {
            _solution = new TwoSumBinarySearchSolution();
        }

        [DataTestMethod]
        [DataRow(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        [DataRow(new int[] { 2, 3, 4 }, 6, new int[] { 0, 2 })]
        [DataRow(new int[] { -1, 0 }, -1, new int[] { 0, 1 })]
        public void FindTwoSum_WithValidInputs_ReturnsCorrectIndices(int[] numbers, int target, int[] expected)
        {
            // Act
            var result = _solution.FindTwoSum(numbers, target);

            // Assert
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FindTwoSum_WithEmptyArray_ReturnsMinusOneIndices()
        {
            // Arrange
            int[] numbers = new int[] { };
            int target = 10;
            int[] expected = new int[] { -1, -1 };

            // Act
            var result = _solution.FindTwoSum(numbers, target);

            // Assert
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FindTwoSum_WithNoSolution_ReturnsMinusOneIndices()
        {
            // Arrange
            int[] numbers = new int[] { 1, 2, 3 };
            int target = 10;
            int[] expected = new int[] { -1, -1 };

            // Act
            var result = _solution.FindTwoSum(numbers, target);

            // Assert
            CollectionAssert.AreEqual(expected, result);
        }
    }
}
