using System;
using System.Collections.Generic;
using System.Text;

namespace SQLServerForCSharpDevelopers.Contracts.SQLServerForCSharpDevelopers.Contracts.Sales {
    public class Order {
        public Guid OrderId { get; set; }
        public Store Store { get; set; }
        public Staff Staff { get; set; }
        public Customer Customer { get; set; }
        public OrderStatus Status { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public DateTime RefundDate { get; set; }
    }
}
