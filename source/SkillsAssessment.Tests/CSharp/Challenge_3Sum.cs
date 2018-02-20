using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SkillsAssessment.Tests.CSharp
{
    [TestClass]
    public class Challenge_3Sum
    {
        [TestMethod]
        public void Should_Find_UniqueSumOf3()
        {
            // Arrange
            var values = new int[] { -1, 0, 1, 2, -1, -4 };

            // Act
            var results = ThreeSum(values).ToArray();

            // Assert
            var actual = results.Select(x => string.Join(",", x.OrderBy(v => v))).OrderBy(x => x).ToArray();
            var expected = new string[] { "-1,0,1", "-1,-1,2" };

            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Return all unique triplets in the array which gives the sum of zero.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public IEnumerable<int[]> ThreeSum(int[] nums)
        {
            throw new NotImplementedException("code method body here");
        }
    }
}
