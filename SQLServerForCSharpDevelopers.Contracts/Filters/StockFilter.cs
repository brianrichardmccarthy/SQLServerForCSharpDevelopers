using System.Collections.Generic;
using SQLServerForCSharpDevelopers.Contracts.Products;
using SQLServerForCSharpDevelopers.Contracts.Sales;

namespace SQLServerForCSharpDevelopers.Contracts.Filters {
    public class StockFilter {
        public IEnumerable<Store> Stores { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
