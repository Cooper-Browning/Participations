using System;
using System.Collections.Generic;
using System.Text;

namespace ContactPt2
{
    public class Contact
    {
        public int ID {get; set;}

        public string FirstName {get; set;}

        public string LastName {get; set;}

        public string Email {get; set;}

        public string Photo { get; set; }

        public Contact()
        {
            ID = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
            Email = string.Empty;
            Photo = string.Empty;
        }


        public Contact(string contact)
        {
            string[] contacts = contact.Split('|');

            ID = Convert.ToInt32(contacts[0]);
            FirstName = contacts[1];
            LastName = contacts[2];
            Email = contacts[3];
            Photo = contacts[4];
        }
        public override string ToString()
        {
            return $"{LastName}, {FirstName}";
        }

        


    }
}
