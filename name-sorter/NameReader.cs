using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name_sorter
{
    public class NameReader
    {
        public IEnumerable<Name> ReadName(string FilePath)
        {
            var lines = File.ReadAllLines(FilePath);

            return lines.Select(ChangeToName);
        }

        public Name ChangeToName(string line)
        {
            var l = line.Split(' ').ToList();
            l = new ListProcessor().purgeList(l);   //remove empty items 
            return new ListProcessor().listToSortableName(l);
        }
    }
}
