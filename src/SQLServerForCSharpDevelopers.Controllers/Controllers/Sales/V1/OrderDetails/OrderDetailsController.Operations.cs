using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SQLServerForCSharpDevelopers.Controllers.Controllers.Sales.V1.OrderDetails {
    public partial class OrderDetailsController {
        [HttpPost("Create")]
        public IActionResult CreateOrderDetails() {
            return Ok();
        }

        [HttpPatch("Update")]
        public IActionResult UpdateOrderDetails() {
            return Ok();
        }

        [HttpDelete("Delete")]
        public IActionResult DeleteOrderDetails() {
            return Ok();
        }
    }
}
