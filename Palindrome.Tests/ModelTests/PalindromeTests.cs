using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome.Models;

namespace Palindrome.Tests
{
    [TestClass]
    public class  PalindromeCheckTests
    {
        [TestMethod]
        public void IsPalindrome_ReturnsString_True()
        {
            PalindromeCheck testCase = new PalindromeCheck();
            Assert.AreEqual(false, testCase.IsPalindrome("abcde"));
        }

        [TestMethod]
        public void FlipString_ReverseString_string()
        {
            PalindromeCheck testReverse = new PalindromeCheck();
            Assert.AreEqual("edcba", testReverse.FlipString("abcde"));
        }

        [TestMethod]
        public void IsPalindrome_OriginalStringEqualFlippedString_True()
        {
            PalindromeCheck testcase = new PalindromeCheck();
            Assert.AreEqual(true, testcase.IsPalindrome("tacocat"));
        }

        [TestMethod]
        public void FlipStringHardMode_ReverseStringWithoutReverseMethod_string()
        {
            PalindromeCheck testcase = new PalindromeCheck();
            Assert.AreEqual("tacocat", testcase.FlipStringHardMode("tacocat"));
        }
    }
}