namespace ExtractSpecialBytes
{
    using System;
    using System.IO;
    public class ExtractSpecialBytes
    {
        static void Main()
        {
            string binaryFilePath = @"..\..\..\Files\example.png";
            string bytesFilePath = @"..\..\..\Files\bytes.txt";
            string outputPath = @"..\..\..\Files\output.bin";

            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }

        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {
            byte[] betesToExtract = File.ReadAllBytes(bytesFilePath);
            using(FileStream inputfileStream = new FileStream(binaryFilePath, FileMode.Open, FileAccess.Read))
            {
                using(FileStream outputfileStream = new FileStream(outputPath, FileMode.Create, FileAccess.Write))
                {
                    int byteRead;
                    while((byteRead = inputfileStream.ReadByte()) != -1)
                    {
                        if(Array.IndexOf(betesToExtract, (byte)byteRead) != -1)
                        {
                            outputfileStream.WriteByte((byte)byteRead);
                        }
                    }
                }
            }
        }
    }
}
