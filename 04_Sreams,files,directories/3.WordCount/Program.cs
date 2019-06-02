
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _3.WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string textPath = @"../../../text.txt";
            string wordPath = @"../../../words.txt";

            string[] textLines = File.ReadAllLines(textPath);
            string[] words = File.ReadAllLines(wordPath);

            Dictionary<string, int> wordsInfo = new Dictionary<string, int>();

            foreach (var word in words)
            {
                string currentWordLowerCase = word.ToLower();

                if (!wordsInfo.ContainsKey(currentWordLowerCase))
                {                  
                    wordsInfo.Add(currentWordLowerCase, 0);
                }
            }

            foreach (var currentLine in textLines)
            {
                string[] currentLineWords = currentLine.ToLower().Split(new char[] { ' ', '-', ',', '?', '!', '.', '\\', ':', ':' });

                foreach (var currentWord in currentLineWords)
                {
                    if (wordsInfo.ContainsKey(currentWord))
                    {
                        wordsInfo[currentWord]++;
                    }
                }
            }
            string actualResultPath = @"../../../actualResult.txt";
            string expectedResultPath = @"../../../expectedResult.txt";

            foreach (var kvp in wordsInfo)
            {
               File.AppendAllText(actualResultPath, $"{kvp.Key} - {kvp.Value} {Environment.NewLine}");
            }
            foreach (var kvp in wordsInfo.OrderByDescending(x => x.Value))
            {
                File.AppendAllText(expectedResultPath, $"{kvp.Key} - {kvp.Value} {Environment.NewLine}");
            }
        }
    }
}
