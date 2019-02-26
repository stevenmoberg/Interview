using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace SkillsAssessment.Tests.CSharp
{
    [TestClass]
    public class Challenge_StringLogicalComparer
    {
        [Medium]
        [TestMethod]
        public void Should_Compare_VersionNumbers()
        {
            var comparer = new StringLogicalComparer();
            // Assert
            var versions = new string[] {
                "18.2",
                "18.11",
                "1.1",
                "1.12",
                "0.1",
                "1.2",
                "13.37"
            };
            var expected = new string[] {
                "0.1",
                "1.1",
                "1.2",
                "1.12",
                "13.37",
                "18.2",
                "18.11"
            };

            // Act
            var actual = versions.OrderBy(x => x, comparer);

            // Assert
            AssertEx.AreEqual(expected, actual);
        }

        [Medium]
        [TestMethod]
        public void Should_Compare_LogicalStrings()
        {
            var alphabetical = new string[]
            {
                "1",
                "10",
                "3",
                "a10b1",
                "a1b1",
                "a2b1",
                "a2b11",
                "a2b2",
                "b1",
                "b10",
                "b2"
            };
            var logical = new string[]
            {
                "1",
                "3",
                "10",
                "a1b1",
                "a2b1",
                "a2b2",
                "a2b11",
                "a10b1",
                "b1",
                "b2",
                "b10"
            };

            var comparer = new StringLogicalComparer();
            var sorted = alphabetical.OrderBy(x => x, comparer);
            AssertEx.AreEqual(logical, sorted);
        }

        /// <summary>
        /// Logical String Comparer to sort natural numbers inside words
        /// </summary>
        public class StringLogicalComparer : IComparer, IComparer<string>
        {
            public int Compare(object x, object y)
            {
                var s1 = x as string;
                var s2 = y as string;
                return Compare(s1, s2);
            }

            public int Compare(string x, string y)
            {
                return StrCmpLogicalW(x, y);
            }

            [DllImport("shlwapi.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
            private static extern int StrCmpLogicalW(string x, string y);
        }
    }
}
