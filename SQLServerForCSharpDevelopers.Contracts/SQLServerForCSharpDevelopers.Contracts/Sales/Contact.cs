using System;

namespace SQLServerForCSharpDevelopers.Contracts.SQLServerForCSharpDevelopers.Contracts.Sales {
    public class Contact {
        public Guid? ContactId { get; set; }
        public int? PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
    }
}
