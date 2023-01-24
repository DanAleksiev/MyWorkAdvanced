namespace CopyBinaryFile
{
    using System;
    using System.IO;

    public class CopyBinaryFile
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\copyMe.png";
            string outputFilePath = @"..\..\..\copyMe-copy.png";

            CopyFile(inputFilePath, outputFilePath);
        }

        public static void CopyFile(string inputFilePath, string outputFilePath)
        {
           using (FileStream read = new FileStream(inputFilePath,FileMode.Open,FileAccess.Read))
                {
                read.Seek(0, SeekOrigin.Begin);
                byte[] buffer = new byte[read.Length];
                read.Read(buffer, 0, buffer.Length);
                using (FileStream write = new FileStream(outputFilePath, FileMode.OpenOrCreate, FileAccess.Write))
                    {
                    write.Write(buffer);
                    }

                }
        }
    }
}
