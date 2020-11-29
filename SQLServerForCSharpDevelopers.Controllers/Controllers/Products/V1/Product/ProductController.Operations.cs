using Microsoft.AspNetCore.Mvc;

namespace SQLServerForCSharpDevelopers.Controllers.Controllers.Products.V1.Product {
    public partial class ProductController {
        [HttpPost("Create")]
        public IActionResult CreateProducts() {
            return Ok();
        }

        [HttpPatch("Update")]
        public IActionResult UpdateProducts() {
            return Ok();
        }

        [HttpDelete("Delete")]
        public IActionResult DeleteProducts() {
            return Ok();
        }
    }
}
