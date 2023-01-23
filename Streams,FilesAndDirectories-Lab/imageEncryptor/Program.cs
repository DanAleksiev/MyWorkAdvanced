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
            while (File.Exists($"{basePath}{imageNumber}.jpg"))
                {
                using (var stream = new FileStream($"{basePath}{imageNumber}.jpg", FileMode.Open))
                    {
                    byte[] buffer = new byte[stream.Length];
                    stream.Read(buffer, 0, buffer.Length);
                    //Console.WriteLine(string.Join(" ",buffer));
                    using (var encryptedStream = new FileStream($"{basePath}{imageNumber}.encrypted.jpg", FileMode.OpenOrCreate))
                        {
                        for (int i = 0; i < buffer.Length; i++)
                            {
                            //to decrypt just ^ with the same number and it'll return it to the original format
                            buffer[i] = (byte)(buffer[i] ^ 157);
                            }
                        encryptedStream.Write(buffer, 0, buffer.Length);
                        }
                    }
                imageNumber++;
                //while (File.Exists($"{basePath}{imageNumber}.encrypted.jpg"))
                //    {

                //    using (var stream = new FileStream($"{basePath}{imageNumber}.encrypted.jpg", FileMode.Open))
                //        {
                //        byte[] buffer = new byte[stream.Length];

                //        stream.Read(buffer, 0, buffer.Length);

                //        //Console.WriteLine(string.Join(" ",buffer));

                //        using (var encryptedStream = new FileStream($"{basePath}{imageNumber}.jpg", FileMode.OpenOrCreate))
                //            {
                //            for (int i = 0; i < buffer.Length; i++)
                //                {
                //                buffer[i] = (byte)(buffer[i] ^ 157);
                //                }

                //            encryptedStream.Write(buffer, 0, buffer.Length);
                //            }
                //        }
                //    imageNumber++;
                //    }
                }
            }
        }
    }
