using System;
using System.IO;

namespace DifferentBasic
{
    public class Helper
    {
        #region FilesAndFolders
        public static void RemoveFilesWithExtension(string path)
        {
            String folder = Path.GetDirectoryName(path);

            Console.WriteLine("Please insert the type of extension that you wish to delete: ");

            var extensionToBeRemoved = Console.ReadLine();
            var files = Directory.GetFiles(folder, "*.*", SearchOption.AllDirectories);

            for(int i = 0; i < files.Length; i++)
            {
                if (files[i].Contains(extensionToBeRemoved))
                {
                    File.Delete(files[i]);
                }
            }

            Console.WriteLine("Files removed.");
        }
        #endregion
    }
}
