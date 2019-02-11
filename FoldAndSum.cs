using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int k = integers.Length / 4;

            int[] upLeftRow = integers.Take(k).Reverse().ToArray();
            int[] upRightRow = integers.Reverse().Take(k).ToArray();
            int[] concatenateRow = upLeftRow.Concat(upRightRow).ToArray();
            int[] downRow = integers.Skip(k).Take(2 * k).ToArray();

            var sumArrays = concatenateRow.Select((x, index) => x + downRow[index]);
            Console.WriteLine(string.Join(" ", sumArrays));
        }
    }
}
