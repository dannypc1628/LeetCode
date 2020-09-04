using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Models.Tests
{
    [TestClass()]
    public class P0217ContainsDuplicateTests
    {
        [TestMethod()]
        public void Give_1231_Get_True()
        {
            var nums = new[] { 1, 2, 3, 1 };
            var expect = true;
            var test = new P0217ContainsDuplicate();
            var actual = test.ContainsDuplicate(nums);
            Assert.AreEqual(expect, actual);
        }
        [TestMethod()]
        public void Give_1234_Get_False()
        {
            var nums = new[] { 1, 2, 3, 4 };
            var expect = false;
            var test = new P0217ContainsDuplicate();
            var actual = test.ContainsDuplicate(nums);
            Assert.AreEqual(expect, actual);
        }
    }
}