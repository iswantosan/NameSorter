using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NameSorter.Parser;

namespace NameSorter.Test
{
    [TestClass]
    public class NameParserTest
    {
        [TestMethod]
        public void TestLastNameParser()
        {
            INameParser parser = new NameParser();
            Assert.AreEqual("Iddins", parser.Parse("Orson Milka Iddins").LastName);
        }

      
        [TestMethod]
        public void TestGivenNameParserOneWords()
        {
            INameParser parser = new NameParser();
            Assert.AreEqual("Iswanto", parser.Parse("Iswanto").GivenName);
        }

        [TestMethod]
        public void TestGivenNameParserTwoWords()
        {
            INameParser parser = new NameParser();
            Assert.AreEqual("Selle", parser.Parse("Selle Bellison").GivenName);
        }

        [TestMethod]
        public void TestGivenNameParserThreeWords()
        {
            INameParser parser = new NameParser();
            Assert.AreEqual("Orson Milka", parser.Parse("Orson Milka Iddins").GivenName);
        }

        [TestMethod]
        public void TestGivenNameParserFourthWords()
        {
            INameParser parser = new NameParser();
            Assert.AreEqual("Leonerd Adda Mitchell", parser.Parse("Leonerd Adda Mitchell Monaghan").GivenName);
        }

    }
}
