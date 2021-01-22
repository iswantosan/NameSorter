using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter.Sorter
{
    /// <summary>
    /// Provides a mechanism for sort the data
    /// </summary>
    public interface ISorter<T>
    {
        List<T> Sort(List<T> input);
    }
}
