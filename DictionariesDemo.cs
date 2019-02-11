using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionariesDemo
{
    class DictionariesDemo
    {
        static void Main(string[] args)
        {
            int[] integers = Console.ReadLine().
                Split(" ").
                Select(int.Parse).
                ToArray();
            int k = integers.Length / 4;
            int[] leftUp = integers.Take(2).Reverse().ToArray();
            int[] rigthUp = integers.Reverse().Take(2).ToArray();
            int[] concatenateArray= leftUp.Concat(rigthUp).ToArray();
            int[] downRow = integers.Skip(2).Take(2 * k).ToArray();
            int[] sumAraay = concatenateArray.Select((x, index) => x + downRow[index]).ToArray();
            Console.WriteLine(string.Join(" ", sumAraay));
        }
    }
}
