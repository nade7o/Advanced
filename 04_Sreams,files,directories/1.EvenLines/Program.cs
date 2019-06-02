using System;
using System.IO;
using System.Linq;

namespace _1.EvenLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string textFilePath = @"../../../text.txt";
            int counter = 0;

            using (StreamReader streamReader = new StreamReader(textFilePath))
            {
                string currentLine = streamReader.ReadLine();

                while (currentLine != null)
                {
                    if (counter % 2 == 0)
                    {
                        string replacedSymbols = ReplaceSpecialChars(currentLine);
                        string reversedWord = ReverseWords(replacedSymbols);

                        Console.WriteLine(reversedWord);
                    }
                    currentLine = streamReader.ReadLine();

                    counter++;
                }             
            }
        }

        private static string ReverseWords(string replacedSymbols)
        {
            return string.Join(" ", replacedSymbols.Split().Reverse());
        }

        private static string ReplaceSpecialChars(string currentLine)
        {
           return currentLine.Replace("-", "@")
                .Replace(",", "@")
                .Replace(".", "@")
                .Replace("!", "@")
                .Replace("?", "@");
        }
    }
}
