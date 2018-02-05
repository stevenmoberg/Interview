using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Interview.Tests.CSharp
{
    [TestClass]
    public class Challenge_LongestSubString
    {
        [TestMethod]
        public void Should_Find_LongestSubstring()
        {
            Assert.AreEqual("abc", LongestSubstring("abcabcbb"));
            Assert.AreEqual("b",   LongestSubstring("bbbbb"));
            Assert.AreEqual("wke", LongestSubstring("pwwkew"));
        }

        public string LongestSubstring(string s)
        {
            // Given a string, find the longest substring without repeating characters.
            return string.Empty;
        }
    }
}
