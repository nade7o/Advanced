using System;
using System.Linq;
using System.Collections.Generic;
namespace _05.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] line = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rackCapacity = int.Parse(Console.ReadLine());

            Stack<int> boxWithClothes = new Stack<int>(line);
            int sum = 0;
            int racksCount = 1;
            while (boxWithClothes.Any())
            {
                int pieceOfClothing = boxWithClothes.Peek();

                if (sum < rackCapacity)
                {
                    sum += pieceOfClothing;
                    boxWithClothes.Pop();
                }

                if (sum == rackCapacity)
                {
                    if (boxWithClothes.Any())
                    {
                        racksCount++;
                        sum = 0;
                    }
                }
                else if (sum > rackCapacity)
                {
                    racksCount++;
                    sum = 0;
                    sum += pieceOfClothing;
                }
            }

            Console.WriteLine(racksCount);
        }
    }
}
