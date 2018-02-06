using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SkillsAssessment.Tests.CSharp
{
    [TestClass]
    public class Challenge_RomanNumeral
    {
        // Given an integer, convert it to a roman numeral.
        // Input is guaranteed to be within the range from 1 to 3999.

        // [Reference]
        // https://en.wikipedia.org/wiki/Roman_numerals 
        // I = 1
        // V = 5
        // X = 10
        // L = 50
        // C = 100   
        // D = 500
        // M = 1000

        // 1-10         I, II, III, IV, V, VI, VII, VIII, IX, X
        // 10-100       X, XX, XXX, XL, L, LX, LXX, LXXX, XC, C
        // 100-1000     C, CC, CCC, CD, D, DC, DCC, DCCC, CM, M

        // [Example]
        //   39 = XXXIX  - three tens and a ten less one
        //  246 = CCXLVI - two hundreds, a fifty less ten, a five and a one
        //  207 = CCVII  - two hundreds, a five and two ones
        // 1066 = MLXVI  - a thousand, a fifty and a ten, a five and a one


        [TestMethod]
        public void Should_Convert_NumberToRoman()
        {
            Assert.AreEqual("MDCCLXXVI", IntToRoman(1776));
            Assert.AreEqual("MCMLIV", IntToRoman(1954));
            Assert.AreEqual("MCMXC", IntToRoman(1990));
            Assert.AreEqual("MMXIV", IntToRoman(2014));
            Assert.AreEqual("XXII", 22);
        }

        [TestMethod]
        public void Should_Convert_RomanToNumber()
        {
            Assert.AreEqual(1776, RomainToInt("MDCCLXXVI"));
            Assert.AreEqual(1954, RomainToInt("MCMLIV"));
            Assert.AreEqual(1990, RomainToInt("MCMXC"));
            Assert.AreEqual(2014, RomainToInt("MMXIV"));
            Assert.AreEqual(22, RomainToInt("XXII"));
        }

        string IntToRoman(int num)
        {
            return string.Empty;
        }

        int RomainToInt(string roman)
        {
            return 0;
        }
    }
}
