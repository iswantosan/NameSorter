using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter.Sorter
{
    /// <summary>
    /// Model that hold last and given name
    /// </summary>
    public class Name
    {
        public String LastName { get; set; }

        public String GivenName { get; set; }

        public override string ToString()
        {
            return GivenName + " " + LastName;
        }
    }
}
