using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Interview.Tests.CSharp
{
    [TestClass]
    public class Challenge_FizzBuzz : BaseTest
    {
        /// <summary>
        /// Write a short program that prints each number from 1 to 100 on a new line.
        /// </summary>
        [TestMethod]
        public void Should_Print_FizzBuzz()
        {
            // Arrange
            var expected = "1,2,Fizz,4,Buzz,Fizz,7,8,Fizz,Buzz,11,Fizz,13,14,FizzBuzz".Split(',');

            // Act
            var actual = FizzBuzz(15).ToArray();

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        public IEnumerable<string> FizzBuzz(int n)
        {
            // Write the method body to return the string representation of numbers from 1 to n.
            // For each multiple of 3, print "Fizz" instead of the number. 
            // For each multiple of 5, print "Buzz" instead of the number. 
            // For numbers which are multiples of both 3 and 5, print "FizzBuzz" instead of the number.

            // {code}

            yield break;
        }
    }
}
