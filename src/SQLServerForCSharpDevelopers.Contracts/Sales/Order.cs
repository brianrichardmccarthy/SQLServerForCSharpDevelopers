using System;

namespace SQLServerForCSharpDevelopers.Contracts.Sales {
    public class Order {
        public Guid OrderId { get; set; }
        public Store Store { get; set; }
        public Staff Staff { get; set; }
        public Customer Customer { get; set; }
        public OrderStatus Status { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public DateTimeOffset? ShippedDate { get; set; }
        public DateTimeOffset? RefundDate { get; set; }
    }
}
