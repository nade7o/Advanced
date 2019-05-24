using System;
using System.Linq;

namespace _06_Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jaggedArray[i] = numbers;
            }

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "END")
            {
                string[] tokens = command.Split();
                string operation = tokens[0];
                int row = int.Parse(tokens[1]);
                int col = int.Parse(tokens[2]);
                int value = int.Parse(tokens[3]);

                if (row < 0 || row >= rows || col < 0 || col >= jaggedArray[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }

                switch (operation)
                {
                    case "Add":
                        jaggedArray[row][col] += value;
                        break;
                    case "Subtract":
                        jaggedArray[row][col] -= value;
                        break;
                }
            }
            foreach (var item in jaggedArray)
            {
                Console.WriteLine(String.Join(" ", item));
            }
        }
    }
}
