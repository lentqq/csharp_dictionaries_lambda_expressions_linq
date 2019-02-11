using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.ShortWordsSorted
{
    class ShortWordsSorted
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine()
                .Split(new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Where(word => word.Length < 5)
                .Select(word => word.ToLower())
                .OrderBy(word => word)
                .Distinct()
                .ToList();
            Console.WriteLine(string.Join(", ", text));
        }
    }
}
