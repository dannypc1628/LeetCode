using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Models.Tests
{
    [TestClass()]
    public class P0003LongestSubstringWithoutRepeatingCharactersTests
    {
        [TestMethod()]
        public void LengthOfLongestSubstringTest_Give_abcabcbb_Get_3()
        {
            var input = "abcabcbb";
            var expect = 3;
            var test = new P0003LongestSubstringWithoutRepeatingCharacters();
            var actual = test.LengthOfLongestSubstring(input);

            Assert.AreEqual(expect, actual);
        }
        [TestMethod()]
        public void LengthOfLongestSubstringTest_Give_bwf_Get_3()
        {
            var input = "bwf";
            var expect = 3;
            var test = new P0003LongestSubstringWithoutRepeatingCharacters();
            var actual = test.LengthOfLongestSubstring(input);

            Assert.AreEqual(expect, actual);
        }
        [TestMethod()]
        public void LengthOfLongestSubstringTest_Give_anviaj_Get_5()
        {
            var input = "anviaj";
            var expect = 5;
            var test = new P0003LongestSubstringWithoutRepeatingCharacters();
            var actual = test.LengthOfLongestSubstring(input);

            Assert.AreEqual(expect, actual);
        }
        [TestMethod()]
        public void LengthOfLongestSubstringTest_Give_bbbbb_Get_1()
        {
            var input = "bbbbb";
            var expect = 1;
            var test = new P0003LongestSubstringWithoutRepeatingCharacters();
            var actual = test.LengthOfLongestSubstring(input);

            Assert.AreEqual(expect, actual);
        }
        [TestMethod()]
        public void LengthOfLongestSubstringTest_Give_Empty_Get_0()
        {
            var input = "";
            var expect = 0;
            var test = new P0003LongestSubstringWithoutRepeatingCharacters();
            var actual = test.LengthOfLongestSubstring(input);

            Assert.AreEqual(expect, actual);
        }
        [TestMethod()]
        public void LengthOfLongestSubstringTest_Give_pwwkew_Get_3()
        {
            var input = "pwwkew";
            var expect = 3;
            var test = new P0003LongestSubstringWithoutRepeatingCharacters();
            var actual = test.LengthOfLongestSubstring(input);

            Assert.AreEqual(expect, actual);
        }
        [TestMethod()]
        public void LengthOfLongestSubstringTest_Give_WhiteSpace_Get_1()
        {
            var input = " ";
            var expect = 1;
            var test = new P0003LongestSubstringWithoutRepeatingCharacters();
            var actual = test.LengthOfLongestSubstring(input);

            Assert.AreEqual(expect, actual);
        }
    }
}