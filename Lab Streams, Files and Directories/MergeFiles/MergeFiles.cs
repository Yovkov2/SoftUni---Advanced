namespace MergeFiles
{
    using System;
    using System.IO;
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            using(StreamReader reader = new StreamReader(firstInputFilePath))
            {
                using(StreamReader reader2 = new StreamReader(secondInputFilePath))
                {
                    using(StreamWriter writer = new StreamWriter(outputFilePath))
                    {
                        string line = reader.ReadLine();
                        string line2 = reader2.ReadLine();
                       while(line != null)
                       {
                            writer.WriteLine(line);
                            while (line2 != null)
                            {
                                writer.WriteLine(line2);
                                line2 = reader2.ReadLine();
                            }
                            line = reader.ReadLine();
                       }
                        
                    }
                }
            }
        }
    }
}
