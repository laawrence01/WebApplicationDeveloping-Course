using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Proiect_DAW.Models
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }
        public string Type { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
