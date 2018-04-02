using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsAssessment.Tests.CSharp
{
    [TestClass]
    public class Challenge_LetterChange
    {
        [Easy]
        [TestMethod]
        public void Should_Change_Letters()
        {
            // AAA
            Assert.AreEqual("Ifmmp*3", LetterChange("hello*3"));
            Assert.AreEqual("gvO Ujnft!", LetterChange("fun times!"));
        }


        /// <summary>
        /// Replace every letter in the string with the letter following it in the alphabet
        /// "c" becomes "d", "z" becomes "a"
        /// Then captialize every vowel in the new string (a,e,i,i,u)
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string LetterChange(string str)
        {
            return str;
        }
    }
}
