using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name_sorter
{
    public class ListProcessor
    {
        //the method remove empty strings from list 
        public List<string> purgeList(List<string> list)
        {
            list = (from l in list where !string.IsNullOrEmpty(l) select l).ToList();
            return list;
        }

        //the method rerrages the a spefic name entity to a sortable entity
        public Name listToSortableName(List<string> list)
        {
            var name = new Name();
            try
            {
                name.FourthName = list[list.Count - 1];
                name.OtherName = list[list.Count - 2];
                name.LastName = list[list.Count - 3];
                name.FirstName = list[list.Count - 4];
            }
            catch
            {

            }

            return name;
        }

        //reverse the sorted Names to Normal Name 
        public IEnumerable<Name> reverseNamestoNormal(IEnumerable<Name> Names)
        {
            return Names.Select(reverseName);
        }

        private Name reverseName(Name name)
        {
            var nList = nameToList(name);
            return listToName(nList);
        }
        private Name listToName(List<string> list)
        {
            Name name = new Name();
            try
            {
                name.FirstName = list[list.Count - 1];
                name.LastName = list[list.Count - 2];
                name.OtherName = list[list.Count - 3];
                name.FourthName = list[list.Count - 4];
            }
            catch
            {

            }
            return name;
        }
        //convert name to list 
        private List<string> nameToList(Name name)
        {
            var result = new List<string>();

            result.Add(name.FourthName.Trim());
            if (!string.IsNullOrEmpty(name.OtherName))
                result.Add(name.OtherName.Trim());
            if (!string.IsNullOrEmpty(name.LastName))
                result.Add(name.LastName.Trim());
            if (!string.IsNullOrEmpty(name.FirstName))
                result.Add(name.FirstName.Trim());

            return result;
        }
    }
}
