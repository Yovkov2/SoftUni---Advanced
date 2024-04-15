namespace SplitMergeBinaryFile
{
    using System;
    using System.IO;
    using System.Linq;

    public class SplitMergeBinaryFile
    {
        static void Main()
        {
            string sourceFilePath = @"..\..\..\Files\example.png";
            string joinedFilePath = @"..\..\..\Files\example-joined.png";
            string partOnePath = @"..\..\..\Files\part-1.bin";
            string partTwoPath = @"..\..\..\Files\part-2.bin";

            SplitBinaryFile(sourceFilePath, partOnePath, partTwoPath);
            MergeBinaryFiles(partOnePath, partTwoPath, joinedFilePath);
        }

        public static void SplitBinaryFile(string sourceFilePath, string partOneFilePath, string partTwoFilePath)
        {
            using (FileStream sourceFile = new FileStream(sourceFilePath, FileMode.Open, FileAccess.Read))
            {
                long fileSize = sourceFile.Length;
                int partOneSize = (int)Math.Ceiling((double)fileSize / 2);
                int partTwoSize = (int)Math.Floor((double)fileSize / 2);

                byte[] buffer = new byte[fileSize];
                sourceFile.Read(buffer, 0, buffer.Length);

                using (FileStream partOneFile = new FileStream(partOneFilePath, FileMode.Create, FileAccess.Write))
                {
                    partOneFile.Write(buffer, 0, partOneSize);
                }

                using (FileStream partTwoFile = new FileStream(partTwoFilePath, FileMode.Create, FileAccess.Write))
                {
                    partTwoFile.Write(buffer, partOneSize, partTwoSize);
                }
            }
        }

        public static void MergeBinaryFiles(string partOneFilePath, string partTwoFilePath, string joinedFilePath)
        {
            using (FileStream partOneFile = new FileStream(partOneFilePath, FileMode.Open, FileAccess.Read))
            using (FileStream partTwoFile = new FileStream(partTwoFilePath, FileMode.Open, FileAccess.Read))
            using (FileStream joinedFile = new FileStream(joinedFilePath, FileMode.Create, FileAccess.Write))
            {
                byte[] buffer = new byte[4096];
                int bytesRead;

                while ((bytesRead = partOneFile.Read(buffer, 0, buffer.Length)) > 0)
                {
                    joinedFile.Write(buffer, 0, bytesRead);
                }

                while ((bytesRead = partTwoFile.Read(buffer, 0, buffer.Length)) > 0)
                {
                    joinedFile.Write(buffer, 0, bytesRead);
                }
            }
        }
    }
}