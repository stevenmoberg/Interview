using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SkillsAssessment.Tests.CSharp
{
    [TestClass]
    public class Challenge_FizzBuzz : BaseTest
    {
        [Easy]
        [TestMethod]
        public void Should_Print_FizzBuzz()
        {
            // Arrange
            var expected = new string[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" };

            // Act
            var actual = FizzBuzz(15).ToArray();

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Return the string representations of numbers from 1 to n
        /// For each multiple of 3, returns "Fizz" instead of the number.
        /// For each multiple of 5, returns "Buzz" instead of the number.
        /// For numbers which are multiples of both 3 and 5, returns "FizzBuzz" instead of the number.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public IEnumerable<string> FizzBuzz(int n)
        {
            throw new NotImplementedException("write code here");
        }
    }
}
