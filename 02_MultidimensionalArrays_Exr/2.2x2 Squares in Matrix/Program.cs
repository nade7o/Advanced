﻿using System;
using System.Linq;

namespace _2._2x2_Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[,] matrix = new int[dimensions[0], dimensions[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] colElements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }
            int count = 0;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    //A B
                    //E B
                    if (matrix[row, col] == matrix[row, col + 1]
                     && matrix[row + 1, col] == matrix[row + 1, col + 1]
                     && matrix[row, col] == matrix[row + 1, col])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
