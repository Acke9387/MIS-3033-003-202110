using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_ContactList
{
    public class Contact
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Photo { get; set; }


        public Contact()
        {
            Id = 0;
            FirstName = string.Empty;
            LastName    = string.Empty;
            Email       = string.Empty;
            Photo       = string.Empty;
        }

        public Contact(int id, string first, string last, string email, string photo)
        {
            Id = id;
            FirstName = first;
            LastName = last;
            Email = email;
            Photo = photo;
        }

        public override string ToString()
        {
            return $"{LastName}, {FirstName}";
        }
    }
}
