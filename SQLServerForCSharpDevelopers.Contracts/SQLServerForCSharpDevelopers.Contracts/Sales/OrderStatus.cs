using System;
using System.Collections.Generic;
using System.Text;

namespace SQLServerForCSharpDevelopers.Contracts.SQLServerForCSharpDevelopers.Contracts.Sales {
    public enum OrderStatus {
        Ordered = 1,
        Shipped,
        Cancelled,
        Refunded
    }
}
