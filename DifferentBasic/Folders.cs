using System;
using System.Collections.Generic;
using System.IO;

namespace DifferentBasic
{
    public class Folders
    {        
        public static String CreateFolders(String path)
        {
            String folder = Path.GetDirectoryName(path);

            string[] extensions = new string[] { ".txt", ".doc", ".pdf", ".html", ".odt"};
            Random random = new Random();

            int counter = 1;

            while (counter <= 10)
            {
                if (!Directory.Exists(folder))
                {
                    DirectoryInfo mainDirectory = Directory.CreateDirectory(folder + counter + "\\");
                    for (int j = 1; j <= 10; j++)
                    {
                        DirectoryInfo subDirectory= Directory.CreateDirectory(folder + counter + "\\" + j);
                        for(int k = 0; k < 10; k++)
                        {
                            FileStream subFile = File.Create(folder + counter + "\\" + j + "\\" + k + extensions[random.Next(extensions.Length)]);
                            subFile.Close();
                        }                        
                    }
                }
                counter++;
            }            

            return path;
        }    
    }
}
