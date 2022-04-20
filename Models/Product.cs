using System;
using System.Collections.Generic;

#nullable disable

namespace KeyboardShopManagerment_Assignment_PRN211.Models
{
    public partial class Product
    {
      

        public int Id { get; set; }
        public string Name { get; set; }
        public double? Price { get; set; }
        public int? Quantity { get; set; }
        public bool? Status { get; set; }
        public int? CatagoryId { get; set; }

        
        public virtual Category Catagory { get; set; }
        public Product()
        {

        }
        public Product(int id, string name, double? price, int? quantity, bool? status, int? catagoryId)
        {
            Id = id;
            Name = name;
            Price = price;
            Quantity = quantity;
            Status = status;
            CatagoryId = catagoryId;
        }
    }
}
