using System.IO;

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
            using (StreamReader binary = new StreamReader(binaryFilePath))
                {
                using (StreamReader bytes = new StreamReader(bytesFilePath))
                    {
                    using (StreamWriter output = new StreamWriter(outputPath))
                        {

                        }
                    }
                }
            }
        }
    }