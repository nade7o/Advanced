using System;
using System.Linq;
using System.Collections.Generic;
namespace _04.FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            int[] line = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> orders = new Queue<int>(line);

            Console.WriteLine(orders.Max());

            while(orders.Any())
            {
                int order = orders.Peek();
                if (foodQuantity >= order)
                {
                    orders.Dequeue();
                    foodQuantity -= order;
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
                    return;
                }
            }
            Console.WriteLine("Orders complete");
        }
    }
}
