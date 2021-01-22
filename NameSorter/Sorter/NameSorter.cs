using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter.Sorter
{
    /// <summary>
    /// Implementation for sort Name object
    /// </summary>
    public class NameSorter : ISorter<Name>
    {
        public List<Name> Sort(List<Name> input)
        {
            return input.OrderBy(s => s.LastName).ThenBy(s => s.GivenName).ToList();
        }
    }
}
