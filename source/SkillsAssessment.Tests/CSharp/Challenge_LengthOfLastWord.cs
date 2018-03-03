using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SkillsAssessment.Tests.CSharp
{
    [TestClass]
    public class Challenge_LengthOfLastWord
    {
        [Easy]
        [TestMethod]
        public void Should_Calculate_Length_of_Last_Word()
        {
            // Arrange
            var words = "Hello Bob";

            // Act
            var length = LengthOfLastWord(words);

            // Assert
            Assert.AreEqual(3, length);
        }

        /// <summary>
        /// Calculate the length of the last word
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        public int LengthOfLastWord(string words)
        {
            throw new NotImplementedException("Code solution here");
        }
    }
}
