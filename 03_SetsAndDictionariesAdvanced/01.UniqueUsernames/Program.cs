using System;
using System.Collections.Generic;

namespace _01.UniqueUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string line = string.Empty;
            HashSet<string> collection = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                line = Console.ReadLine();
                collection.Add(line);
            }
            foreach (var name in collection)
            {
                Console.WriteLine(name);
            }
        }
    }
}
