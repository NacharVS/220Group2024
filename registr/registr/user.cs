using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace registr
{
    internal class user
    {
        public user(string name, string surname, string otchestvo, string phone, string email)
        {
            Name = name;
            Surname = surname;
            Otchestvo = otchestvo;
            Phone = phone;
            Email = email;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Otchestvo { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
