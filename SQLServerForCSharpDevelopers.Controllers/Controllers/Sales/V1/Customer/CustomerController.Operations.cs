using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SQLServerForCSharpDevelopers.Controllers.Controllers.Sales.V1.Customer {
    public partial class CustomerController {
        [HttpPost("Create")]
        public IActionResult CreateCustomer() {
            return Ok();
        }

        [HttpPatch("Update")]
        public IActionResult UpdateCustomer() {
            return Ok();
        }

        [HttpDelete("Delete")]
        public IActionResult DeleteCustomer() {
            return Ok();
        }
    }
}
