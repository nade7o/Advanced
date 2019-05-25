using System;
using System.Linq;
namespace _4.Matrix_shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] colElements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (input.Contains("swap") && tokens.Length == 5)
                {
                    int selectedRow = int.Parse(tokens[1]);
                    int selectedCol = int.Parse(tokens[2]);
                    int rowToSwap = int.Parse(tokens[3]);
                    int colToSwap = int.Parse(tokens[4]);

                    if (selectedRow >= 0 && selectedRow < matrix.GetLength(0)
                        && selectedCol >= 0 && selectedCol < matrix.GetLength(1)
                        && rowToSwap >= 0 && rowToSwap < matrix.GetLength(0)
                        && colToSwap >= 0 && colToSwap < matrix.GetLength(1))
                    {
                       
                        var temp = matrix[selectedRow, selectedCol];
                        matrix[selectedRow, selectedCol] = matrix[rowToSwap, colToSwap];
                        matrix[rowToSwap, colToSwap] = temp;

                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            for (int col = 0; col < matrix.GetLength(1); col++)
                            {
                                Console.Write(matrix[row, col] + " ");
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
    }
}
