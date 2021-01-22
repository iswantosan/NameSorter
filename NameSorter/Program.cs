using NameSorter.Parser;
using NameSorter.Sorter;
using System;
using System.Collections.Generic;
using System.IO;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("usage name-sorter ./unsorted-names-list.txt");
                return;
            }

            if (!File.Exists(args[0]))
            {
                Console.WriteLine($"file {args[0]} doesn't exists");
                return;
            }

            string[] lines = File.ReadAllLines(args[0]);

            INameParser parser = new NameParser();
            List<Name> input = new List<Name>();
            foreach (string line in lines)
            {
                Name n = parser.Parse(line);
                if (n != null) input.Add(n);
            }

            ISorter<Name> sorter = new NameSorter.Sorter.NameSorter();
            var outputs = sorter.Sort(input);

            foreach (var output in outputs)
                Console.WriteLine(output);

            using (TextWriter tw = new StreamWriter("sorted-names-list.txt"))
            {
                foreach (var output in outputs)
                    tw.WriteLine(output);
            }
        }
    }
}
