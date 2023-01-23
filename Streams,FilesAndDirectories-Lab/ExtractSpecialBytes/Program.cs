using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ExtractSpecialBytes
    {
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
            using (StreamReader bytesReader = new StreamReader(bytesFilePath))
                {
                List<string> targetInput = new List<string>();
                string input;
                while ((input = bytesReader.ReadLine()) != null)
                    {
                    targetInput.Add(input);
                    }
                int[] bytes = targetInput.Select(int.Parse).ToArray();
                using (FileStream inputReader = new FileStream(binaryFilePath, FileMode.Open, FileAccess.Read))
                    {
                    inputReader.Seek(0, SeekOrigin.Begin);
                    byte [] data = new byte[inputReader.Length];
                    inputReader.Read(data, 0, data.Length);
                    using (FileStream output = new FileStream (outputPath,FileMode.OpenOrCreate,FileAccess.Write))
                        {
                        foreach (var item in data)
                            {
                            int @byte = int.Parse(item.ToString());
                            if (bytes.Contains(@byte))
                                {
                                output.WriteByte(item);
                                }
                            }
                        }
                    }
                }
            }
        }
    }