using Microsoft.AspNetCore.Mvc;

namespace SQLServerForCSharpDevelopers.Controllers.Controllers.Products.V1.Product {
    public partial class ProductController {
        [HttpPost("Create")]
        public IActionResult CreateProduct([FromBody] Contracts.Products.Product product) {
            return Ok();
        }

        [HttpPatch("Update")]
        public IActionResult UpdateProduct([FromBody] Contracts.Products.Product product) {
            return Ok();
        }

        [HttpDelete("Delete")]
        public IActionResult DeleteProduct([FromBody] Contracts.Products.Product product) {
            return Ok();
        }
    }
}
