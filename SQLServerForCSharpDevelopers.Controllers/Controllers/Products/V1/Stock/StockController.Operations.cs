using System;
using Microsoft.AspNetCore.Mvc;

namespace SQLServerForCSharpDevelopers.Controllers.Controllers.Products.V1.Stock {
    public partial class StockController {
        [HttpPost("Create")]
        public IActionResult CreateStock([FromBody] Contracts.Products.Stock stock) {
            return Ok();
        }

        [HttpPatch("Update")]
        public IActionResult UpdateStock([FromBody] Contracts.Products.Stock stock) {
            return Ok();
        }

        [HttpPatch("Delete")]
        public IActionResult DeleteStock() {
            return Ok();
        }
    }
}
