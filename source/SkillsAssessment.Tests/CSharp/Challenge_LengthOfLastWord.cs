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
            // AAA
            Assert.AreEqual(3, LengthOfLastWord("Hello Bob"));
            Assert.AreEqual(7, LengthOfLastWord("A longer snippet"));
            Assert.AreEqual(6, LengthOfLastWord("  a  messy  string  "));
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
