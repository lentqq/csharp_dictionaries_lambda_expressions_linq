using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FixEmails
{
    class FixEmails
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> mailBoook = new Dictionary<string, string>();
            string name = string.Empty;
            string mail = string.Empty;
            string command = Console.ReadLine();
            while (command != "stop")
            {
                name = command;
                mail = Console.ReadLine();
                if (!mailBoook.ContainsKey(name))
                {
                    mailBoook.Add(name, mail);
                }
                command = Console.ReadLine();
            }
            foreach (var pair in mailBoook.Where(x => !x.Value.EndsWith(".us") && !x.Value.EndsWith(".uk")))
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
