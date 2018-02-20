using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsAssessment.Tests.CSharp
{
    [TestClass]
    public class Challenge_MinStack
    {
        [TestMethod]
        public void Should_Create_MinStack()
        {
            // Design a stack that supports push, pop, top, and retrieving the minimum element
            // - Push(x)-- Push element x onto stack.
            // - Pop()-- Removes the element on top of the stack.
            // - Top()-- Get the top element.
            // - GetMin()-- Retrieve the minimum element in the stack.

            MinStack minStack = new MinStack();
            minStack.Push(-2);
            minStack.Push(0);
            minStack.Push(-3);

            Assert.Equals(-3, minStack.GetMin());
            minStack.Pop();
            Assert.Equals(0, minStack.Top());
            Assert.Equals(-2, minStack.GetMin());
        }


        /// <summary>
        /// A stack that supports push, pop, top, and getMin to retrieve the minimum element
        /// </summary>
        public class MinStack
        {

            /** initialize your data structure here. */
            public MinStack()
            {
            }

            /// <summary>
            /// Push element onto the stack
            /// </summary>
            /// <param name="x"></param>
            public void Push(int x)
            {
                throw new NotImplementedException("code implementation here");
            }

            /// <summary>
            /// Remove the element from top of the stack
            /// </summary>
            public void Pop()
            {
                throw new NotImplementedException("code implementation here");
            }

            /// <summary>
            /// Get the top element
            /// </summary>
            /// <returns></returns>
            public int Top()
            {
                throw new NotImplementedException("code implementation here");
            }

            /// <summary>
            /// Retrieve the minimum element in the stack
            /// </summary>
            /// <returns></returns>
            public int GetMin()
            {
                throw new NotImplementedException("code implementation here");
            }
        }
    }
}
