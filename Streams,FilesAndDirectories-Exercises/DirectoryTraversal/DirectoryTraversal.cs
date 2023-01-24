namespace DirectoryTraversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = Console.ReadLine();
            string reportFileName = @"\report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
           SortedDictionary<string,List<string>> extentionsFile = new SortedDictionary<string,List<string>>();
            string[] files = Directory.GetFiles(inputFolderPath);


            foreach (string file in files)
                {
                FileInfo fileInfo = new FileInfo(file);

                if (!extentionsFile.ContainsKey(fileInfo.Extension))
                    {
                    extentionsFile.Add(fileInfo.Extension, new List<string>());
                    }
                double size = (double)fileInfo.Length / 1024;
                extentionsFile[fileInfo.Extension].Add($"--{fileInfo.Name:f3} - {size}kb");
                }

            StringBuilder sb = new StringBuilder();
            foreach (var file in extentionsFile.OrderByDescending(sb => sb.Value.Count))
                {
                sb.AppendLine(file.Key);
                foreach (var name in file.Value.OrderBy(f=>f.Length))
                    {
                    sb.AppendLine(name);
                    }
                }

            return sb.ToString();
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = path + reportFileName;

            File.WriteAllText(filePath, textContent);
        }
    }
}
