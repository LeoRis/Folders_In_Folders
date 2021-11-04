using System;
using System.IO;
using System.Collections.Generic;

namespace DifferentBasic
{
    public class EvenDocumentChangeName
    {
        public static void Changer(string path)
        {
            //Console.WriteLine("Please type extension for change:");
            //extension = Console.ReadLine();            

            string folder = Path.GetDirectoryName(path);
            var files = Directory.GetFiles(folder, "*.*", SearchOption.AllDirectories);
            List<FileInfo> sourceFiles = new List<FileInfo>();

            foreach(var file in files)
            {
                sourceFiles.Add(new FileInfo(file));
            }

            sourceFiles.ToArray();

            for(int i = 0; i < sourceFiles.Count; i++)
            {
                if(i % 2 == 0)
                {
                    File.Move(files[i], files[i] + "different");
                }
            }
        }
    }
}
