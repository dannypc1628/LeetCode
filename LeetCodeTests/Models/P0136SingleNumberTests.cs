using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Models.Tests
{
    [TestClass()]
    public class P0136SingleNumberTests
    {
        [TestMethod()]
        public void Give_221_Get_1()
        {
            var nums = new[] { 2,2,1 };
            var expect = 1;
            var test = new P0136SingleNumber();
            var actual = test.SingleNumber(nums);
            Assert.AreEqual(expect, actual);
        }

        [TestMethod()]
        public void Give_41212_Get_1()
        {
            var nums = new[] { 4, 1, 2, 1, 2 };
            var expect = 4;
            var test = new P0136SingleNumber();
            var actual = test.SingleNumber(nums);
            Assert.AreEqual(expect, actual);
        }
    }
}