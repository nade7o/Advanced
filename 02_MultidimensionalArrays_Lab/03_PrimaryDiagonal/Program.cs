using System;
using System.Linq;

namespace _03_PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }
            int sum = 0;
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = col; row < matrix.GetLength(0); row++)
                {
                    sum += matrix[row, col];
                    break;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
