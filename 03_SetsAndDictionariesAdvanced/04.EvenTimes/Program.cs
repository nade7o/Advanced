using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (!dictionary.ContainsKey(currentNumber))
                {
                    dictionary.Add(currentNumber, 0);
                }
                dictionary[currentNumber]++;
            }
            int evenTimesNumber = dictionary
                .Where(number => number.Value % 2 == 0).SingleOrDefault().Key;

            Console.WriteLine(evenTimesNumber);
        }
    }
}
