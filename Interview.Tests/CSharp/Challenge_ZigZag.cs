using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SkillsAssessment.Tests.CSharp
{
    [TestClass]
    public class Challenge_ZigZag
    {
        [TestMethod]
        public void Should_Print_ZigZag()
        {
            // Arrange;
            var text = "MOODYSSkillsAssessment";

            // Act
            // Assert
            Assert.Equals("MYTIODSNEVEOIRW", ZigZag(text, 3));
            Assert.Equals("MIIOSNVEOYTRWDE", ZigZag(text, 4));
        }


        // given - 3 rows
        // MOODYSSkillsAssessment
        // -------------------
        // M   Y   T   I
        // O D S N E V E 
        // O   I   R   W
        // -------------------
        // read left-to-right 
        // MYTIODSNEVEOIRW

        // given - 4 rows
        // MOODYSSkillsAssessment
        // -------------------
        // M     I     I
        // O   S N   V E
        // O Y   T R   W
        // D     E
        // -------------------
        // read left-to-right 
        // MIIOSNVEOYTRWDE


        public string ZigZag(string s, int numRows)
        {
            // stack string in the following zigzag pattern
            // re-read zigzag content from left to right without spaces

            /*n=numRows
              1                           2n-1                         4n-3
              2                     2n-2  2n                    4n-4   4n-2
              3               2n-3        2n+1              4n-5       .
              .           .               .               .            .
              .       n+2                 .           3n               .
              n-1 n+1                     3n-3    3n-1                 5n-5
              n                           3n-2                         5n-4
            */

            return string.Empty;
        }
    }
}
