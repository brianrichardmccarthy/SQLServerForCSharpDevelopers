using System;

using Microsoft.AspNetCore.Mvc;

namespace SQLServerForCSharpDevelopers.Controllers.Controllers.Products.V1.Brand {
    public partial class BrandController {
        [HttpGet("{id}")]
        public IActionResult GetBrand(Guid id) {
            return Ok();
        }

        [HttpGet("Find/{desc}")]
        public IActionResult FindBrand(string desc) {
            return Ok();
        }

        [HttpGet("Brands")]
        public IActionResult GetAllBrands() {
            return Ok();
        }
    }
}
