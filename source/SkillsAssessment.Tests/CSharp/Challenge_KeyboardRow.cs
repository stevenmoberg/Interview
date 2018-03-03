using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SkillsAssessment.Tests.CSharp
{
    [TestClass]
    public class Challenge_KeyboardRow
    {
        [Medium]
        [TestMethod]
        public void Should_Calculate_KeyboardRow()
        {
            // Arrange
            var input = new string[] { "Hello", "Alaska", "Dad", "Peace" };
            var expected = new string[] { "Alaska", "Dad" };

            // Act
            var actual = FindWords(input);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Return the words that can be typed using letters of alphabet on only one row's of American 
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        public string[] FindWords(string[] words)
        {
            throw new NotImplementedException("code solution here");
        }
    }
}
