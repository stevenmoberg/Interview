using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SkillsAssessment.Tests.CSharp
{
    [TestClass]
    public class Challenge_Calculator
    {
        [Medium]
        [TestMethod]
        public void Should_Evaluate_SimpleMathExpression()
        {
            Assert.AreEqual(2, Calculate("1 + 1"));
            Assert.AreEqual(3, Calculate("2-1 + 2"));
            Assert.AreEqual(23, Calculate("(1+(4+5+2)-3)+(6+8)"));
        }

        /// <summary>
        /// Basic calculator to evaluate a simple expression string.
        /// Expression string may contain open ( and closing parentheses ), the plus + or minus sign -, non-negative integers and empty spaces 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        int Calculate(string s)
        {
            // Task 1) You may assume that the given expression is always valid.
            // Task 2) Do not use the eval built-in library function.

            throw new NotImplementedException("code solution here");
        }
    }
}
