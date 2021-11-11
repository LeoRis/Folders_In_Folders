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
            string[] files = Directory.GetFiles(folder, "*.*", SearchOption.AllDirectories);

            for(int i = 0; i < files.Length; i++)
            {
                if(i % 2 == 0)
                {
                    File.Move(files[i], files[i] + "different");
                }
            }
        }
    }
}
