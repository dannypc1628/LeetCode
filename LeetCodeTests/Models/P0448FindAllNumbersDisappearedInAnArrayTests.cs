using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Models.Tests
{
    [TestClass()]
    public class P0448FindAllNumbersDisappearedInAnArrayTests
    {
        [TestMethod()]
        public void Give_43278231_Get_56()
        {
            var nums = new[] {4, 3, 2, 7, 8, 2, 3, 1};
            var expect = new [] {5, 6};
            var test = new P0448FindAllNumbersDisappearedInAnArray();
            var actual = test.FindDisappearedNumbers(nums);
            CollectionAssert.AreEqual(expect,actual.ToArray());
        }

        [TestMethod()]
        public void Give_11_Get_2()
        {
            var nums = new[] { 1, 1 };
            var expect = new[] { 2 };
            var test = new P0448FindAllNumbersDisappearedInAnArray();
            var actual = test.FindDisappearedNumbers(nums);
            CollectionAssert.AreEqual(expect, actual.ToArray());
        }
    }
}