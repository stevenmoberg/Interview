using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SkillsAssessment.Tests.CSharp
{
    [TestClass]
    public class Challenge_CompareVersionNumbers
    {
        [Medium]
        [TestMethod]
        public void Should_Compare_VersionNumbers()
        {
            // Assert
            var versions = new string[] { "18.21", "18.11", "1.1", "1.12", "0.1", "1.2", "13.37" };
            var comparer = new VersionComparer();

            // Act
            var actual = versions.OrderBy(x => x, comparer);

            // Assert
            var expected = new string[] { "0.1", "1.1", "1.2", "1.12", "13.37", "18.11", "18.21" };
            AssertEx.AreEqual(expected, actual);
        }

        /// <summary>
        /// Logical String Comparer to sort versions in proper order
        /// </summary>
        public class VersionComparer : IComparer<string>
        {
            public int Compare(string x, string y)
            {
                throw new NotImplementedException("code implementation here");
            }
        }
    }
}
