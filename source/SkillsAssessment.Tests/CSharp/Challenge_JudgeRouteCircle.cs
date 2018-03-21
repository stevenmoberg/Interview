using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SkillsAssessment.Tests.CSharp
{
    [TestClass]
    public class Challenge_JudgeRouteCircle
    {
        [Easy]
        [TestMethod]
        public void Should_Calculate_RouteCircle()
        {
            Assert.IsTrue(JudgeCircle("UDRL"));
            Assert.IsTrue(JudgeCircle("UURRDDLL"));
            Assert.IsFalse(JudgeCircle("LLUDR"));
        }

        /// <summary>
        /// Given a sequence of its moves, judge if this robot makes a circle, which means it moves back to the original place.
        /// Valid moves are 'R' right, 'L' left, 'U' up, and 'D' down
        /// </summary>
        /// <param name="moves"></param>
        /// <returns></returns>
        bool JudgeCircle(string moves)
        {
            throw new NotImplementedException("code solution here");
        }
    }
}
