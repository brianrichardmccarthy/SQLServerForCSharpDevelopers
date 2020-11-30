using System;

namespace SQLServerForCSharpDevelopers.Contracts.Sales {
    public class Customer {
        public Guid CustomerId { get; set; }
        public Address Address { get; set; }
        public Contact Contact { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
    }
}
