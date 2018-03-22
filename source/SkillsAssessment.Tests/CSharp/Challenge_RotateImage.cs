using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace SkillsAssessment.Tests.CSharp
{
    [TestClass]
    public class Challenge_RotateImage
    {
        [Hard]
        [TestMethod]
        public void Should_Rotate_Image()
        {
            // Arrange
            var matrix = new int[,]
            {
                {  1,  2,  3,  4, 5 },
                { 16, 17, 18, 19, 6 },
                { 15, 24, 25, 20, 7 },
                { 14, 23, 22, 21, 8 },
                { 13, 12, 11, 10, 9 }
            };

            var expected = new int[,]
            {
                { 13, 14, 15, 16, 1 },
                { 12, 23, 24, 17, 2 },
                { 11, 22, 25, 18, 3 },
                { 10, 21, 20, 19, 4 },
                {  9,  8,  7,  6, 5 }
            };

            // Act
            Rotate(matrix);

            // Assert
            CollectionAssert.AreEqual(expected, matrix);
        }



        /// <summary>
        /// You are given an n x n 2D matrix representing an image.
        /// Rotate the image by 90 degrees(clockwise).
        /// </summary>
        /// <param name="matrix"></param>
        public void Rotate(int[,] matrix)
        {
            // Task) You have to rotate the image in-place, which means you have to modify the input 2D matrix directly. DO NOT allocate another 2D matrix and do the rotation.
        }
    }
}
