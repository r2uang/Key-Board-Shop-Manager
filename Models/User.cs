using System;
using System.Collections.Generic;

#nullable disable

namespace KeyboardShopManagerment_Assignment_PRN211.Models
{
    public partial class User
    {
        public User()
        {
            
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phonenumber { get; set; }
        public bool? Status { get; set; }
        public int? RoleId { get; set; }

        public virtual Role Role { get; set; }
        public virtual ICollection<Bill> Bills { get; set; }
    }
}
