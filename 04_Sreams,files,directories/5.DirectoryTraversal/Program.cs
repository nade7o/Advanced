using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
namespace _5.DirectoryTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fileArray = Directory.GetFiles(".", "*.*");

            var dirInfo = new Dictionary<string, Dictionary<string, double>>();

            DirectoryInfo directoryInfo = new DirectoryInfo(".");

            FileInfo[] allFiles = directoryInfo.GetFiles();

            foreach (var currentFile in allFiles)
            {
                double size = currentFile.Length / 1024d;
                string fileName = currentFile.Name;
                string extension = currentFile.Extension;

                if (!dirInfo.ContainsKey(extension))
                {
                    dirInfo.Add(extension, new Dictionary<string, double>());
                }

                if (!dirInfo[extension].ContainsKey(fileName))
                {
                    dirInfo[extension].Add(fileName, size);
                }

            }
            //create report.txt on desktop
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"/report.txt";

            foreach (var item in dirInfo.OrderByDescending(x=>x.Value.Count).ThenBy(x=>x.Key))
            {
                File.AppendAllText(path, item.Key + Environment.NewLine);

                foreach (var kvp in item.Value.OrderBy(x=>x.Value))
                {
                   File.AppendAllText(path, $"--{kvp.Key} - {Math.Round(kvp.Value, 3)}kb" + Environment.NewLine);
                }
            }
        }
    }
}
