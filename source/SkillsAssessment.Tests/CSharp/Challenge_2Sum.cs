using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsAssessment.Tests.CSharp
{
    [TestClass]
    public class Challenge_2Sum : BaseTest
    {
        [Medium]
        [TestMethod]
        public void Should_Calculate_TwoSum()
        {
            // Arrange
            var numbers = new int[] { 2, 7, 11, 15 };

            // Act
            var actual09 = TwoSum(numbers, 9);
            var actual13 = TwoSum(numbers, 13);
            var actual22 = TwoSum(numbers, 22);

            // Asset
            CollectionAssert.AreEqual(new int[] { 0, 1 }, actual09);
            CollectionAssert.AreEqual(new int[] { 0, 2 }, actual13);
            CollectionAssert.AreEqual(new int[] { 1, 3 }, actual22);
        }

        /// <summary>
        /// Given an array of integers, return indices of the two numbers such that they add up to a specific target.
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        private int[] TwoSum(int[] numbers, int target)
        {
            /// You may assume that each input would have exactly one solution, and you may not use the same element twice.

            throw new NotImplementedException("Code solution here");
        }
    }
}
