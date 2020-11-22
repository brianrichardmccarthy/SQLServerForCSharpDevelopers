using System;
using System.Collections.Generic;
using System.Text;

namespace SQLServerForCSharpDevelopers.Contracts.SQLServerForCSharpDevelopers.Contracts.Sales {
    public class Store {
        public Guid StoreId { get; set; }
        public Address Address { get; set; }
        public Contact Contact { get; set; }
    }
}
