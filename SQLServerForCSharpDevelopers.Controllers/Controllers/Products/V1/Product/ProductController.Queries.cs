using Microsoft.AspNetCore.Mvc;

namespace SQLServerForCSharpDevelopers.Controllers.Controllers.Products.V1.Product {
    public partial class ProductController {
        [HttpGet("Read")]
        public IActionResult ReadProduct() {
            return Ok();
        }
    }
}
