using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.MaxMinElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string line = string.Empty;

            Stack<int> stack = new Stack<int>();
            for (int i = 1; i <= num; i++)
            {
                line = Console.ReadLine();
                if (line.Contains("1"))
                {
                    int[] firstLine = line.Split().Select(int.Parse).ToArray();
                    int numberToAdd = firstLine[1];
                    stack.Push(numberToAdd);
                }
                else if (line == "2")
                {
                    if (stack.Any())
                    {
                        stack.Pop();
                    }
                }
                else if (line == "3" && stack.Any())
                {
                    Console.WriteLine(stack.Max());
                }
                else if (line == "4" && stack.Any())
                {
                    Console.WriteLine(stack.Min());
                }
            }
            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
