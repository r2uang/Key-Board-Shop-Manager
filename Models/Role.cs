﻿using System;
using System.Collections.Generic;

#nullable disable

namespace KeyboardShopManagerment_Assignment_PRN211.Models
{
    public partial class Role
    {
        public Role()
        {
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string RoleName { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
