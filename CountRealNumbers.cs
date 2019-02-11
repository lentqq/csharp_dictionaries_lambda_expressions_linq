using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountRealNumbers
{
    class CountRealNumbers
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();
            SortedDictionary<double, int> counts = new SortedDictionary<double, int>();
            foreach (var number in numbers)
            {
                if (!counts.ContainsKey(number))
                {
                    counts[number] = 1;
                }
                else
                {
                    counts[number]++;
                }
            }
            foreach (var kvp in counts)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
