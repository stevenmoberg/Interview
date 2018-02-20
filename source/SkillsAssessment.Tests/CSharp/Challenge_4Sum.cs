using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SkillsAssessment.Tests.CSharp
{
    [TestClass]
    public class Challenge_4Sum
    {
        [TestMethod]
        public void Should_Find_UniqueSumOf4()
        {
            // Arrange
            var values = new int[] { 1, 0, -1, 0, -2, 2 };

            // Act
            var results_0 = FourSum(values, 0).ToArray();

            // Assert
            var actual = results_0.Select(x => string.Join(",", x.OrderBy(v => v))).OrderBy(x => x, StringComparer.Ordinal).ToArray();
            var expected = new string[] { "-1,0,0,1", "-2,-1,-1,2", "-2,0,0,2" };

            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Return all unique quadruplets in the array which gives the sum of the target.
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public IEnumerable<int[]> FourSum(int[] numbers, int target)
        {
            throw new NotImplementedException("code solution here");
        }

    }
}
