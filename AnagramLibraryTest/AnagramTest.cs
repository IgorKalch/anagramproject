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
        public void Reverse_AllSymbolsWillPermut(string initial, string expected)
        {
            var result = anagram.Reverse(initial);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        [DataRow("1234", "1234")]
        public void Reverse_AllSymbolsStayOnTheSamePosition(string initial, string expected)
        {
            var result = anagram.Reverse(initial);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        [DataRow("abc!+!abc", "cba!+!cba")]
        public void Reverse_WordWithMixedSymbols(string initial, string expected)
        {
            var result = anagram.Reverse(initial);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        [DataRow("\tabc\t\tabc\t\t\tabc\t\t\t\t", "\tcba\t\tcba\t\t\tcba\t\t\t\t")]
        [DataRow(" abc  abc   abc    abc     ", " cba  cba   cba    cba     ")]
        [DataRow(" abc\nabc\t\t\t\t\t", " cba\ncba\t\t\t\t\t")]
        public void Reverse_WhitespacesKeepTheSameCountAndPosition(string initial, string expected)
        {
            var result = anagram.Reverse(initial);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]        
        [DataRow("", "")]
        public void Reverse_EmptyTextAreAccepted(string initial, string expected)
        {
            var result = anagram.Reverse(initial);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void Reverse_NullTextAreAccepted()
        {
            // Arrange
            string initial = null;
            string expected = "";

            // Assert
            var result = anagram.Reverse(initial);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        [DataRow("abcd efgh", "dcba hgfe")]
        [DataRow("Test", "tseT")]
        [DataRow("a1bcd efg!h", "d1cba hgf!e")]
        [DataRow(" a1bcd efg!h", " d1cba hgf!e")]
        public void Reverse_QuickTest(string initial, string expected)
        {
            var result = anagram.Reverse(initial);
            Assert.AreEqual(result, expected);
        }
    }
}
