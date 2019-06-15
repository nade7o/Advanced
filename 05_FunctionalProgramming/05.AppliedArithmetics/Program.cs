using System;
using System.Linq;

namespace _05.AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string command = Console.ReadLine();

            Func<int, int> increment = x => x += 1;
            Func<int, int> multiply = x => x *= 2;
            Func<int, int> subtract = x => x -= 1;
            Action<int[]> print = numbers => Console.WriteLine(string.Join(" ", numbers));

            while (command != "end")
            {
                if (command == "add")
                {
                    inputNumbers = inputNumbers.Select(increment).ToArray();
                }
                else if (command == "multiply")
                {
                    inputNumbers = inputNumbers.Select(multiply).ToArray();
                }
                else if (command == "subtract")
                {
                    inputNumbers = inputNumbers.Select(subtract).ToArray();
                }
                else if (command == "print")
                {
                    print(inputNumbers);
                }

                command = Console.ReadLine();
            }
        }
    }
}
