using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OddOccurrences
{
    class OddOcurrences
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(' ');
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            foreach (var word in words)
            {
              string wordToLower = word.ToLower();
                if (wordCount.ContainsKey(wordToLower))
                {
                    wordCount[wordToLower]++;
                }
                else
                {
                    wordCount[wordToLower] = 1;
                }
            }
            List<string> result = new List<string>();

            foreach (var kvp in wordCount)
            {             
                if (kvp.Value % 2 == 1)
                {
                    result.Add(kvp.Key);
                }
            }
            Console.WriteLine(string.Join(", ",result));
        }
    }
}
