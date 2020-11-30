using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SQLServerForCSharpDevelopers.Controllers.Controllers.Sales.V1.Manager {
    public partial class ManagerController {
        [HttpPost("Create")]
        public IActionResult CreateManager() {
            return Ok();
        }

        [HttpPatch("Update")]
        public IActionResult UpdateManager() {
            return Ok();
        }

        [HttpDelete("Delete")]
        public IActionResult DeleteManager() {
            return Ok();
        }
    }
}
