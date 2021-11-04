using System;
using System.IO;

namespace DifferentBasic
{
    public class Helper
    {
        #region FilesAndFolders
        public static void RemoveFilesWithExtension(string folderPath, string fileExtension)
        {
            String folder = Path.GetDirectoryName(folderPath);

            if (Directory.Exists(folderPath))
            {
                Console.WriteLine("Directory exists.");
            }
            else
            {
                Console.WriteLine("Directory doesn't exist.");
            }



            //var files = Directory.GetFiles(folder, "*.*", SearchOption.AllDirectories);

            //for(int i = 0; i < files.Length; i++)
            //{
            //    if (files[i].Contains(fileExtension))
            //    {
            //        File.Delete(files[i]);
            //    }
            //}

            //Console.WriteLine("Files removed.");
        }

        public static bool CheckIfPathIsFile(string filePath)
        {
            FileAttributes attr = File.GetAttributes(filePath);

            //detect whether its a directory or file
            if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
            {
                Console.WriteLine("It's a directory");
            }
            else
            {
                Console.WriteLine("It's a file");
                return true;
            }
            return false;
        }

        //public static void BackupMethod()

        #endregion

        #region Numbers



        #endregion
    }
}
