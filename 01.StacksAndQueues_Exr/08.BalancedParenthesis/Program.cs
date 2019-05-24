using System;
using System.Collections.Generic;
using System.Linq;
namespace _08.BalancedParenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> paranthesis = new Stack<char>();

            char[] input = Console.ReadLine().ToCharArray();

            char[] openParanthesis = new char[] { '(', '{', '[' };

            bool isValid = true;

            foreach (var item in input)
            {
                if (openParanthesis.Contains(item))
                {
                    paranthesis.Push(item);
                    continue;
                }

                if (paranthesis.Count == 0)
                {
                    isValid = false;
                    break;
                }

                if (paranthesis.Peek() == '(' && item == ')')
                {
                    paranthesis.Pop();
                }
                else if (paranthesis.Peek() == '{' && item == '}')
                {
                    paranthesis.Pop();
                }
                else if (paranthesis.Peek() == '[' && item == ']')
                {
                    paranthesis.Pop();
                }
                else
                {
                    isValid = false;
                    break;
                }
            }
            if (isValid)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
