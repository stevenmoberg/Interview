using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SkillsAssessment.Tests.CSharp
{
    [TestClass]
    public class Test02 : BaseTest
    {
        [TestMethod]
        public void Should_Calculate_Average_For_Two_Numbers()
        {
            // Arrange 
            var expected = 1.5d;

            // Act
            var actual = Average(1, 2);

            // Assert
            Assert.Equals(expected, actual);
        }

        private double Average(int x, int y)
        {
            // {code} - fix this method
            return x + y / 2;
        }
    }
}
