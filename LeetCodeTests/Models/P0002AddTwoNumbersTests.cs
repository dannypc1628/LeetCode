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
            var l1 = GetListNode(new int[] { 2, 4, 3 });

            var l2 = GetListNode(new int[] { 5, 6, 4 });

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
            CollectionAssert.AreEqual(expect, actual);

        }

        public ListNode GetListNode(int[] arr)
        {
            var node = new ListNode();
            var point = node;
            var i = 0;
            foreach (var item in arr)
            {
                point.val = item;
                if (i < arr.Length-1)
                {
                    point.next = new ListNode();
                    point = point.next;
                }
                i++;
            }

            return node;
        }
    }
}