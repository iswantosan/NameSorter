
using NameSorter.Sorter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter.Parser
{
    /// <summary>
    /// Parse the input name into Given Name and Last Name
    /// </summary>
    public  class NameParser : INameParser
    {
        public Name Parse(string input)
        {
            if (string.IsNullOrEmpty(input)) return null;

            input = input.Trim();
            string[] words = input.Split(' ');

            string given = string.Empty;

            if (words.Count() == 1)
            {
                given = words[0];
            }
            else
            {
                for (int i = 0; i < words.Count() - 1; i++)
                {
                    given = given + words[i] + " ";
                }
            }
            given = given.Trim();

            Name n = new Name()
            {
                LastName = words[words.Count() - 1],
                GivenName = given
            };

            return n;

        }
    }
}
