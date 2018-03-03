using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsAssessment.Tests.CSharp
{
    [TestClass]
    public class Challenge_Merge_Intervals
    {
        [Medium]
        [TestMethod]
        public void Should_Merge_Intervals()
        {
            // Arrange
            var values = new Interval[] {
                new Interval(1, 3),
                new Interval(2, 6),
                new Interval(8, 10),
                new Interval(15, 18)
            };

            // Act
            var actual = Merge(values);

            // Assert
            var expected = new Interval[]
            {
                new Interval(1,6),
                new Interval(8,10),
                new Interval(15,18)
            };

            AssertEx.AreEqual(expected, actual);
        }

        /// <summary>
        /// Given a collection of intervals, merge all overlapping intervals.
        /// </summary>
        /// <param name="intervals"></param>
        /// <returns></returns>
        public IEnumerable<Interval> Merge(IEnumerable<Interval> intervals)
        {
            throw new NotImplementedException("Code solution here");
        }

        public class Interval
        {
            public Interval() : this(0, 0) { }
            public Interval(int start, int end) { Start = start; End = end; }
            public int Start;
            public int End;
        }
    }
}
