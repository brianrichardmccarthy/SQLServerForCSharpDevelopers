using System;
using Microsoft.AspNetCore.Mvc;

namespace SQLServerForCSharpDevelopers.Controllers.Controllers.Products.V1.Stock {
    public partial class StockController {
        [HttpGet("{id}")]
        public IActionResult GetBrand(Guid id) {
            return Ok();
        }

        [HttpGet("StoreStock/{id}")]
        public IActionResult GetStoreProductStock(Guid id) {
            return Ok();
        }

        [HttpGet("ProductStock/{id}")]
        public IActionResult GetProductStockInAllStores(Guid id) {
            return Ok();
        }

        [HttpGet("GetStoreStock/{id}")]
        public IActionResult GetStoreStock(Guid id) {
            return Ok();
        }

        [HttpGet("ProductInStore/{productId}/{storeId}")]
        public IActionResult ProductInStore(Guid productId, Guid storeId) {
            return Ok();
        }
    }
}
