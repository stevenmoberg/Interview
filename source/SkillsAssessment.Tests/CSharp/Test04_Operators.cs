using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SkillsAssessment.Tests.CSharp
{
    [TestClass]
    public class Test04 : BaseTest
    {
        [TestMethod]
        public void Should_Create_OperatorOverload()
        {
            // Arrange
            var item2 = new OpTest(11.1);
            var item1 = new OpTest(22.2);

            // Act
            //## var actual = item1 + item2;

            // Assert
            //## Assert.AreEqual(33.3d, actual.Number);
            throw new Exception("remove '//##' and exception and");
        }

        [TestMethod]
        public void Should_Create_Explict_Operator()
        {
            // Arrange

            // Act
            // {code} - remove comment
            //## var actual = (OpTest)"12.2";

            // Assert
            //## Assert.AreEqual(12.2d, actual.Number);
            throw new Exception("remove '//##' and exception and");
        }


        private class OpTest
        {
            public OpTest() { }
            public OpTest(double number)
            {
                Number = number;
            }

            public double Number { get; set; }

            // {code} - create overloaded operator to add two items

            // {code} - Create an explict operator to convert from string
        }
    }
}
