using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name_sorter
{
    class NameWritterToFile
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
    }
}
