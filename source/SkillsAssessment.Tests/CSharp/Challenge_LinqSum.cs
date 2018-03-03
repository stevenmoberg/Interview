using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SkillsAssessment.Tests.CSharp
{
    [TestClass]
    public class Test03 : BaseTest
    {
        // Task 1) code solution using Linq to sum all even numbers

        [Easy]
        [TestMethod]
        public void Should_Sum_Even_Numbers()
        {
            // Arrange
            var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Act
            var actual = SumEvenNumbers(numbers);

            // Assert
            Assert.AreEqual(30, actual);
        }

        /// <summary>
        /// Returns the sum of all even numbers
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        int SumEvenNumbers(IEnumerable<int> values)
        {            
            throw new NotImplementedException("code solution here");
        }
    }
}
