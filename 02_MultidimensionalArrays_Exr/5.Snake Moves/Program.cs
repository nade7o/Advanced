﻿using System;
using System.Linq;

namespace _5.Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

           char[,] matrix = new char[rows, cols];

            char[] snake = Console.ReadLine().ToCharArray();

            int counter = 0;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (counter >= snake.Length)
                    {
                        counter = 0;
                    }
                    matrix[row, col] = snake[counter++];
                }
            }
            for (int row = 0; row <rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
