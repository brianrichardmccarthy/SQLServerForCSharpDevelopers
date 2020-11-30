using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SQLServerForCSharpDevelopers.Controllers.Controllers.Sales.V1.Manager {
    public partial class ManagerController {
        [HttpGet("Read")]
        public IActionResult ReadManager() {
            return Ok();
        }
    }
}
