using System;
using Microsoft.AspNetCore.Mvc;

namespace SQLServerForCSharpDevelopers.Controllers.Controllers.Products.V1.Category {
    public partial class CategoryController {
        [HttpGet("{id}")]
        public IActionResult GetCategory(Guid id) {
            return Ok();
        }

        [HttpGet("Find/{desc}")]
        public IActionResult FindCategory(string desc) {
            return Ok();
        }

        [HttpGet("Categories")]
        public IActionResult GetAllCategory() {
            return Ok();
        }
    }
}
