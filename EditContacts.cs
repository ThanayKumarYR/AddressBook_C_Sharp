using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class EditContacts
    {
        public static void EditingContacts(ArrayList list)
        {
            Console.WriteLine("Editing Contacts");
            Console.Write("Enter the First name: ");
            string firstname = Console.ReadLine();
            Console.Write("Enter the Last name: ");
            string lastname = Console.ReadLine();

            if (firstname.Length == 0 || lastname.Length == 0)
            {
                Console.WriteLine("Name cannot be null");
                return;
            }
            else if (firstname.Length > 0 && lastname.Length > 0)
            {
                foreach (Contacts item in list)
                {
                    if (item.FirstName == firstname && item.LastName == lastname)
                    {
                        while (true)
                        {
                            Console.WriteLine("\nEnter 1 -> edit First Name");
                            Console.WriteLine("Enter 2 -> edit Last Name");
                            Console.WriteLine("Enter 3 -> edit email ");
                            Console.WriteLine("Enter 4 -> edit phone number");
                            Console.WriteLine("Enter 5 -> edit address");
                            Console.WriteLine("Enter 6 -> edit city");
                            Console.WriteLine("Enter 7 -> edit state");
                            Console.WriteLine("Enter 8 -> edit zip code");
                            Console.WriteLine("Enter 9 -> exit editing\n");

                            Console.Write("Enter the choice = ");
                            int choice = int.Parse(Console.ReadLine());

                            switch (choice)
                            {
                                case 1:
                                    Console.Write("\nEdit the First name = ");
                                    item.FirstName = Console.ReadLine();
                                    break;
                                case 2:
                                    Console.Write("\nEdit the Last name = ");
                                    item.LastName = Console.ReadLine();
                                    break;
                                case 3:
                                    Console.Write("\nEdit the Email = ");
                                    item.Email = Console.ReadLine();
                                    break;
                                case 4:
                                    Console.Write("\nEdit the Phone Number = ");
                                    item.PhoneNumber = Console.ReadLine();
                                    break;
                                case 5:
                                    Console.Write("\nEdit the Address = ");
                                    item.Address = Console.ReadLine();
                                    break;
                                case 6:
                                    Console.Write("\nEdit the City = ");
                                    item.City = Console.ReadLine();
                                    break;
                                case 7:
                                    Console.Write("\nEdit the State = ");
                                    item.State = Console.ReadLine();
                                    break;
                                case 8:
                                    Console.Write("\nEdit the Zip Code = ");
                                    item.ZipCode = Console.ReadLine();
                                    break;
                                case 9:
                                    return;
                                default:
                                    Console.WriteLine("Invalid input !");
                                    break;
                            }

                        }
                    }
                    else 
                    {
                        Console.WriteLine("Entered name is not in the Address Book !");
                    }
                }
            }

        }
    }
}
