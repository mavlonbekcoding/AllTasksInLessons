using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N23_HT2
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }

    public User(string firstName, string lastName, string email)
    {
        this.FirstName = firstName;
        LastName = lastName;
        Email = email;
    }
}
