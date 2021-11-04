using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentBasic
{
    class Program
    {
        static void Main()
        {
            var path = @"C:\Homework\basic\";
            var longerPath = @"C:\Homework\";

            //Folders.CreateFolders(path);

            UserInput.RemoveFilesWithExtension(longerPath);

            //EvenDocumentChangeName.Changer(longerPath);

        }
    }
}
