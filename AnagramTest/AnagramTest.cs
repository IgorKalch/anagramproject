using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AnagramLibrary;

namespace AnagramTest
{
    [TestClass]
    public class AnagramTest
    {
        Anagram anagram = new Anagram();

        [TestMethod]
        [DataRow("abc", "cba")]
        public void ReverseStringTest_Reverse_AllSymbolsWillPermut(string initial, string expected)
        {
            var result = anagram.ReverseString(initial);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        [DataRow("1234", "1234")]
        public void ReverseStringTest_Reverse_AllSymbolsStayOnTheSamePosition(string initial, string expected)
        {
            var result = anagram.ReverseString(initial);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        [DataRow("abc!+!abc", "cba!+!cba")]
        public void ReverseStringTest_Reverse_WordWithMixedSymbols(string initial, string expected)
        {
            var result = anagram.ReverseString(initial);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        [DataRow("\t\tabc\t\tabc\t\t", "\t\tcba\t\tcba\t\t")]
        [DataRow(" abc\nabc\t\t", " cba\ncba\t\t")]
        [DataRow(" abc\nabc\t\t", " cba\ncba\t\t")]
        public void ReverseStringTest_Reverse_WhitespacesKeepTheSameCountAndPosition(string initial, string expected)
        {
            var result = anagram.ReverseString(initial);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        [DataRow("", "")]
        [DataRow(null, "")]
        public void ReverseStringTest_Reverse_NullOrEmptyTextAreAccepted(string initial, string expected)
        {
            var result = anagram.ReverseString(initial);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        [DataRow("abcd efgh", "dcba hgfe")]
        [DataRow("Test", "tseT")]
        [DataRow("a1bcd efg!h", "d1cba hgf!e")]
        [DataRow(" a1bcd efg!h", " d1cba hgf!e")]
        public void ReverseStringTest_QuickTest(string initial, string expected)
        {
            var result = anagram.ReverseString(initial);
            Assert.AreEqual(result, expected);
        }
    }
}
