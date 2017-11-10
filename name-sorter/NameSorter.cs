using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name_sorter
{
    class NameSorter
    {
        public IEnumerable<Name> SortNamesbyLast(IEnumerable<Name> name)
        {
            IEnumerable<Name> names = name.OrderBy(n => n.LastName)
                .ThenBy(n => n.OtherName)
                 .ThenBy(n => n.SecondName)
                  .ThenBy(n => n.FirstName);
            return names;

        }
    }
}
