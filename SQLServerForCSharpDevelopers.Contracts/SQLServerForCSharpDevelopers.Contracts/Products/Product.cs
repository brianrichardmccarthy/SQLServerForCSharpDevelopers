using System;
using System.Collections.Generic;
using System.Text;

namespace SQLServerForCSharpDevelopers.Contracts.SQLServerForCSharpDevelopers.Contracts.Products {
    public class Product {
        public Guid ProductId { get; set; }
        public Brand ProductBrand { get; set; }
        public Category ProductCategory { get; set; }
        public int ModelYear { get; set; }
        public decimal Price { get; set; }
    }
}
