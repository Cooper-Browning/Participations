using System;
using System.Collections.Generic;
using System.Text;

namespace P3
{
    public class Contact
    {
        public string ID {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string Email {get; set;}
        public string Photo {get; set;}

        public Contact()
        {
            ID = string.Empty;
            FirstName = string.Empty;
            LastName = string.Empty;
            Email = string.Empty;
            Photo = string.Empty;

        }

        public Contact(string c)
        {
            //0     1       2           3                           4      
            //1|Kerwinn|Moriarty|kmoriarty0@state.gov|https://kelicommheadshots.com/wp-content/uploads/2019/02/Jen-for-Social-Media-2-256x256.jpg
            string[] contact = c.Split('|');

            ID = contact[0];
            FirstName = contact[1];
            LastName = contact[2];
            Email = contact[3];
            Photo = contact[4];


        }

        public override string ToString()
        {
            return $"{LastName}, {FirstName}";
        }

    }
}
