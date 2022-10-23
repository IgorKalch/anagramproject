using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AnagramProject;

namespace AnagramTest
{
    [TestClass]
    public class AnagramTests
    {
        [TestMethod]
        public void ReverseSingleWordTest()
        {
            //Arrange 
            Anagram anagram = new Anagram();

            var data = "Abc";
            var reverceData = "cbA";

            //Act
            var result = anagram.ReverseSingleWord(data);

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(reverceData, result);
            
        }

        [TestMethod]
        public void ReverseStringTest()
        {
            //Arrange 
            Anagram anagram = new Anagram();
            var data = "A#bc  dfff!$ f#df";
            var reverceData = "c#bA  fffd!$ f#df";

            //Act
            var result = anagram.ReverseString(data);

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(reverceData,result);
        }
    }
}
