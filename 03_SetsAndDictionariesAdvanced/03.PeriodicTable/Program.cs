using System;
using System.Collections.Generic;

namespace _03.PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedSet<string> periodicTable = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split();
                foreach (var element in line)
                {
                    periodicTable.Add(element);
                }
            }
            
            foreach (var element in periodicTable)
            {
                Console.Write(element + " ");
            }
        }
    }
}
