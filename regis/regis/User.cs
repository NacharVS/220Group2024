using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace regis
{
    internal class User
    {
        public User(string name, string surname, string phone_number, string email)
        {
            Name = name;
            Surname = surname;
            Phone_number = phone_number;
            Email = email;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone_number { get; set; }
        public string Email { get; set; }
    }
}