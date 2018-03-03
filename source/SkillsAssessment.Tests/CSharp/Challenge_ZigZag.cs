using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SkillsAssessment.Tests.CSharp
{
    [TestClass]
    public class Challenge_ZigZag
    {
        [Hard]
        [TestMethod]
        public void Should_Print_ZigZag()
        {
            // Arrange;
            var text = "MOODYSINTERVIEW";

            // Act
            // Assert
            Assert.AreEqual("MYTIODSNEVEOIRW", ZigZag(text, 3));
            Assert.AreEqual("MIIOSNVEOYTRWDE", ZigZag(text, 4));
        }


        // given - 3 rows
        // MOODYSINTERVIEW
        // -------------------
        // M   Y   T   I
        // O D S N E V E 
        // O   I   R   W
        // -------------------
        // read left-to-right 
        // MYTIODSNEVEOIRW

        // given - 4 rows
        // MOODYSINTERVIEW
        // -------------------
        // M     I     I
        // O   S N   V E
        // O Y   T R   W
        // D     E
        // -------------------
        // read left-to-right 
        // MIIOSNVEOYTRWDE


        /// <summary>
        /// Stack string in the following zigzag pattern
        /// Re-read zigzag content from left to right without spaces
        /// </summary>
        /// <remarks>
        /// n=numRows
        /// 
        /// 1                           2n-1                         4n-3
        /// 2                     2n-2  2n                    4n-4   4n-2
        /// 3               2n-3        2n+1              4n-5       .
        /// .           .               .               .            .
        /// .       n+2                 .           3n.
        /// n-1 n+1                     3n-3    3n-1                 5n-5
        /// n                           3n-2                         5n-4
        /// </remarks>
        /// <param name="s"></param>
        /// <param name="numRows"></param>
        /// <returns></returns>
        public string ZigZag(string s, int numRows)
        {
            throw new NotImplementedException("Code solution here");
        }
    }
}
