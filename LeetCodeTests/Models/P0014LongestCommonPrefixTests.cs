using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Models.Tests
{
    [TestClass()]
    public class P0014LongestCommonPrefixTests
    {
        [TestMethod()]
        public void LongestCommonPrefixTest_Expect_String()
        {
            // Arrange
            var data1 = new[] { "flower", "flow", "flight" };
            var test = new P0014LongestCommonPrefix();

            // Act
            var result1 = test.LongestCommonPrefix(data1);

            // Assert
            Assert.AreEqual("fl", result1);
        }

        [TestMethod()]
        public void LongestCommonPrefixTest_Expect_Empty()
        {
            // Arrange
            var data2 = new[] { "dog", "racecar", "car" };
            var test = new P0014LongestCommonPrefix();

            // Act
            var result2 = test.LongestCommonPrefix(data2);

            // Assert
            Assert.AreEqual("", result2);
        }

    }
}