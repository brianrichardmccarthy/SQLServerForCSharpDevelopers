using Microsoft.AspNetCore.Mvc;

namespace SQLServerForCSharpDevelopers.Controllers.Controllers.Products.V1.Category {
    public partial class CategoryController {
        [HttpPost("Create")]
        public IActionResult CreateCategory([FromBody] Contracts.Products.Category category) {
            return Ok();
        }

        [HttpPatch("Update")]
        public IActionResult UpdateCategory([FromBody] Contracts.Products.Category category) {
            return Ok();
        }

        [HttpDelete("Delete")]
        public IActionResult DeleteCategory([FromBody] Contracts.Products.Category category) {
            return Ok();
        }
    }
}
