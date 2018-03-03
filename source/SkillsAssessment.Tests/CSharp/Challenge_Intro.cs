using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsAssessment.Tests.CSharp
{
    [TestClass]
    public class Challenge_Intro
    {
        // Task 1) additional test notes/constraints will exists here

        [Intro]
        [TestMethod]
        public void Should_Add_Two_Numbers()
        {
            Assert.AreEqual(2, Add(1, 1), "1+1 shouuld equal 2");
            Assert.AreEqual(3, Add(1, 2), "1+2 should equal 3");
            Assert.AreEqual(3, Add(2, 1), "2+1 should equal 3");
            Assert.AreEqual(5, Add(2, 3), "2+3 should equal 5");
        }

        /// <summary>
        /// Add two ints
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <returns></returns>
        public int Add(int value1, int value2)
        {
            // Fix failing tests by:
            //  - fixing existing method body
            //  - create missing method body
            
            // throw new NotImplementedException("Fix method body");
            return value1;
        }
    }
}
