using System;
using System.Collections;
using System.Collections.Generic;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book !\n");
            ArrayList list = new ArrayList();
            while (true) 
            {
                Console.WriteLine("\nEnter 1 -> adding person's contact.");
                Console.WriteLine("Enter 2 -> edit contact via name.");
                Console.WriteLine("Enter 3 -> delete contact.");
                Console.WriteLine("Enter 4 -> display contacts.");
                Console.WriteLine("Enter 5 -> exiting the addressbook.\n");

                Console.Write("Enter the choice = ");
                int choice = int.Parse(Console.ReadLine());
                Console.WriteLine();
                    
                switch (choice)
                {
                    case 1: 
                        Console.WriteLine("Adding contact details !");
                        Contacts contacts = AddDetails.AddingDetails();
                        list.Add(contacts);
                        contacts.display();
                        break;
                    case 2:
                        if (list.Count > 0)
                            EditContacts.EditingContacts(list);
                        else Console.WriteLine("Address book is empty !, please add contacts and then edit!");
                        break;
                    case 3:
                        if (list.Count > 0)
                            DeleteContact.DeletingContacts(list);
                        else Console.WriteLine("Address book is empty !, please add contacts and then delete!");
                        break;

                    case 4:
                        foreach (Contacts contact in list)
                        {
                            contact.display();
                        }
                        break;
                    case 5:return;
                    default:Console.WriteLine("Invalid input, enter value between 1 to 4");
                        break;

                        //everything upto date
                }
            }
        }
    }
}
