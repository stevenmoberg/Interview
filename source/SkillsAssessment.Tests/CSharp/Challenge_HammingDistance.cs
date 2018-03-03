using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SkillsAssessment.Tests.CSharp
{
    [TestClass]
    public class Challenge_HammingDistance
    {
        [Medium]
        [TestMethod]
        public void Should_Calculate_HammingDistance()
        {
            var expected = 2;
            var actual = HammingDistance(1, 4);

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Calculate the Hamming distance between two integers
        /// </summary>
        /// <remarks>
        /// The Hamming distance is the number of positions at which the corresponding bits are different.
        /// </remarks>
        /// <example>
        /// Input: x = 1, y = 4
        /// Output: 2
        /// Explanation:
        /// 1   (0 0 0 1)
        /// 4   (0 1 0 0)
        ///        ↑   ↑
        /// </example>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        int HammingDistance(int x, int y)
        {
            throw new NotImplementedException("code solution here");
        }
    }
}
