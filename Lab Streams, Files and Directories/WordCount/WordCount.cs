namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            HashSet<string> targetWords = new HashSet<string>(File.ReadAllLines(wordsFilePath), StringComparer.OrdinalIgnoreCase);

            string[] allLines = File.ReadAllLines(textFilePath);

            Dictionary<string, int> wordCount = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

            foreach (string line in allLines)
            {
                string[] wordsLine = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                foreach (string word in wordsLine)
                {
                    if (targetWords.Contains(word))
                    {
                        if (wordCount.ContainsKey(word))
                        {
                            wordCount[word]++;
                        }
                        else
                        {
                            wordCount[word] = 1;
                        }
                    }
                }
            }
            var sortedWordCounts = wordCount.OrderByDescending(pair => pair.Value);
            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                foreach (var word in sortedWordCounts)
                {
                    writer.WriteLine($"{word.Key} - {word.Value}");
                }
            }
        }
    }
}