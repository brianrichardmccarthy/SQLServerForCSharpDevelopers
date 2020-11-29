using System;

using Microsoft.AspNetCore.Mvc;

namespace SQLServerForCSharpDevelopers.Controllers.Controllers.Products.V1.Brand {
    public partial class BrandController {
        [HttpGet("Read")]
        public IActionResult GetBrand() {
            return Ok();
        }
    }
}
