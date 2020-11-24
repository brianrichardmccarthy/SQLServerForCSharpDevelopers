using SQLServerForCSharpDevelopers.Contracts.SQLServerForCSharpDevelopers.Contracts.Products;

namespace SQLServerForCSharpDevelopers.Contracts.SQLServerForCSharpDevelopers.Contracts.Sales {
    public class OrderDetails {
        public Order Order { get; set; }
        public Product Product { get; set; }
        public int? Quantity { get; set; }
        public decimal? Price { get; set; }
        public decimal? VAT { get; set; }
        public decimal? Discount { get; set; }
    }
}
