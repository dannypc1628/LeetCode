using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Models.Tests
{
    [TestClass()]
    public class P0206ReverseLinkedListTests
    {
        [TestMethod()]
        public void Give_12345_Get_54321()
        {
            var support = new P0002AddTwoNumbersTests();
            var test = new P0206ReverseLinkedList();

            var input = support.GetListNode(new[] { 1, 2, 3, 4, 5 });
            var expect = new[] { 5, 4, 3, 2, 1 };
            var output = test.ReverseList(input);
            var actual = ConvertListNodeToArray(output);
            CollectionAssert.AreEqual(expect,actual);
        }
        [TestMethod()]
        public void Give_null_Get_null()
        {
            var support = new P0002AddTwoNumbersTests();
            var test = new P0206ReverseLinkedList();

            var actual = test.ReverseList(null);
            Assert.AreEqual(null, actual);
        }

        private int[] ConvertListNodeToArray(ListNode node)
        {
            var arr = new List<int>();
            var point = node;
            while (point != null)
            {
                arr.Add(point.val);
                point = point.next;
            }

            return arr.ToArray();
        }
    }
}