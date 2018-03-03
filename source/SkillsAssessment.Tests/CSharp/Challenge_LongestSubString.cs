using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SkillsAssessment.Tests.CSharp
{
    [TestClass]
    public class Challenge_LongestSubString
    {
        [Medium]
        [TestMethod]
        public void Should_Find_LongestSubstring()
        {
            Assert.AreEqual("abc", LongestSubstring("abcabcbb"));
            Assert.AreEqual("b",   LongestSubstring("bbbbb"));
            Assert.AreEqual("wke", LongestSubstring("pwwkew"));
        }

        /// <summary>
        /// Given a string, find the longest substring without repeating characters.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string LongestSubstring(string s)
        {
            throw new NotImplementedException("code solution here");
        }
    }
}
