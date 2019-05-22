using System;
using System.Collections.Generic;

namespace _06.Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> names = new Queue<string>();
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "End")
            {
                if (command == "Paid")
                {
                    int count = names.Count;
                    for (int i = 1; i <= count; i++)
                    {
                        Console.WriteLine(names.Dequeue());
                    }
                }
                else 
                {
                    names.Enqueue(command);
                }
            }
            Console.WriteLine($"{names.Count} people remaining.");
        }
    }
}
