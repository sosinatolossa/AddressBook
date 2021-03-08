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
                Console.WriteLine("it broke");
            }
        }

        public Contact GetByEmail(string theEmailKey)
        {
            return Contacts[theEmailKey];
        }
    }
}


