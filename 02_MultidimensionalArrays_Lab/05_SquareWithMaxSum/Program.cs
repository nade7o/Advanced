using System;
using System.Linq;

namespace _05_SquareWithMaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[,] matrix = new int[sizes[0], sizes[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }
            int biggestSum = 0;
            int selectedRow = -1;
            int selectedCol = -1;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int newSum = matrix[row, col] +
                                 matrix[row + 1, col] +
                                 matrix[row, col + 1] +
                                 matrix[row + 1, col + 1];
                    if (newSum > biggestSum)
                    {
                        biggestSum = newSum;
                        selectedRow = row;
                        selectedCol = col;
                    }
                }
            }
            Console.WriteLine($"{matrix[selectedRow, selectedCol]} {matrix[selectedRow, selectedCol+1]}");
            Console.WriteLine($"{matrix[selectedRow+1, selectedCol]} {matrix[selectedRow+1, selectedCol+1]}");
            Console.WriteLine(biggestSum);
        }
    }
}
