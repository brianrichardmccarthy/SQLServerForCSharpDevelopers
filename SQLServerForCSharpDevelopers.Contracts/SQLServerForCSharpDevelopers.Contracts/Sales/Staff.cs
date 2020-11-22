using System;
using System.Collections.Generic;
using System.Text;

namespace SQLServerForCSharpDevelopers.Contracts.SQLServerForCSharpDevelopers.Contracts.Sales {
    public class Staff {
        public Guid StaffId { get; set; }
        public Store Store { get; set; }
        public Address Address { get; set; }
        public Contact Contact { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public bool? Active { get; set; }
        public Manager Manager { get; set; }
    }
}
