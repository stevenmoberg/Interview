using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SkillsAssessment.Tests.CSharp
{
    [TestClass]
    public class Challenge_RemoveDuplicateFromLinkedList
    {
        [Medium]
        [TestMethod]
        public void Should_Remove_Duplicates_From_SortedList()
        {
            // Task 1) Write DeleteDuplicates method
            // Task 2) Write ListNode.ToArray implementation

            // Arrange
            var test1 = CreateListNode(1, 1, 2);
            var test2 = CreateListNode(1, 2, 3, 3);

            // Act
            var results1 = DeleteDuplicates(test1);
            var results2 = DeleteDuplicates(test2);

            // Assert
            CollectionAssert.AreEqual(new int[] { 1, 2 }, results1.ToArray());
            CollectionAssert.AreEqual(new int[] { 1, 2, 3 }, results2.ToArray());
        }

        /// <summary>
        /// Given a sorted linked list, delete all duplicates such that each element appear only once. 
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public ListNode DeleteDuplicates(ListNode head)
        {
            throw new NotImplementedException("Create Method body here");
        }

        public class ListNode
        {
            public int Value;
            public ListNode Next;
            public ListNode(int x) { Value = x; }

            public int[] ToArray()
            {
                // write ToArray implementation
                return new int[0];
            }
        }

        #region Helper 

        private static ListNode CreateListNode(params int[] values)
        {
            ListNode node = null;
            ListNode last = null;

            foreach (var value in values)
            {
                var next = new ListNode(value);
                if (node == null)
                    node = next;
                if (last != null)
                    last.Next = next;

                last = node;
            }

            return node;
        }

        #endregion
    }
}
