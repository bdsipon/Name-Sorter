using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace name_sorter
{
    public class NameEqualityComparer : IEqualityComparer<Name>
    {
        public bool Equals(Name x, Name y)
        {
            return x.FirstName == y.FirstName
                && x.LastName == y.LastName
                && x.OtherName == y.OtherName
                && x.FourthName == y.FourthName;
        }

        public int GetHashCode(Name obj)
        {
            return obj.ToString().GetHashCode();
        }
    }
}
