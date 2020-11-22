using System;
using System.Collections.Generic;
using System.Text;

namespace SQLServerForCSharpDevelopers.Contracts.SQLServerForCSharpDevelopers.Contracts.Sales {
    public class Customer {
        public Guid CustomerId { get; set; }
        public Address Address { get; set; }
        public Contact Contact { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
    }
}
