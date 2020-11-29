using System.Collections.Generic;
using SQLServerForCSharpDevelopers.Contracts.Sales;

namespace SQLServerForCSharpDevelopers.Contracts.Filters {
    public class StoreFilter {
        public IEnumerable<Address> Address { get; set; }
    }
}
