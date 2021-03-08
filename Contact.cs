using System.Collections.Generic;

namespace AddressBook
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        //add public computed property full name
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

    }
}