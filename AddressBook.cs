using System;
using System.Collections.Generic;

namespace AddressBook
{
    // Create an Addressbook and add some contacts to it
    //created public property Contacts whose value type is Dictionary. Keys are strings, and values are Contact instances
    public class AddressBook
    {
        // Using a Dictionary in the AddressBook class to store Contacts. The key should be the contact's email address.
        // Constacts is our object 
        public Dictionary<string, Contact> Contacts = new Dictionary<string, Contact>();
        public void AddContact(Contact contactObj)
        {
            try
            {
                {
                    Contacts.Add(contactObj.Email, contactObj); //contact is the variable we created, it's the taco
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("No no no. Contact has already been added!");
            }
        }

        public Contact GetByEmail(string theEmailKey)
        {
            try
            {
                return Contacts[theEmailKey];
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("The given key 'not.in.addressbook@email.com' was not present in the dictionary.");
                return null;
            }
        }
    }
}


