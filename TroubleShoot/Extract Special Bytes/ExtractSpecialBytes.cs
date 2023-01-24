namespace ExtractSpecialBytes
    {
    using System;
    using System.Collections.Generic;
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
            using (StreamReader bytesInput = new StreamReader(bytesFilePath))
                {
                List<int> targetBytes = new List<int>();
                string input;
                while ((input = bytesInput.ReadLine()) != null)
                    {
                    targetBytes.Add(int.Parse(input));
                    }
                using (FileStream inputReader = new FileStream(binaryFilePath, FileMode.Open, FileAccess.Read))
                    {
                    inputReader.Seek(0, SeekOrigin.Begin);
                    byte[] buffer = new byte[inputReader.Length];
                    inputReader.Read(buffer, 0, buffer.Length);

                    using (FileStream output = new FileStream(outputPath, FileMode.OpenOrCreate, FileAccess.Write))
                        {
                        foreach (var item in buffer)
                            {
                            int currentByte = (int)item;

                            if (targetBytes.Contains(currentByte))
                                {
                                output.WriteByte((byte)currentByte);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
