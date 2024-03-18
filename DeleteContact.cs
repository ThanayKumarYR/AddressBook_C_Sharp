using System;
using System.Collections;


namespace AddressBook
{
    class DeleteContact
    {
        public static void DeletingContacts(ArrayList list)
        {
            Console.WriteLine("Deleting Contacts");
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
                        Console.WriteLine("Confirm delation !");
                        Console.Write("Press Y || y for YES = ");
                        char decision = char.Parse(Console.ReadLine());
                        if (decision == 'Y' || decision == 'y')
                        {
                            list.Remove(item);
                            Console.WriteLine("Successfully deleted !");
                        }
                        else 
                        {
                            Console.WriteLine("Invalid input !"); 
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
