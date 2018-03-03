using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SkillsAssessment.Tests.CSharp
{
    [TestClass]
    public class Challenge_ReverseInteger
    {
        [Easy]
        [TestMethod]
        public void Should_ReverseInteger()
        {
            Assert.AreEqual(321, Reverse(123));
            Assert.AreEqual(-321, Reverse(-123));
            Assert.AreEqual(21, Reverse(120));
        }

        /// <summary>
        /// Given a 32 - bit signed integer, reverse digits of an integer.
        /// returns 0 when the reversed integer overflows. 
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        int Reverse(int x)
        {
            return 0;
        }
    }
}
