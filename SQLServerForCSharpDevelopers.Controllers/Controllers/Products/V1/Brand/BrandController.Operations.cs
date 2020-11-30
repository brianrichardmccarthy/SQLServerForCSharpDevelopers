using System;
using Microsoft.AspNetCore.Mvc;

namespace SQLServerForCSharpDevelopers.Controllers.Controllers.Products.V1.Brand {
    public partial class BrandController {
        [HttpPost("Create")]
        public IActionResult Create([FromBody] Contracts.Products.Brand brand) {
            return Ok();
        }

        [HttpPatch("Update")]
        public IActionResult UpdateBrand([FromBody] Contracts.Products.Brand brand) {
            return Ok();
        }

        [HttpDelete("delete")]
        public IActionResult DeleteBrand([FromBody] Contracts.Products.Brand brand) {
            return Ok();
        }
    }
}
