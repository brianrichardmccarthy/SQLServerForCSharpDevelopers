using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SQLServerForCSharpDevelopers.Controllers.Controllers.Sales.V1.OrderDetails {
    public partial class OrderDetailsController {
        [HttpGet("Read")]
        public IActionResult ReadOrderDetails() {
            return Ok();
        }
    }
}
