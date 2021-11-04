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
            bool result = false;
            FileAttributes attr = File.GetAttributes(filePath);

            //detect whether its a directory or file
            if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
            {
                Console.WriteLine("It's a directory");
                result = false;
            }
            else
            {
                Console.WriteLine("It's a file");
                result = true;
            }
            return result;
        }

        public static void BackupFolder(string sourcePath, string targetPath)
        {
            var listDirectories = Directory.GetDirectories(sourcePath, "*", SearchOption.AllDirectories);
            var listFiles = Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories);

            if (Directory.Exists(sourcePath))
            {
                //Now Create all of the directories
                foreach (string dirPath in listDirectories)
                {
                    Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));
                }

                //Copy all the files & Replaces any files with the same name
                foreach (string newPath in listFiles)
                {
                    File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
                }
            }
            else
            {
                Console.WriteLine("Wrong path.");
            }
        }

        #endregion

        #region Numbers



        #endregion
    }
}
