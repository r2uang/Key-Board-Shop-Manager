using System;
using System.Collections.Generic;

#nullable disable

namespace KeyboardShopManagerment_Assignment_PRN211.Models
{
    public partial class Customer
    {

        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Phonenumber { get; set; }

        public virtual ICollection<Bill> Bills { get; set; }
    }
}
