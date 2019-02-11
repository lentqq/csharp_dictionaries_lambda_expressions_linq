using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.AMinerTask
{
    class AMinerTask
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> miner = new Dictionary<string, int>();
            string input = Console.ReadLine();
            int quantity = 0;
            string metal = string.Empty;
            while (input != "stop")
            {
                metal = input;
                quantity = int.Parse(Console.ReadLine());
                if (miner.ContainsKey(metal))
                {
                    miner[metal] += quantity;
                }
                else
                {
                    miner.Add(metal, quantity);
                }
                input = Console.ReadLine();
            }
            foreach (var pair in miner)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
