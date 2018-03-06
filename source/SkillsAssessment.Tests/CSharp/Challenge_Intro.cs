using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SkillsAssessment.Tests.CSharp
{
    [TestClass]
    public class Challenge_Intro
    {

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
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int Add(int x, int y)
        {
            // Task 1) additional test notes/constraints will exists here


            // Coding Task type - create missing method body
            // throw new NotImplementedException("Fix method body");

            // Coding Task type - fixing incorrect method body
            return x;
        }
    }
}
