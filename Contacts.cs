using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class Contacts
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private string Email { get; set; }
        private string PhoneNumber { get; set; }
        private string Address { get; set; }
        private string City { get; set; }
        private string State { get; set; }
        private string ZipCode { get; set; }
        
        public Contacts(string firstname, string lastname, string email,string phonenumber, string address, string city,string state, string zipcode ) 
        
        {
            FirstName = firstname;  
            LastName = lastname;    
            Email = email;
            PhoneNumber = phonenumber;
            Address = address;
            City = city;
            State = state;
            ZipCode = zipcode;

        }
    }
}
