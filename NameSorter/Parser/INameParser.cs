using NameSorter.Sorter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter.Parser
{
    /// <summary>
    /// Provides a mechanism for parsing the "name" input
    /// </summary>
    public interface INameParser
    {
        /// <summary>
        /// Parse the input and return the Name Object
        /// </summary>
        /// <param name="input">Input to be parsed</param>
        /// <returns></returns>
        Name Parse(String input);
    }
}
