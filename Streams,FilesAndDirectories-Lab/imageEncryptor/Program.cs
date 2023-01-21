using System;
using System.IO;

namespace imageEncryptor
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string basePath = "../../../Images/";
            int imageNumber = 1;

            while (File.Exists($"{basePath}{imageNumber}.jpeg"))
                {
                using (var stream = new FileStream($"{basePath}{imageNumber}.jpeg", FileMode.Open))
                    {
                    byte[] buffer = new byte[stream.Length];
                    stream.Read(buffer, 0, buffer.Length);
                    //Console.WriteLine(string.Join(" ",buffer));

                    using (var ecryptedStream = new FileStream($"{basePath}{imageNumber}.encrypted.jpeg", FileMode.OpenOrCreate))
                        {
                        for (int i = 0; i < buffer.Length; i++)
                            {
                            buffer[i] = (byte)(buffer[i] ^ 157);
                            }
                        ecryptedStream.Write(buffer, 0, buffer.Length);
                        }
                    }
                imageNumber++;
                }
            }
        }
    }
