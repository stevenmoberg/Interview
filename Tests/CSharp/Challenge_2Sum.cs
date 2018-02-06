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
        [TestMethod]
        public void Should_Calculate_TwoSum()
        {
            // Arrange
            var numbers = new int[] { 2, 7, 11, 15 };

            // Act
            var actual = TwoSum(numbers, 9);

            // Asset
            Assert.Fail("Replace with correct assertions");
        }

        private int[] TwoSum(int[] numbers, int target)
        {
            // Given an array of integers, return indices of the two numbers such that they add up to a specific target.
            // You may assume that each input would have exactly one solution, and you may not use the same element twice.

            return new int[] { 0, 0 };
        } 
    }
}
