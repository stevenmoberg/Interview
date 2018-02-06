using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SkillsAssessment.Tests.CSharp
{
    /// <summary>
    /// Show 3 ways to pass parameters to a with examples
    /// by create 2 more unit tests showing different ways to pass parameters
    /// </summary>
    [TestClass]
    public class Test01 : BaseTest
    {
        [TestMethod]
        public void Should_PassParamters_ByValue()
        {
            // Arrange
            var value = 5;
            var expected = 10;


            // Act
            var actual = PassByValue(value);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        // function to test pass by value
        int PassByValue(int x)
        {
            return x * 2;
        }


        [TestMethod]
        public void Should_PassParamters_By2ndType()
        {
            // rename methods to actual type
            // create inline function to demo argument passing type

            // {code} - create simular test for the 2nd type
            throw new Exception("remove exception and create simular test fot the 2rd type");
        }


        [TestMethod]
        public void Should_PassParamters_By3rdType()
        {
            // rename methods to actual type
            // create inline function to demo argument passing type

            // {code} - create simular test for the 3nd type
            throw new Exception("remove exception and create simular test fot the 3rd type");
        }
    }
}
