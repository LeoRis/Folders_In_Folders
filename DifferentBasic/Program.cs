using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DifferentBasic
{
    class Program
    {
        static void Main()
        {
            var path = @"C:\Homework\basic\";
            var longerPath = @"C:\Homework\";
            var filePath = @"C:\Homework\basic1\1\1.pdf";

            // TODO while()

            if (Helper.CheckIfPathIsFile(longerPath))
            {
                if (Directory.Exists(longerPath))
                {
                    Console.WriteLine("Directory exists.");
                }
                else
                {
                    Console.WriteLine("Directory doesn't exist.");
                }
            }
            else
            {
                Console.WriteLine("Please enter folder path.");
            }



            //Folders.CreateFolders(path);


            //Console.WriteLine("Please insert the type of extension that you wish to delete: ");

            //var extension = Console.ReadLine();

            //Helper.RemoveFilesWithExtension(filePath, extension);

            //EvenDocumentChangeName.Changer(longerPath);

        }
    }
}
