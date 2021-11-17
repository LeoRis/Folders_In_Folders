using System;

namespace DifferentBasic
{
    public class HomeworkMenu
    {
        public static void CreateMenu()
        {

            string initialSelector;
            string emailSubmenu;
            string emailAddress;
            string emailSubject;
            string emailBody;
            string emailAmend;

            Console.WriteLine("Hello and welcome to our console application.\n");
            
            do
            {
                Console.WriteLine("Please select one of the following options:\n 1. Send email\n 2. Create FTP backup.\n 3. Quit");
                initialSelector = Console.ReadLine();
                if (initialSelector == "1")
                {
                    do
                    {
                        Console.WriteLine("Please enter valid email address: ");
                        emailAddress = Console.ReadLine();
                        Console.WriteLine("Please enter the subject of the message: ");
                        emailSubject = Console.ReadLine();
                        Console.WriteLine("Please enter the body of the message: ");
                        emailBody = Console.ReadLine();
                        Console.WriteLine("Would you like to send the email? Y/N");
                        emailSubmenu = Console.ReadLine().ToLower();
                        if(emailSubmenu == "y")
                        {
                            Console.WriteLine("Message sent.");
                        }
                        else if(emailSubmenu == "n")
                        {
                            Console.WriteLine("Would you like to amend the email? Y/N");
                            emailAmend = Console.ReadLine().ToLower();
                            if(emailAmend == "y")
                            {
                                break;
                            }
                        }
                    }
                    while (true);
                }
                else if(initialSelector == "2")
                {

                }
                else if(initialSelector == "3")
                {
                    Console.WriteLine("Have a nice day :)");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid character.");
                }

            }
            while (true);
        }
    }
}