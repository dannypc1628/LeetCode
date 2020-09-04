using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Models.Tests
{
    [TestClass()]
    public class P0268MissingNumberTests
    {
        [TestMethod()]
        public void Give_301_Get_2()
        {
            var nums = new[] { 3, 0, 1 };
            var expect = 2;
            var test = new P0268MissingNumber();
            var actual = test.MissingNumber(nums);
            Assert.AreEqual(expect, actual);
        }

        [TestMethod()]
        public void Give_1_Get_0()
        {
            var nums = new[] { 1 };
            var expect = 0;
            var test = new P0268MissingNumber();
            var actual = test.MissingNumber(nums);
            Assert.AreEqual(expect, actual);
        }

        [TestMethod()]
        public void Give_964235701_Get_8()
        {
            var nums = new[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 };
            var expect = 8;
            var test = new P0268MissingNumber();
            var actual = test.MissingNumber(nums);
            Assert.AreEqual(expect, actual);
        }

        [TestMethod()]
        public void Give_0_Get_1()
        {
            var nums = new[] { 0 };
            var expect = 1;
            var test = new P0268MissingNumber();
            var actual = test.MissingNumber(nums);
            Assert.AreEqual(expect, actual);
        }
    }
}