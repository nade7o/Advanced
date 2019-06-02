using System;
using System.Collections.Generic;

namespace _06_Wardobe
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ");

                string color = input[0];

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }
                string[] clothes = input[1].Split(',');

                for (int j = 0; j < clothes.Length; j++)
                {
                    if (!wardrobe[color].ContainsKey(clothes[j]))
                    {
                        wardrobe[color].Add(clothes[j], 0);
                    }
                    wardrobe[color][clothes[j]]++;
                }
            }
            string[] target = Console.ReadLine().Split();
            string targetColor = target[0];
            string targetCloth = target[1];

            foreach (var kvp in wardrobe)
            {
                Console.WriteLine($"{kvp.Key} clothes:");

                foreach (var kvp2 in kvp.Value)
                {
                    string result = ($"* {kvp2.Key} - {kvp2.Value}");

                    if (kvp.Key == targetColor && kvp2.Key == targetCloth)
                    {
                        result += " (found!)";
                    }
                    Console.WriteLine(result);
                }
            }
        }
    }
}
