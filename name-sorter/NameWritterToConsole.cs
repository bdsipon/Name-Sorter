using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name_sorter
{
    public class NameWritterToConsole : INameWritter
    {
        public void WriteNames(IEnumerable<Name> names)
        {
            names.ToList().ForEach(Console.WriteLine);
        }
    }
}
