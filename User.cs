using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical3
{
    /// <summary>
    /// Класс User
    /// </summary>
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public User() { }
        public User(string name, string email, string role)
        {
            Name = name;
            Email = email;
            Role = role;
        }
    }
}
