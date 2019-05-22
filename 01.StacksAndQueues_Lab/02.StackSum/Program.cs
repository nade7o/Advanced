using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command = String.Empty;
            Stack<int> integers = new Stack<int>(input); //I can directly put int[] as parameter in stack.

            while ((command = Console.ReadLine().ToLower()) != "end")
            {
                string[] tokens = command.Split();

                if (tokens[0] == "add")
                {
                    int firstNum = int.Parse(tokens[1]);
                    int secondNum = int.Parse(tokens[2]);
                    integers.Push(firstNum);
                    integers.Push(secondNum);
                }
                else if (tokens[0] == "remove")
                {
                    int num = int.Parse(tokens[1]);
                    if (integers.Count > num)
                    {
                        while (num > 0)
                        {
                            integers.Pop();
                            num--;
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            if (command == "end")
            {
                int result = integers.Sum();
                Console.WriteLine($"Sum: {result}");
            }
        }
    }
}
