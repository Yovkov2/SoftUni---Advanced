namespace LineNumbers
{
    using System;
    using System.IO;

    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            using(StreamReader reader = new StreamReader(inputFilePath))
            {
                using(StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    string line = reader.ReadLine();
                    int count = 1;
                    while(line != null)
                    {
                        int letter = 0;
                        int punctuation = 0;
                        foreach(char c in line)
                        {
                            if (char.IsLetter(c))
                            {
                                letter++;
                            }
                            else if(char.IsPunctuation(c))
                            {
                                punctuation++;
                            }
                        }
                        writer.WriteLine($"Line {count++} {line} ({letter}) ({punctuation})");
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
