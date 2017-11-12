using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using name_sorter;

namespace NameSorterUnitTest
{

    [TestClass]
    public class WriteToFileUnitTest
    {
        private readonly NameWritterToFile writer = new NameWritterToFile("sorted-names-list.txt");
        [TestMethod]
        public void TestWriteNamesFile()
        {
        
            IEnumerable<Name> names = new List<Name>
            {
                new Name {FirstName = "MARIN", LastName = "ALVAREZ", OtherName = null, FourthName =null  },
                new Name {FirstName = "ADONIS", LastName = "JULIUS", OtherName = "ARCHER" , FourthName =null },
                new Name {FirstName = "BEAU", LastName = "TRISTAN", OtherName ="BENTLEY" , FourthName = null },
                new Name {FirstName = "HUNTER", LastName = "URIAH", OtherName = "MATHEW", FourthName = "CLARKE" },
                new Name {FirstName = "LEO", LastName = "GARDENER", OtherName =null , FourthName = null },
                new Name {FirstName = "VAUGHN", LastName = "LEWIS", OtherName = null, FourthName = null },
                new Name {FirstName = "LONDON", LastName = "LINDSEY", OtherName = null, FourthName =null  },
                new Name {FirstName ="MIKAYLA" , LastName =  "LOPEZ", OtherName =null , FourthName =null },
                new Name {FirstName ="JANET", LastName = "PARSONS", OtherName = null, FourthName = null },
                new Name {FirstName = "FRANKIE", LastName = "CONNER", OtherName ="RITTER" , FourthName =null  },
                new Name {FirstName = "SHELBY", LastName = "NATHAN", OtherName ="YODER" , FourthName =null  },
            };

            var nl = Environment.NewLine;
            var expectedFileOutput = new string[] { "MARIN ALVAREZ","ADONIS JULIUS ARCHER","BEAU TRISTAN BENTLEY","" +
                "HUNTER URIAH MATHEW CLARKE","LEO GARDENER","VAUGHN LEWIS","LONDON LINDSEY","MIKAYLA LOPEZ","JANET PARSONS","FRANKIE CONNER RITTER","SHELBY NATHAN YODER"};

            writer.WriteNames(names);

            Assert.IsTrue(File.Exists(writer.OutputFileName));
            var lines = File.ReadAllLines(writer.OutputFileName);
           

            Assert.IsTrue(expectedFileOutput.SequenceEqual(lines));
        }
    }
}
