using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SQLServerForCSharpDevelopers.Controllers.Controllers.Sales.V1.Store {
    public partial class StoreController {
        [HttpPost("Create")]
        public IActionResult CreateStore() {
            return Ok();
        }

        [HttpPatch("Update")]
        public IActionResult UpdateStore() {
            return Ok();
        }

        [HttpDelete("Delete")]
        public IActionResult DeleteStore() {
            return Ok();
        }
    }
}
