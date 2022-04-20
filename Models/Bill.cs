using System;
using System.Collections.Generic;

#nullable disable

namespace KeyboardShopManagerment_Assignment_PRN211.Models
{
    public partial class Bill
    {
        public int Id { get; set; }
        public string CreatedbyUser { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? ProductId { get; set; }
        public double? TotalPrice { get; set; }
        public int? TotalQuantity { get; set; }
        public string BillNumber { get; set; }

        public virtual Customer Customer { get; set; }

    }
}
