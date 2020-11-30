using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SQLServerForCSharpDevelopers.Controllers.Controllers.Sales.V1.Customer {
    public partial class CustomerController {
        [HttpGet("Read")]
        public IActionResult ReadCustomer() {
            return Ok();
        }
    }
}
