using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hangman.BusinessLogic;

namespace Hangman.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TheLetterAIsInsideTheWordMom()
        {
            //values to send
            char aLetter = 'o';
            string aWord = "Mom";
            bool expectedResult = true;
            //Summon the method
            Tools dynamicReference = new Tools();
            bool result = dynamicReference.LetterInAWord(aLetter, aWord);
            //Compare the obtained result with the expected one
            Assert.AreEqual(expectedResult, result);
        }
    }
}
