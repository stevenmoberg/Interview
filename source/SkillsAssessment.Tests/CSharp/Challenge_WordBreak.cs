using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SkillsAssessment.Tests.CSharp
{
    [TestClass]
    public class Challenge_WordBreak
    {
        [Medium]
        [TestMethod]
        public void Should_Calculate_WordBreak()
        {
            // Arrage
            var text = "catsanddog";
            var words = new string[] { "cat", "cats", "and", "sand", "dog" };

            // Act
            var phrases = WordBreak(text, words).ToArray();

            // Assert
            CollectionAssert.Contains(phrases, "cats and dog");
            CollectionAssert.Contains(phrases, "cat sand dog");
            Assert.AreEqual(2, phrases.Length);
        }

        /// <summary>
        /// Given a non-empty string s and a dictionary containing a list of non-empty words,
        /// add spaces to construct a sentence where each word is a valid dictionary word.
        /// You may assume the dictionary does not contain duplicate words.
        /// </summary>
        /// <example>
        /// s = "catsanddog",
        /// words = ["cat", "cats", "and", "sand", "dog"].
        /// A solution is ["cats and dog", "cat sand dog"].
        /// </example>
        /// <param name="text"></param>
        /// <param name="wordDict"></param>
        /// <returns></returns>
        public IEnumerable<string> WordBreak(string text, IEnumerable<string> words)
        {
            throw new NotImplementedException("Code method body");
        }
    }
}
