using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsAssessment.Tests.CSharp
{
    [TestClass]
    public class Challenge_RemoveDuplicateFromLinkedList
    {
        [TestMethod]
        public void Should_Remove_Duplicates_From_SortedList()
        {
            ListNode test1, test2;

            // Arrange
            test1 = new ListNode(1);
            test1.next = new ListNode(1);
            test1.next.next = new ListNode(2);

            test2 = new ListNode(1);
            test2.next = new ListNode(1);
            test2.next.next = new ListNode(2);
            test2.next.next.next = new ListNode(3);
            test2.next.next.next.next = new ListNode(3);

            // Act
            var results1 = DeleteDuplicates(test1);
            var results2 = DeleteDuplicates(test2);

            // Assert
            // Given 1->1->2, return 1->2.
            // Given 1->1->2->3->3, return 1->2->3.
            Assert.Fail("Write Assertions Here");
        }

        public ListNode DeleteDuplicates(ListNode head)
        {
            // Given a sorted linked list, delete all duplicates such that each element appear only once. 
            

            return new ListNode(0);
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
    }
}
