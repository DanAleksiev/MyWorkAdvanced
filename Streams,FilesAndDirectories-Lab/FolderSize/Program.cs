using System;
using System.Drawing;
using System.IO;

namespace FolderSize
    {
    public class FolderSize
        {
        static void Main()
            {
            string folderPath = @"..\..\..\Files\TestFolder";
            string outputPath = @"..\..\..\Files\output.txt";

            GetFolderSize(folderPath, outputPath);
            }

        public static void GetFolderSize(string folderPath, string outputFilePath)
            {
           long size = GetFolderSize(folderPath);

            File.WriteAllText(outputFilePath, $"{size/1024} KB");
            }
        public static long GetFolderSize(string folderPath)
            {
            string[] filesInOriginalFolder = Directory.GetFiles(folderPath);
            long size = 0;
            foreach (string file in filesInOriginalFolder)
                {
                FileInfo info = new FileInfo(file);
                size += info.Length;
                }

            foreach(var dir in Directory.GetDirectories(folderPath))
                {
                size += GetFolderSize(dir);
                }
            return size;
            }
        }
    }

