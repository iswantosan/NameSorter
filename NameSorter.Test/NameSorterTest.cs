using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NameSorter.Parser;
using NameSorter.Sorter;

namespace NameSorter.Test
{
    [TestClass]
    public class NameSorterTest
    {
        [TestMethod]
        public void TestNumberOfOutput()
        {
            INameParser parser = new NameParser();
            ISorter<Name> sorter = new NameSorter.Sorter.NameSorter();
            List<Name> input = new List<Name>();
            input.Add(parser.Parse("Orson Milka Iddins"));
            input.Add(parser.Parse("Erna Dorey Battelle"));
            input.Add(parser.Parse("Flori Chaunce Franzel"));

            Assert.AreEqual(input.Count, sorter.Sort(input).Count);
        }

        [TestMethod]
        public void TestFirstRow()
        {
            INameParser parser = new NameParser();
            ISorter<Name> sorter = new NameSorter.Sorter.NameSorter();
            List<Name> input = new List<Name>();
            input.Add(parser.Parse("Orson Milka Iddins"));
            input.Add(parser.Parse("Erna Dorey Battelle"));
            input.Add(parser.Parse("Flori Chaunce Franzel"));

            Assert.AreEqual("Erna Dorey Battelle", sorter.Sort(input)[0]);
        }
    }
}
