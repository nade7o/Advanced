﻿using System;
using System.Collections.Generic;

namespace _09.SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stackOfText = new Stack<string>();
            string text = string.Empty;

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (input[0] == "1")
                {
                    stackOfText.Push(text); //empty text
                    text += input[1];
                }
                else if (input[0] == "2")
                {
                    int index = int.Parse(input[1]);
                    stackOfText.Push(text);  //fjkldnvgdfl
                    text = text.Substring(0, text.Length - index);
                }
                else if (input[0] == "3")
                {
                    int index = int.Parse(input[1]);
                    Console.WriteLine(text[index - 1]);
                }
                else if (input[0] == "4")
                {
                    text = stackOfText.Pop();
                }
            }
        }
    }
}
