﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bounds = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int lowerBound = bounds[0];
            int upperBound = bounds[1];
            string type = Console.ReadLine();

            List<int> numbers = new List<int>();

            for (int i = lowerBound; i <= upperBound; i++)
            {
                numbers.Add(i);
            }

            Predicate<int> isEven = number => number % 2 == 0;
            Predicate<int> isOdd = number => number % 2 != 0;
            Action<List<int>> printNumbers = nums => Console.WriteLine(string.Join(" ", nums));

            if (type == "odd")
            {
              numbers = numbers.Where(x => isOdd(x)).ToList();
            }
            else
            {
                numbers = numbers.Where(x => isEven(x)).ToList();
            }
            printNumbers(numbers);
        }
    }
}
