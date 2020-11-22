using System;
using System.Collections.Generic;
using System.Text;
using SQLServerForCSharpDevelopers.Contracts.SQLServerForCSharpDevelopers.Contracts.Sales;

namespace SQLServerForCSharpDevelopers.Contracts.SQLServerForCSharpDevelopers.Contracts.Products {
    public class Stock {
        public Store Store { get; set; }
        public Product Product { get; set; }
        public int? Quantity { get; set; }
    }
}
