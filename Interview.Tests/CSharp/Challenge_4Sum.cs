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
            var signatures = new List<string>();
            var signaturesExpected = new string[] { "-1,0,0,1", "-2,-1,-1,2", "-2,0,0,2" };
            var values = new int[] { 1, 0, -1, 0 -2, 2 };
            var target = 0;

            // Act
            var results = FourSum(values, target).ToArray();

            // Assert
            foreach(var set in results)
            {
                var sorted = string.Join(",", set.OrderBy(x => x));
                // set has 3 items
                Assert.AreEqual(4, set.Length);
                // set sums to zero
                Assert.AreEqual(target, set.Sum());
                // set is unique
                CollectionAssert.DoesNotContain(signatures, sorted);
                signatures.Add(sorted);
            }

            var signaturesOrdered = signatures.OrderBy(x => x).ToArray();
            CollectionAssert.AreEqual(signaturesExpected, signaturesOrdered);
        }

        public IEnumerable<int[]> FourSum(int[] nums, int target)
        {
            // return all unique quadruplets in the array which gives the sum of the target.
            yield break;
        }
    }
}
