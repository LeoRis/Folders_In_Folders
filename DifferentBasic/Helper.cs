using System;
using System.IO;
using System.Net;
using System.Xml;
using System.Xml.Serialization;

namespace DifferentBasic
{
    public class Helper
    {
        #region FilesAndFolders
        public static void RemoveFilesWithExtension(string folderPath, string fileExtension)
        {
            String folder = Path.GetDirectoryName(folderPath);

            var files = Directory.GetFiles(folder, "*.*", SearchOption.AllDirectories);

            for (int i = 0; i < files.Length; i++)
            {
                if (files[i].Contains(fileExtension))
                {
                    File.Delete(files[i]);
                }
            }

            Console.WriteLine("Files removed.");
        }

        public static bool CheckIfPathIsFile(string filePath)
        {
            bool result;
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

        public static void BackupFolder(string sourcePath, string targetPath, int location)
        {
            // 1 (location) for local computer
            // 2 (location) for remote computer

            // C# code for FTP TODO

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
        public static Int32 TryParseInt(string value)
        {
            int number;

            bool result = Int32.TryParse(value, out number);

            if (result)
            {
                return number;
            }
            else
            {
                // If value is invalid, return -1. -This value is mutualy agreed between the teams.
                return -1;
            }
        }


        /*public static bool CheckValidDecimal(string number)
        {

            NumberStyles style = NumberStyles.AllowDecimalPoint | NumberStyles.Number;
            CultureInfo culture = CultureInfo.CreateSpecificCulture("en-GB");
            decimal result;

            if (Decimal.TryParse(number, style, culture, out result))
            {
                return true;
            }
            else
                return false;


        }*/


        #endregion
    }
}
