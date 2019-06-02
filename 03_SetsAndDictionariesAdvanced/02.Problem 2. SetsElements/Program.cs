using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Problem_2._SetsElements
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < sizes[0]; i++)
            {
                int currentNumer = int.Parse(Console.ReadLine());
                firstSet.Add(currentNumer);
            }

            for (int i = 0; i < sizes[1]; i++)
            {
                int currentNumer = int.Parse(Console.ReadLine());
                secondSet.Add(currentNumer);
            }

            foreach (var item in firstSet)
            {
                if (secondSet.Contains(item))
                {
                    Console.Write(item + " ");
                }
            }
        }
    }
}
