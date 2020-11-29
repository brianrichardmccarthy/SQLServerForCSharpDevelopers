using System;
using Microsoft.AspNetCore.Mvc;

namespace SQLServerForCSharpDevelopers.Controllers.Controllers.Products.V1.Stock {
    public partial class StockController {
        [HttpGet("Read")]
        public IActionResult Read() {
            return Ok();
        }
    }
}
