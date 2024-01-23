using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfRegistration
{
    internal class User
    {

        public User(string name, string age, string gender, string number)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Number = number;
        }

        public string Name { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public string Number { get; set; }

        //public static List<User> GetUsers()
        //{
        //    List<User> users = new List<User>();
        //    users.Add(new User("Bob", ""));
        //    users.Add(new User("Jeff", 33));
        //    users.Add(new User("John", 24));
        //    users.Add(new User("Sam", 25));
        //    users.Add(new User("Jim", 34));
        //    return users;
        //}

        //public static List<string> GetUsersNames()
        //{
        //    List<string> list = new List<string>();
        //    foreach (var item in GetUsers())
        //    {
        //        list.Add(item.Name);
        //    }
        //    return list;    
        //}
    }
}
