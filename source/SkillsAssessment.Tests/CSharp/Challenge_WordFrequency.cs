using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SkillsAssessment.Tests.CSharp
{
    [TestClass]
    public class Challenge_WordFrequency
    {
        [Medium]
        [TestMethod]
        public void Should_Calculate_WordFrequency()
        {
            // Arrange
            var text = @"
the day is sunny the the
the sunny is is
".Trim();
            var expected = @"
the 4
is 3
sunny 2
day 1
".Trim();

            // Act
            var actual = CreateWordFrequency(text);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Return output the word frequency sorted by descending frequency
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        string CreateWordFrequency(string text)
        {
            throw new NotImplementedException("code solution here");
        }
    }
}
