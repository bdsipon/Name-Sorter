using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using name_sorter;
using System.Collections.Generic;
using System.Linq;

namespace NameSorterUnitTest
{
    [TestClass]
    public class NameReaderUnitTest
    {
      private readonly  NameReader reader = new NameReader();
        
        [TestMethod]
        public void TestReadName()
        {
            var result = reader.ReadName("unsorted-names-list.txt");


            IEnumerable<Name> expected = new List<Name>
            {
                new Name {FirstName = null, LastName = null, OtherName = "JANET", FourthName = "PARSONS" },
                new Name {FirstName = null, LastName = null, OtherName = "VAUGHN", FourthName = "LEWIS" },
                new Name {FirstName = null, LastName = "ADONIS", OtherName = "JULIUS", FourthName = "ARCHER" },
                new Name {FirstName = null, LastName = "SHELBY", OtherName = "NATHAN", FourthName = "YODER" },
                new Name {FirstName = null, LastName = null, OtherName = "MARIN", FourthName = "ALVAREZ" },
                new Name {FirstName = null, LastName = null, OtherName = "LONDON", FourthName = "LINDSEY" },
                new Name {FirstName = null, LastName = "BEAU", OtherName = "TRISTAN", FourthName = "BENTLEY" },
                new Name {FirstName = null, LastName = null, OtherName = "LEO", FourthName = "GARDENER" },
                new Name {FirstName = "HUNTER", LastName = "URIAH", OtherName = "MATHEW", FourthName = "CLARKE" },
                new Name {FirstName = null, LastName = null, OtherName = "MIKAYLA", FourthName = "LOPEZ" },
                new Name {FirstName = null, LastName = "FRANKIE", OtherName = "CONNER", FourthName = "RITTER" },
            };
            Assert.IsTrue(expected.SequenceEqual(result, new NameEqualityComparer()));
        }

        [TestMethod]
        public void TestChangeToName()
        {
            NameReader reader = new NameReader();
            var result = reader.ChangeToName("SIPON HOSSAIN MAHMUD");
            var expectedName = new Name { FirstName = null, LastName = "SIPON", OtherName = "HOSSAIN", FourthName = "MAHMUD" };

            Assert.AreEqual(expectedName.ToString(), result.ToString());
        }
    }
}
