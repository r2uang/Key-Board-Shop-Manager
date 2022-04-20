using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyboardShopManagerment_Assignment_PRN211.Models
{
    class Cash
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int? Quantity { get; set; }
        public double? Price { get; set; }

        public string transactionNo { get; set; }
        public string Cashier { get; set; }

        public double? Total { get; set; }

        public Cash(int id, string productName, int? quantity, double? price, string cashier)
        {
            Id = id;
            ProductName = productName;
            Quantity = quantity;
            Price = price;
            Cashier = cashier;
        }
    }
}
