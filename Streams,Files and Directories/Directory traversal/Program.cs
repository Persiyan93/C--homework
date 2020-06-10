using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Directory_traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, decimal>> files = new Dictionary<string, Dictionary<string, decimal>>();
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            string[] filesInDir = Directory.GetFiles(Path.Combine(allDrives[1].ToString()));
            foreach (var file in filesInDir)
            {
                FileInfo fileInfo = new FileInfo(file);
                string extension = fileInfo.Extension;
                string nameOfFile = fileInfo.Name;
                decimal size = (decimal)fileInfo.Length / 1024;

                if (!files.ContainsKey(extension))
                {
                    files.Add(extension, new Dictionary<string, decimal>());
                }
                files[extension].Add(nameOfFile, size);


                files = files.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key).
                    ToDictionary(x => x.Key, x => x.Value.OrderBy(y => y.Value).
                ToDictionary(y => y.Key, y => y.Value));


            }
            StringBuilder sb = new StringBuilder();
            foreach (var extension in files)
            {
                sb.AppendLine(extension.Key);
                foreach (var fileName in extension.Value)
                {
                    sb.AppendLine($"--{fileName.Key} - {fileName.Value:F3}kb");
                }
            }
          
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string finalpath = Path.Combine(path, "report.txt");
            File.WriteAllText(finalpath, sb.ToString());
        }
    }
}
