using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration
{
    internal class User
    {
        public User(string name, string surname, string age, string email)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Email = email;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Age { get; set; }
        public string Email { get; set; }
    }
   
}
