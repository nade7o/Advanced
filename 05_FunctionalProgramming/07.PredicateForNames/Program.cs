using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _07.PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] names = Console.ReadLine().Split();

            Func<string, bool> filter = x => x.Length <= n;

            IEnumerable<string> collection = names;
            
            Console.WriteLine(string.Join(Environment.NewLine, collection.Where(filter)));
        }
    }
}
