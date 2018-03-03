using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SkillsAssessment.Tests.CSharp
{
    [TestClass]
    public class Challenge_EvaluateReversePolishNotation
    {
        [Medium]
        [TestMethod]
        public void Should_Calculate_ReversePolishNotation()
        {
            // Arrange
            var test1 = new[] { "2", "1", "+", "3", "*" }; // 9
            var test2 = new[] { "4", "13", "5", "/", "+" }; // 6

            // Act
            var actual1 = EvaluateReversePolishNotation(test1);
            var actual2 = EvaluateReversePolishNotation(test2);

            // Assert
            Assert.AreEqual(9, actual1);
            Assert.AreEqual(6, actual2);
        }

        /// <summary>
        /// Evaluate the value of an arithmetic expression in Reverse Polish Notation.
        // Valid operators are +, -, *, /. Each operand may be an integer or another expression.
        // Some examples:
        // ["2", "1", "+", "3", "*"] -> ((2 + 1) * 3) -> 9
        // ["4", "13", "5", "/", "+"] -> (4 + (13 / 5)) -> 6
        /// </summary>
        /// <returns></returns>
        private int EvaluateReversePolishNotation(string[] tokens)
        {
            throw new NotImplementedException("code method here");
        }
    }
}
