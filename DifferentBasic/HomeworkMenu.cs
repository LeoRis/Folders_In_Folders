using System;
using System.Collections.Generic;
using System.Net.Mail;

namespace DifferentBasic
{
    public class HomeworkMenu
    {   
        public static void CreateMenu()
        {
            BuildEmail email = new BuildEmail();
            MailMessage newEmail = new MailMessage();

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
                        Console.WriteLine("Please enter valid email address:\nFor ex: test@test.test");
                        emailAddress = Console.ReadLine();
                        if (emailAddress.Contains("@"))
                        {
                            BuildEmail.To = emailAddress;
                        }
                        else
                        {
                            while (!emailAddress.Contains("@"))
                            {
                                Console.WriteLine("Email address is not valid - please try again.");
                                emailAddress = Console.ReadLine();
                                BuildEmail.To = emailAddress;
                            }
                        }
                        Console.WriteLine("Please enter the subject of the message: ");
                        emailSubject = Console.ReadLine();
                        BuildEmail.Subject = emailSubject;
                        Console.WriteLine("Please enter the body of the message: ");
                        emailBody = Console.ReadLine();
                        BuildEmail.Body = emailBody;
                        Console.WriteLine("Would you like to send the email? Y/N");
                        emailSubmenu = Console.ReadLine().ToLower();
                        if(emailSubmenu == "y")
                        {
                            BuildEmail.SendMailCustomBody();
                            Console.WriteLine("Message sent.");
                        }
                        else if(emailSubmenu == "n")
                        {
                            Console.WriteLine("Would you like to amend the email? Y/N");
                            emailAmend = Console.ReadLine().ToLower();
                            if(emailAmend == "y")
                            {
                                Console.WriteLine("Would you like to change the subject of the message, or the body?\nPress \"S\" for subject, or \"B\" for body.");
                                if (Console.ReadLine().ToLower() == "s")
                                {
                                    Console.WriteLine("Please add the new subject:");
                                    emailSubject = Console.ReadLine();
                                    BuildEmail.Subject = emailSubject;
                                }
                                else if (Console.ReadLine().ToLower() == "b")
                                {
                                    Console.WriteLine("Please add the new body:");
                                    emailBody = Console.ReadLine();
                                    BuildEmail.Body = emailBody;
                                }
                                else
                                {
                                    Console.WriteLine("Wrong selection - please try again.");
                                }
                            }
                            else if(emailAmend == "n")
                            {

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