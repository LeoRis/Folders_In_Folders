using System;
using System.Collections.Generic;
using System.Net.Mail;

namespace DifferentBasic
{
    public class HomeworkMenu
    {
        public string InitialSelector { get; set; }
        public string EmailSubmenu { get; set; }
        public string EmailAddress { get; set; }
        public string EmailSubject { get; set; }
        public string EmailBody { get; set; }
        public string EmailAmend { get; set; }
        public string FtpPath { get; set; }

        public static void CreateMenu()
        {
            HomeworkMenu menu = new HomeworkMenu();

            Console.WriteLine("Hello and welcome to our console application.\n");
            
            do
            {
                Quit:
                Console.WriteLine("Please select one of the following options:\n 1. Send email\n 2. Create FTP backup.\n 3. Quit");
                menu.InitialSelector = Console.ReadLine();
                if (menu.InitialSelector == "1")
                {
                    do
                    {
                        Console.WriteLine("Please enter valid email address:\nFor ex: test@test.test");
                        menu.EmailAddress = Console.ReadLine();
                        if (menu.EmailAddress.Contains("@"))
                        {
                            BuildEmail.To = menu.EmailAddress;
                        }
                        else
                        {
                            while (!menu.EmailAddress.Contains("@"))
                            {
                                Console.WriteLine("Email address is not valid - please try again.");
                                menu.EmailAddress = Console.ReadLine();
                                BuildEmail.To = menu.EmailAddress;
                            }
                        }
                        Console.WriteLine("Please enter the subject of the message: ");
                        menu.EmailSubject = Console.ReadLine();
                        BuildEmail.Subject = menu.EmailSubject;
                        Console.WriteLine("Please enter the body of the message: ");
                        menu.EmailBody = Console.ReadLine();
                        BuildEmail.Body = menu.EmailBody;
                    comeBackAgain:
                        Console.WriteLine("Would you like to send the email? Y/N");
                        menu.EmailSubmenu = Console.ReadLine().ToLower();
                        if(menu.EmailSubmenu == "y")
                        {
                            BuildEmail.SendMailCustomBody();
                            Console.WriteLine("Message sent.");
                            break;
                        }
                        else if(menu.EmailSubmenu == "n")
                        {
                        comeBackHere:
                            Console.WriteLine("Would you like to amend the email? Y/N");
                            menu.EmailAmend = Console.ReadLine().ToLower();
                            if(menu.EmailAmend == "y")
                            {
                                Console.WriteLine("Would you like to change the subject of the message, or the body?\nPress \"S\" for subject, or \"B\" for body.");
                                string emailChanger = Console.ReadLine().ToLower();
                                if (emailChanger == "s")
                                {
                                    Console.WriteLine("Please add the new subject:");
                                    menu.EmailSubject = Console.ReadLine();
                                    BuildEmail.Subject = menu.EmailSubject;
                                    BuildEmail.SendMailCustomBody();
                                    Console.WriteLine("Message sent.");
                                    break;
                                }
                                else if (emailChanger == "b")
                                {
                                    Console.WriteLine("Please add the new body:");
                                    menu.EmailBody = Console.ReadLine();
                                    BuildEmail.Body = menu.EmailBody;
                                    BuildEmail.SendMailCustomBody();
                                    Console.WriteLine("Message sent.");
                                    break;
                                }
                                else
                                {
                                    while (emailChanger != "s" || emailChanger != "b")
                                    {
                                        Console.WriteLine("Wrong selection - please try again.");
                                        goto comeBackHere;
                                    }
                                }
                            }
                            else if(menu.EmailAmend == "n")
                            {
                                goto Quit;
                            }
                            else
                            {
                                while (menu.EmailAmend != "s" || menu.EmailAmend != "b")
                                {
                                    Console.WriteLine("Wrong selection - please try again.");
                                    goto comeBackHere;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Wrong selection - please try again.");
                            goto comeBackAgain;
                            
                        }
                    }
                    while (true);
                }
                else if(menu.InitialSelector == "2")
                {
                    Console.WriteLine("Please provide a path for your local file:");
                    menu.FtpPath = Console.ReadLine();
                    Console.WriteLine("Please enter host:");

                }
                else if(menu.InitialSelector == "3")
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