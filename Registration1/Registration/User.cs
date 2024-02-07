using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration
{
    class User
    {
        public User(string name, string surname, string phone, string email)
        {
            Name = name;
            Surname = surname;
            PhoneNumber = phone;
            Email = email;
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
