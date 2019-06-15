using System;
using System.Linq;

namespace _06.ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int n = int.Parse(Console.ReadLine());
            

            Func<int, bool> filter = x => x % n != 0;

            var remainingNumbers = inputNumbers.Reverse().Where(filter);

            Console.WriteLine(string.Join(" ", remainingNumbers));
        }
    }
}
