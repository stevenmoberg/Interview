using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Interview.Tests.CSharp
{
    [TestClass]
    public class Test03 : BaseTest
    {
        [TestMethod]
        public void Should_Sum_Even_Numbers()
        {
            // Arrange
            var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Act
            var actual = SumEvenMumbers(numbers); 

            // Assert
            Assert.Equals(30, actual);
        }

        int SumEvenMumbers(IEnumerable<int> values)
        {
            // {code} - using Linq to sum all even numbers
            return 0;
        }
    }
}
