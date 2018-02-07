using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsAssessment.Tests.CSharp
{
    [TestClass]
    public class Challenge_InterleavingString
    {
        [TestMethod]
        public void Should_Interview_Strings()
        {
            // Given s1, s2, s3, find whether s3 is formed by the interleaving of s1 and s2. 
            // For example,
            // Given:
            // s1 = "aabcc",
            // s2 = "dbbca", 
            // When s3 = "aadbbcbcac", return true.
            // When s3 = "aadbbbaccc", return false.

            Assert.IsTrue(IsInterleave("aabcc", "dbbca", "aadbbcbcac"));
            Assert.IsFalse(IsInterleave("aabcc", "dbbca", "aadbbbaccc"));
        }

        public bool IsInterleave(string s1, string s2, string s3)
        {
            return false;
        }
    }
}
