using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Models.Tests
{
    [TestClass()]
    public class P0045JumpGameIITests
    {
        [TestMethod()]
        public void Give_23114_Get_2()
        {
            var nums = new[] { 2, 3, 1, 1, 4 };
            var expect = 2;
            var test = new P0045JumpGameII();
            var actual = test.Jump(nums);
            Assert.AreEqual(expect, actual);
        }

        [TestMethod()]
        public void Give_0_Get_0()
        {
            var nums = new[] { 0 };
            var expect = 0;
            var test = new P0045JumpGameII();
            var actual = test.Jump(nums);
            Assert.AreEqual(expect, actual);
        }

        [TestMethod()]
        public void Give_1111_Get_3()
        {
            var nums = new[] { 1, 1, 1, 1 };
            var expect = 3;
            var test = new P0045JumpGameII();
            var actual = test.Jump(nums);
            Assert.AreEqual(expect, actual);
        }

        [TestMethod()]
        public void Give_1098765432110_Get_3()
        {
            var nums = new[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 1, 0 };
            var expect = 2;
            var test = new P0045JumpGameII();
            var actual = test.Jump(nums);
            Assert.AreEqual(expect, actual);
        }
    }
}