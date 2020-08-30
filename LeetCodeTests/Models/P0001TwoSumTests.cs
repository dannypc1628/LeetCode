using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Models.Tests
{
    [TestClass()]
    public class P0001TwoSumTests
    {
        [TestMethod()]
        public void TwoSumTest()
        {
            var nums = new[] { 2, 7, 11, 15 };
            var target = 9;
            var expect = new [] { 0, 1 };
            var test = new LeetCode.Models.P0001TwoSum();
            
            var actual = test.TwoSum(nums, target);
            CollectionAssert.AreEqual(expect,actual);
        }
    }
}