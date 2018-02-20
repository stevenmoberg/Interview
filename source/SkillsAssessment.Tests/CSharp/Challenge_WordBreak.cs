using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsAssessment.Tests.CSharp
{
    [TestClass]
    public class Challenge_WordBreak
    {
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
        /// Given a non-empty string s and a dictionary wordDict containing a list of non-empty words,
        /// add spaces in s to construct a sentence where each word is a valid dictionary word.
        /// You may assume the dictionary does not contain duplicate words.
        /// </summary>
        /// <example>
        /// s = "catsanddog",
        /// dict = ["cat", "cats", "and", "sand", "dog"].
        /// A solution is ["cats and dog", "cat sand dog"].
        /// </example>
        /// <param name="s"></param>
        /// <param name="wordDict"></param>
        /// <returns></returns>
        public IEnumerable<string> WordBreak(string s, IEnumerable<string> wordDict)
        {
            throw new NotImplementedException("Code method body");
        }
    }
}
