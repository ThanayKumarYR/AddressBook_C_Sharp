using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class AddDetails
    {
        public static Contacts AddingDetails()
        {
            Console.Write("\nEnter the first name = ");
            string firstname = Console.ReadLine();
            Console.Write("Enter the last name = ");
            string lastname = Console.ReadLine();
            Console.Write("Enter the email = ");
            string email = Console.ReadLine();
            Console.Write("Enter the phone number = ");
            string phonenumber = Console.ReadLine();
            Console.Write("Enter the address = ");
            string address = Console.ReadLine();
            Console.Write("Enter the city = ");
            string city = Console.ReadLine();
            Console.Write("Enter the state = ");
            string state = Console.ReadLine();
            Console.Write("Enter the ZipCode = ");
            string zipcode = Console.ReadLine();

            Contacts contacts = new Contacts(firstname, lastname, email, phonenumber, address, city, state, zipcode);

            return contacts;
        }
    }
}
