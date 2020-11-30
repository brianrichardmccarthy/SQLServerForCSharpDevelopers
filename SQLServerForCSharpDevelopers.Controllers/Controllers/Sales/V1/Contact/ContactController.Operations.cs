using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SQLServerForCSharpDevelopers.Controllers.Controllers.Sales.V1.Contact {
    public partial class ContactController {
        [HttpPost("Create")]
        public IActionResult CreateContact() {
            return Ok();
        }

        [HttpPatch("Update")]
        public IActionResult UpdateContact() {
            return Ok();
        }

        [HttpDelete("Delete")]
        public IActionResult DeleteContact() {
            return Ok();
        }
    }
}
