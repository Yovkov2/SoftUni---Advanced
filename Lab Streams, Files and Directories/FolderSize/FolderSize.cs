namespace FolderSize
{
    using System;
    using System.IO;
    public class FolderSize
    {
        static void Main(string[] args)
        {
            string folderPath = @"..\..\..\Files\TestFolder";
            string outputPath = @"..\..\..\Files\output.txt";

            GetFolderSize(folderPath, outputPath);
        }

        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
            long totalSizeBytes = 0;

            foreach(var file in Directory.GetFiles(folderPath, "*", SearchOption.AllDirectories))
            {
                FileInfo fileInfo = new FileInfo(file);
                totalSizeBytes += fileInfo.Length;
            }
            double totalSizeKB = totalSizeBytes / 1024;
            File.WriteAllText(outputFilePath, totalSizeKB.ToString("0.##") + " KB");
        }
    }
}
