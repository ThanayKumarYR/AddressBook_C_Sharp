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
                Console.WriteLine("Enter 1 -> adding person's contact.");
                Console.WriteLine("Enter 2 -> edit contact via name.");
                Console.WriteLine("Enter 3 -> delete contact.");
                Console.WriteLine("Enter 4 -> exiting the addressbook.");

                Console.Write("Enter the choice = ");
                int choice = int.Parse(Console.ReadLine());
                    
                switch (choice)
                {
                    case 1: 
                        Console.WriteLine("Adding contact details !");
                        Contacts contacts = AddDetails.AddingDetails();
                        list.Add(contacts);
                        break;
                    case 4: return;
                    default:Console.WriteLine("Invalid input, enter value between 1 to 4");
                        break;
                }
            }
        }
    }
}
