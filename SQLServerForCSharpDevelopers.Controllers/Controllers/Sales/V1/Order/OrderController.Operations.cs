using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SQLServerForCSharpDevelopers.Controllers.Controllers.Sales.V1.Order {
    public partial class OrderController {
        [HttpPost("Create")]
        public IActionResult CreateOrder() {
            return Ok();
        }

        [HttpPatch("Update")]
        public IActionResult UpdateOrder() {
            return Ok();
        }

        [HttpDelete("Delete")]
        public IActionResult DeleteOrder() {
            return Ok();
        }
    }
}
