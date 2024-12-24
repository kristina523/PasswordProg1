using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PasswordProg.Tests
{
    [TestClass]
    public class StringExtensionsTests : IStringExtensionsTests
    {
        [TestMethod]
        public void CountCapitalLetters_EmptyString_ReturnsZero()
        {
            string testString = "";
            int result = testString.CountCapitalLetters();
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void CountCapitalLetters_NoCapitalLetters_ReturnsZero()
        {
            string testString = "lowercase string";
            int result = testString.CountCapitalLetters();
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void CountCapitalLetters_MixedCaseString_ReturnsCorrectCount()
        {
            string testString = "Hello World!";
            int result = testString.CountCapitalLetters();
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void CountCapitalLetters_AllCapitalLetters_ReturnsCorrectCount()
        {
            string testString = "ALLCAPITALLETTERS";
            int result = testString.CountCapitalLetters();
            Assert.AreEqual(16, result);
        }

        [TestMethod]
        public void CountCapitalLetters_StringWithNumbersAndSymbols_ReturnsCorrectCount()
        {
            string testString = "Tes123t S!tring";
            int result = testString.CountCapitalLetters();
            Assert.AreEqual(2, result);
        }
    }

    public static class StringExtensions
    {
        public static int CountCapitalLetters(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }
            return input.Count(char.IsUpper);
        }
    }
}

