using System;
using System.Collections.Generic;

namespace _05_CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] text = Console.ReadLine().ToCharArray();
            SortedDictionary<char, int> dict = new SortedDictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];
                if (!dict.ContainsKey(currentChar))
                {
                    dict.Add(currentChar, 0);
                }
                dict[currentChar]++;
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
