using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SkillsAssessment.Tests.CSharp
{
    [TestClass]
    public class Challenge_ReverseInteger
    {
        [TestMethod]
        public void Should_ReverseInteger()
        {
            Assert.AreEqual(321, Reverse(123));
            Assert.AreEqual(-321, Reverse(-123));
            Assert.AreEqual(21, Reverse(120));
        }

        int Reverse(int x)
        {
            // Given a 32 - bit signed integer, reverse digits of an integer.
            // returns 0 when the reversed integer overflows.
            return 0;
        }
    }
}
