using System;
using System.Collections.Generic;
using System.IO;

namespace SplitMergeBinaryFile
    {
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
            List<string> fileInBytes = new List<string>();
            using (FileStream inputReader = new FileStream(sourceFilePath, FileMode.Open, FileAccess.Read))
                {
                inputReader.Seek(0, SeekOrigin.Begin);
                byte[] buffer = new byte[inputReader.Length];
                inputReader.Read(buffer, 0, buffer.Length);
                using (FileStream outputPt1 = new FileStream(partOneFilePath, FileMode.OpenOrCreate, FileAccess.Write))
                    {
                    using (FileStream outputPt2 = new FileStream(partTwoFilePath, FileMode.OpenOrCreate, FileAccess.Write))
                        {
                        for (int i = 0; i < inputReader.Length; i++)
                            {

                            if (i % 2 == 0)
                                {
                                outputPt1.WriteByte(buffer[i]);
                                }
                            else
                                {
                                outputPt2.WriteByte(buffer[i]);
                                }
                            }
                        }
                    }
                }
            }

        public static void MergeBinaryFiles(string partOneFilePath, string partTwoFilePath, string joinedFilePath)
            {
            using (FileStream inputReaderPt1 = new FileStream(partOneFilePath, FileMode.Open, FileAccess.Read))
                {
                using (FileStream inputReaderPt2 = new FileStream(partTwoFilePath, FileMode.Open, FileAccess.Read))
                    {
                    inputReaderPt1.Seek(0, SeekOrigin.Begin);
                    byte[] bufferPt1 = new byte[inputReaderPt1.Length];
                    inputReaderPt1.Read(bufferPt1, 0, bufferPt1.Length);

                    inputReaderPt2.Seek(0, SeekOrigin.Begin);
                    byte[] bufferPt2 = new byte[inputReaderPt2.Length];
                    inputReaderPt2.Read(bufferPt2, 0, bufferPt2.Length);

                    using (FileStream output = new FileStream(joinedFilePath, FileMode.OpenOrCreate, FileAccess.Write))
                        {
                        for (int i = 0; i < bufferPt1.Length; i++)
                            {
                            output.WriteByte(bufferPt1[i]);
                            if (i < bufferPt2.Length)
                                {
                                output.WriteByte(bufferPt2[i]);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
