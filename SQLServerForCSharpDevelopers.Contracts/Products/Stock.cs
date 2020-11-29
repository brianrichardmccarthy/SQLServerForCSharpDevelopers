using SQLServerForCSharpDevelopers.Contracts.Sales;

namespace SQLServerForCSharpDevelopers.Contracts.Products {
    public class Stock {
        public Store Store { get; set; }
        public Product Product { get; set; }
        public int? Quantity { get; set; }
    }
}
