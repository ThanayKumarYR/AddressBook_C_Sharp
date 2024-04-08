using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace AddressBook
{
    class Jsoned
    {
        public string Serializable(List<Contacts> contacts)
        {
            if (contacts is null)
            {
                throw new ArgumentNullException(nameof(contacts));
            }

            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = true;
            string temp = JsonSerializer.Serialize(contacts, options);
            return temp;
        }
    }
}
