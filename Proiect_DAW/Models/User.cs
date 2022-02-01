using System;
using System.Collections.Generic;

namespace Proiect_DAW.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public ICollection<Recipe> Recipes { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }

    }
}
