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
        [Hard]
        [TestMethod]
        public void Should_Interleave_Strings()
        {
            Assert.IsTrue(IsInterleave("aabcc", "dbbca", "aadbbcbcac"));
            Assert.IsFalse(IsInterleave("aabcc", "dbbca", "aadbbbaccc"));
        }

        /// <summary>
        /// Given s1, s2, s3, find whether s3 is formed by the interleaving of s1 and s2.
        /// For example,
        /// Given:
        /// s1 = "aabcc",
        /// s2 = "dbbca",
        /// When s3 = "aadbbcbcac", return true.
        /// When s3 = "aadbbbaccc", return false.
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <param name="s3"></param>
        /// <returns></returns>
        public bool IsInterleave(string s1, string s2, string s3)
        {
            throw new NotImplementedException("code solution here");
        }
    }
}
