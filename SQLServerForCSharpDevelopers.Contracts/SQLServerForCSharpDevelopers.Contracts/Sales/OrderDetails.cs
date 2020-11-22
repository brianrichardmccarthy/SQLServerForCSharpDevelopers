using System;
using System.Collections.Generic;
using System.Text;

namespace SQLServerForCSharpDevelopers.Contracts.SQLServerForCSharpDevelopers.Contracts.Sales {
    public class OrderDetails {
        public Order Order { get; set; }
        public Products.Product Product { get; set; }
        public int? Quantity { get; set; }
        public decimal? Price { get; set; }
        public decimal? VAT { get; set; }
        public decimal? Discount { get; set; }
    }
}
