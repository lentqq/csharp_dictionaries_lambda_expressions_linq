using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Largest3Numbers
{
    class Largest3Numbers
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();

            var sortedNumbers = numbers.OrderByDescending(num => num).Take(3);
            Console.WriteLine(string.Join(" ",sortedNumbers));
        }
    }
}
