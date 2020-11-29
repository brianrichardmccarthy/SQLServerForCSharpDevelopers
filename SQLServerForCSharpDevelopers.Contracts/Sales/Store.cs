using System;

namespace SQLServerForCSharpDevelopers.Contracts.Sales {
    public class Store {
        public Guid StoreId { get; set; }
        public Address Address { get; set; }
        public Contact Contact { get; set; }
    }
}
