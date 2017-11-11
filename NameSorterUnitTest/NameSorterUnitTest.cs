using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using name_sorter;
using System.Linq;

namespace NameSorterUnitTest
{

    [TestClass]
    public class NameSorterUnitTest
    {
        private readonly  NameSorter sorter = new NameSorter();
        [TestMethod]
        public void TestSortName()
        {

            IEnumerable<Name> unSortedNames = new List<Name>
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
            IEnumerable<Name> expectedSortedNames = new List<Name>
                {
                new Name {FirstName = null, LastName = null, OtherName = "MARIN", FourthName = "ALVAREZ" },
                new Name {FirstName = null, LastName = "ADONIS", OtherName = "JULIUS", FourthName = "ARCHER" },
                new Name {FirstName = null, LastName = "BEAU", OtherName = "TRISTAN", FourthName = "BENTLEY" },
                new Name {FirstName = "HUNTER", LastName = "URIAH", OtherName = "MATHEW", FourthName = "CLARKE" },
                new Name {FirstName = null, LastName = null, OtherName = "LEO", FourthName = "GARDENER" },
                new Name {FirstName = null, LastName = null, OtherName = "VAUGHN", FourthName = "LEWIS" },
                new Name {FirstName = null, LastName = null, OtherName = "LONDON", FourthName = "LINDSEY" },
                new Name {FirstName = null, LastName = null, OtherName = "MIKAYLA", FourthName = "LOPEZ" },
                new Name {FirstName = null, LastName = null, OtherName = "JANET", FourthName = "PARSONS" },
                new Name {FirstName = null, LastName = "FRANKIE", OtherName = "CONNER", FourthName = "RITTER" },
                new Name {FirstName = null, LastName = "SHELBY", OtherName = "NATHAN", FourthName = "YODER" },


            };

           
            var result = sorter.SortNameByFourthThenOthers(unSortedNames);

            Assert.IsTrue(expectedSortedNames.SequenceEqual(result, new NameEqualityComparer()));
        }
    }
}
