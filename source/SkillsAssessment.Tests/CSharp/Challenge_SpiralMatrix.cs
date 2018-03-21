using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SkillsAssessment.Tests.CSharp
{
    [TestClass]
    public class Challenge_SpiralMatrix
    {
        [Hard]
        [TestMethod]
        public void Should_Create_SpiralMatrix()
        {
            // Arrange
            var expected3 = new int[,]
            {
                { 1, 2, 3 },
                { 8, 9, 4 },
                { 7, 6, 5 }
            };

            var expected4 = new int[,]
            {
                {  1,  2,  3, 4 },
                { 12, 13, 14, 5 },
                { 11, 16, 15, 6 },
                { 10,  9,  8, 7 }
            };

            // Act
            var actual3 = GenerateMatrix(3);
            var actual4 = GenerateMatrix(4);

            // Assert
            AssertEx.AreEqual(expected3, actual3);
            AssertEx.AreEqual(expected4, actual4);
        }

        /// <summary>
        /// Given an integer n, generate a square matrix filled with the elements 1 to n² in spiral order
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int[,] GenerateMatrix(int n)
        {
            throw new NotImplementedException("Code method body");
        }
    }
}
