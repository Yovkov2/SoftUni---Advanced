namespace DirectoryTraversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = Console.ReadLine();
            string reportFileName = @"\report.txt";
            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);
            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            Dictionary<string, List<FileInfo>> fileDictionary = new Dictionary<string, List<FileInfo>>();

            
            DirectoryInfo directoryInfo = new DirectoryInfo(inputFolderPath);
            FileInfo[] files = directoryInfo.GetFiles();

          
            foreach (FileInfo file in files)
            {
                string extension = file.Extension.ToLower();

                if (!fileDictionary.ContainsKey(extension))
                {
                    fileDictionary[extension] = new List<FileInfo>();
                }

                fileDictionary[extension].Add(file);
            }

          
            var sortedFileGroups = fileDictionary.OrderByDescending(kv => kv.Value.Count)
                                                 .ThenBy(kv => kv.Key);

            
            List<string> lines = new List<string>();
            foreach (var group in sortedFileGroups)
            {
                lines.Add(group.Key);
                foreach (var fileInfo in group.Value.OrderBy(fi => fi.Length))
                {
                    lines.Add($"--{fileInfo.Name} - {fileInfo.Length / 1024.0:F3}kb");
                }
            }

            return string.Join(Environment.NewLine, lines);
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string reportFilePath = desktopPath + reportFileName;
            File.WriteAllText(reportFilePath, textContent);
        }
    }
}
