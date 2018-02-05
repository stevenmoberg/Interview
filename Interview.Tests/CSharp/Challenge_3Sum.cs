using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Interview.Tests.CSharp
{
    [TestClass]
    public class Challenge_3Sum
    {
        [TestMethod]
        public void Should_Find_UniqueSumOf3()
        {
            // Arrange
            var signatures = new List<string>();
            var signaturesExpected = new string[] { "-1,0,1", "-1,-1,2" };
            var values = new int[] { -1, 0, 1, 2, -1, -4 };

            // Act
            var zeros = ThreeSum(values).ToArray();

            // Assert
            foreach(var set in zeros)
            {
                var sorted = string.Join(",", set.OrderBy(x => x));
                // set has 3 items
                Assert.AreEqual(3, set.Length);
                // set sums to zero
                Assert.AreEqual(0, set.Sum());
                // set is unique
                CollectionAssert.DoesNotContain(signatures, sorted);
                signatures.Add(sorted);
            }

            var signaturesOrdered = signatures.OrderBy(x => x).ToArray();
            CollectionAssert.AreEqual(signaturesExpected, signaturesOrdered);
        }

        public IEnumerable<int[]> ThreeSum(int[] nums)
        {
            // return all unique triplets in the array which gives the sum of zero.
            yield break;
        }
    }
}
