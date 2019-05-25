using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }
            int firstSum = 0;
            for (int col = 0; col < matrix.GetLength(0); col++)
            {
                for (int row = col; row < matrix.GetLength(1); row++)
                {
                    firstSum += matrix[row, col];
                    break;
                }
            }
            int secondSum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = matrix.GetLength(1)-1 - row; col >= 0; col --)
                {
                    secondSum += matrix[row, col];
                    break;
                }
            }

            Console.WriteLine($"{Math.Abs(firstSum - secondSum)}");
        }
    }
}
