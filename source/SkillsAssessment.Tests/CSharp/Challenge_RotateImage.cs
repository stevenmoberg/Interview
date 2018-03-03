using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                { 5,   1,  9, 11 },
                { 2,   4,  8, 10 },
                { 13,  3,  6,  7 },
                { 15, 14, 12, 16 }
            };

            var expected = new int[,]
            {
                { 15, 13,  2,  5 },
                { 14,  3,  4,  1 },
                { 12,  6,  8,  9 },
                { 16,  7, 10, 11 }
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
            // Note: You have to rotate the image in-place, which means you have to modify the input 2D matrix directly. DO NOT allocate another 2D matrix and do the rotation. 
            throw new NotImplementedException("code solution here");
        }
    }
}
