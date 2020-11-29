using System;
using Microsoft.AspNetCore.Mvc;

namespace SQLServerForCSharpDevelopers.Controllers.Controllers.Products.V1.Category {
    public partial class CategoryController {
        [HttpGet("Read")]
        public IActionResult GetCategory(Guid id) {
            return Ok();
        }
    }
}
