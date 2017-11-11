using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace name_sorter
{
    class NameWritterToFile : INameWritter
    {
        private string outputFileName = "";

        public NameWritterToFile(string outputFile)
        {
            this.outputFileName = outputFile;
        }
        public string OutputFileName
        {
            get { return outputFileName; }

            set
            {
                outputFileName = value;
            }
        }

        public void WriteNames(IEnumerable<Name> names)
        {
            var nameList = names.Select(name => name.ToString());
            File.WriteAllLines(OutputFileName, nameList);
        }
    }
}