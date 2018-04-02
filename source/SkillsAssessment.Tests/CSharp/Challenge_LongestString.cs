using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsAssessment.Tests.CSharp
{
    [TestClass]
    public class Challenge_LongestString
    {
        [Easy]
        [TestMethod]
        public void Should_Find_Longest_String()
        {
            // AAA
            Assert.AreEqual("time", LongestWord("fune&!!time"));
            Assert.AreEqual("love", LongestWord("I love dogs"));

        }

        /// <summary>
        /// Returns the longest word in the string
        /// If there are two or more words with the same length, return the first world with that lenght
        /// </summary>
        /// <param name="phrase"></param>
        /// <returns></returns>
        public string LongestWord(string phrase)
        {
            return phrase;
        }
    }
}
