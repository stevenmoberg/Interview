using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SkillsAssessment.Tests.CSharp
{
    [TestClass]
    public class Challenge_MoveZeros
    {
        [Medium]
        [TestMethod]
        public void Should_MoveZeros()
        {
            // Arrange
            var numbers = new int[] { 9, 2, 0, 1, 0, 12, 3 };
            var expected = new int[] { 9, 2, 1, 12, 3, 0, 0 };

            // Act
            MoveZeroes(numbers);

            // Assert
            CollectionAssert.AreEqual(expected, numbers);
        }

        /// <summary>
        /// Move all 0's to the end while maintaining the relative order of the non-zero elements
        /// </summary>
        /// <param name="nums"></param>
        void MoveZeroes(int[] nums)
        {
            // Task 1) must be done in-place without making a copy of the array
            // Task 2) mimizing the total number of operations

            throw new NotImplementedException("code solution here");
        }
    }
}
