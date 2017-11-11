using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name_sorter
{
    public class NameSorter
    {

        public IEnumerable<Name> SortNameByFourthThenOthers(IEnumerable<Name> name)
        {
            IEnumerable<Name> names = name.OrderBy(n => n.FourthName)
                                           .ThenBy(n => n.OtherName)
                                           .ThenBy(n => n.LastName)
                                           .ThenBy(n => n.FirstName);
            return names;
        }
    }
}