namespace CopyDirectory
{
    using System;
    using System.IO;

    public class CopyDirectory
    {
        static void Main()
        {
            string inputPath =  @$"{Console.ReadLine()}";
            string outputPath = @$"{Console.ReadLine()}";

            CopyAllFiles(inputPath, outputPath);
        }

        public static void CopyAllFiles(string inputPath, string outputPath)
        {
            if (Directory.Exists(outputPath))
            {
                Directory.Delete(outputPath, true);
            }
            Directory.CreateDirectory(outputPath);

            string[] file = Directory.GetFiles(inputPath);
            foreach(var files in file)
            {
                string fileName = Path.GetFileName(files);

                string inputFile = Path.Combine(outputPath, fileName); 
                File.Copy(inputFile, outputPath);
            }
        }
    }
}
