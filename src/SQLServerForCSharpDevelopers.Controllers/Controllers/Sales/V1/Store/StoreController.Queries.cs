using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SQLServerForCSharpDevelopers.Controllers.Controllers.Sales.V1.Store {
    public partial class StoreController {
        [HttpGet("Read")]
        public IActionResult ReadStore() {
            return Ok();
        }
    }
}
