using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Models.Tests
{
    [TestClass()]
    public class P0784LetterCasePermutationTests
    {
        [TestMethod()]
        public void Give_1a2b()
        {
            var test = new P0784LetterCasePermutation();
            var s = "1a2b";
            var actual = test.LetterCasePermutation(s);

            var expect = new List<string>()
            {
                "1A2B",
                "1a2B",
                "1A2b",
                "1a2b",
            };
            CollectionAssert.AreEqual(expect.ToArray(),actual.ToArray());
        }
    }
}