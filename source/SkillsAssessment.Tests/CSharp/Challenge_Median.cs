using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SkillsAssessment.Tests.CSharp
{
    [TestClass]
    public class Challenge_Median
    {
        [TestMethod]
        public void Should_Calculate_Median()
        {
            Assert.AreEqual(2.0d, FindMedianSortedArrays(new int[] { 1, 3 }, new int[] { 2 }));
            Assert.AreEqual(2.5d, FindMedianSortedArrays(new int[] { 1, 2 }, new int[] { 3, 4 }));
        }

        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            // There are two sorted arrays nums1 and nums2 of size m and n respectively.
            // Find the median of the two sorted arrays. 
            return 0d;
        }
    }
}
