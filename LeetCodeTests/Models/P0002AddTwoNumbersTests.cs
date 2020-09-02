using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Models.Tests
{
    [TestClass()]
    public class P0002AddTwoNumbersTests
    {
        [TestMethod()]
        public void AddTwoNumbersTest()
        {
            var l1 = new ListNode(2)
            {
                next = new ListNode(4)
            };
            l1.next.next = new ListNode(3);

            var l2 = new ListNode(5)
            {
                next = new ListNode(6)
            };
            l2.next.next = new ListNode(4);

            var p2 = new P0002AddTwoNumbers();

            var res = p2.AddTwoNumbers(l1, l2);
            var expect = new List<int> { 7, 0, 8 };
            var actual = new List<int>();

            var now = res;
            while (true)
            {
                actual.Add(now.val);
                if (now.next != null)
                {
                    now = now.next;
                }
                else
                {
                    break;
                }
            }
            CollectionAssert.AreEqual(expect,actual);

        }
    }
}