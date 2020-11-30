using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SQLServerForCSharpDevelopers.Controllers.Controllers.Sales.V1.Order {
    public partial class OrderController {
        [HttpGet("Read")]
        public IActionResult ReadOrder() {
            return Ok();
        }
    }
}
