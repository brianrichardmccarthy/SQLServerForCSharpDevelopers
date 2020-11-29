using System;
using System.Collections.Generic;
using System.Text;
using SQLServerForCSharpDevelopers.Contracts.Sales;

namespace SQLServerForCSharpDevelopers.Contracts.Filters {
    public class OrderFilter {
        public IEnumerable<Store> Stores { get; set; }
        public OrderStatus? Status { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
    }
}
