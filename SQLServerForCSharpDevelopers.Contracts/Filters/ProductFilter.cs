using System.Collections.Generic;
using SQLServerForCSharpDevelopers.Contracts.Products;

namespace SQLServerForCSharpDevelopers.Contracts.Filters {
    public class ProductFilter {
        public IEnumerable<Brand> Brands { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public int? MinYear { get; set; }
        public int? MaxYear { get; set; }
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }
    }
}
