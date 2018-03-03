using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace SkillsAssessment.Tests.CSharp
{
    [TestClass]
    public class Challenge_GroupAnagrams
    {
        [Medium]
        [TestMethod]
        public void Should_Group_Anagrams()
        {
            // Arrange
            var words = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };

            // Act
            var actual = GroupByAnagrams(words);

            // Assert
            var expected = new string[][]
            {
                new string[] { "ate", "eat", "tea" },
                new string[] { "nat", "tan" },
                new string[] { "bat" }
            };

            AssertEx.AreEqual(expected, actual);
        }

        /// <summary>
        /// Given an array of strings, group anagrams together
        /// Sort groups by size, large to small
        /// Sort group content aphabetically
        /// </summary>
        /// <remarks>
        /// anagram - a word, phrase, or name formed by rearranging the letters of another
        /// </remarks>
        /// <param name="words"></param>
        /// <returns></returns>
        public IEnumerable<IEnumerable<string>> GroupByAnagrams(IEnumerable<string> words)
        {
            throw new NotImplementedException("Code method body here");
        }
    }
}
