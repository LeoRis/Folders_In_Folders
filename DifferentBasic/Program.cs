using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System;

namespace DifferentBasic
{

    class Program
    {
        static void Main()
        {
            #region BuildEmail Demo
            //FTP testFTP = new FTP();
            //var host = testFTP.host = "82.214.114.2:21";
            //testFTP.UserId = "bojan_academy";
            //testFTP.Password = "qjeK7#88";

            //testFTP.CreateFolder(host);

            //BuildEmail newEmailForBojan = new BuildEmail();

            //BuildEmail.To = "test.different.basic@gmail.com";
            //BuildEmail.Body = "Hello World!";
            //BuildEmail.Subject = "Test Email Via C#";

            //if (BuildEmail.SendMailCustomBody())
            //{
            //    Console.WriteLine("I need to study a LOT!");
            //}
            //else
            //{
            //    Console.WriteLine("You suck!");
            //}
            #endregion

            #region Folders Demo
            //var path = @"C:\Homework\basic\";
            //var longerPath = @"C:\Homework\";
            //var filePath = @"C:\Homework\basic1\1\1.pdf";
            //var sourceFolder = @"C:\Homework\basic1";
            //var destinationFolder = @"C:\tmp\";
            //int location = 1;

            // TODO while()

            //Helper.BackupFolder(sourceFolder, destinationFolder, location);

            //if (Helper.CheckIfPathIsFile(longerPath))
            //{
            //    if (Directory.Exists(longerPath))
            //    {
            //        Console.WriteLine("Directory exists.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Directory doesn't exist.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Please enter folder path.");
            //}

            //Folders.CreateFolders(path);

            //Console.WriteLine("Please insert the type of extension that you wish to delete: ");

            //var extension = Console.ReadLine();

            //Helper.RemoveFilesWithExtension(filePath, extension);

            //EvenDocumentChangeName.Changer(longerPath);
            #endregion

            HomeworkMenu.CreateMenu();

            Console.ReadKey();

        }
    }
}
