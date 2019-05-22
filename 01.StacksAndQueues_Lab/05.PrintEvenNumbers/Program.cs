using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> integers = new Queue<int>(input);
            Queue<int> evens = new Queue<int>();

            foreach (var num in integers)
            {
                if (num % 2 == 0)
                {
                    evens.Enqueue(num);
                }
            }
            Console.WriteLine(string.Join(", ", evens));
        }
    }
}
