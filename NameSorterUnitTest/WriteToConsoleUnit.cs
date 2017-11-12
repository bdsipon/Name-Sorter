using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using name_sorter;
using System.Collections.Generic;
using System.IO;

namespace NameSorterUnitTest
{
    [TestClass]
    public class WriteToConsoleUnit
    {
        private readonly NameWritterToConsole writer = new NameWritterToConsole();
        [TestMethod]
        public void TestWriteNamesConsole()
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

            var expectedText = $"MARIN ALVAREZ{nl}ADONIS JULIUS ARCHER{nl}BEAU TRISTAN BENTLEY{nl}HUNTER URIAH MATHEW CLARKE" +
                $"{nl}LEO GARDENER{nl}VAUGHN LEWIS{ nl}LONDON LINDSEY{nl}MIKAYLA LOPEZ{nl}JANET PARSONS{ nl}FRANKIE CONNER RITTER{ nl}SHELBY NATHAN YODER";
       

            using (var consoleText = new StringWriter())
            {
                Console.SetOut(consoleText);
                writer.WriteNames(names);
                Assert.IsTrue(!string.IsNullOrWhiteSpace(consoleText.ToString()));
                Assert.AreEqual(consoleText.ToString().Trim(), expectedText);
            }
        }
    }
}
